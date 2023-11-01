Imports Renci.SshNet
Imports Renci.SshNet.Common

Public Class UnifiDevice
    Public Property Name As String
    Public Property DeviceType As String
    Public Property IP As String
    Public Property IPType As String
    Public Property MacAddress As String
    Public Property Model As String
    Public Property Version As String
    Public Property FullDetails As String
    Public Property Logs As String
    Public Property DeviceLogs As New DeviceLogEntries
    Public Property FixedIP As Boolean
    Public Property Levels As New Dictionary(Of String, String)

    Public Function GetSSHLogs(FromController As UnifiController) As SshCommand

        Dim Result As SshCommand
        Logs = ""
        DeviceLogs.Clear()

        Using client = New SshClient(Me.IP, FromController.DeviceUser, FromController.DevicePassword)
            AddHandler client.HostKeyReceived, AddressOf ClientAccept
            'Try
            client.Connect()
                Result = client.RunCommand("cat /var/log/messages")
                If Result.ExitStatus = 0 Then

                    SplitLogs(Result.Result)

                End If
                client.Disconnect()
            ' Catch ex As Exception
            'Result = Nothing
            'End Try
        End Using
        Return Result
    End Function
    Private Sub SplitLogs(Log As String)
        Logs = Log.Replace(vbLf, vbCrLf)
        Dim LogList As List(Of String) = Log.Split(vbLf).ToList
        For Each entry In LogList
            DeviceLogs.AddNew(entry, Me)
        Next
        ' Now Extract Levels
        Levels.Clear()
        For Each LogEntry In DeviceLogs
            If LogEntry.LogLevel Is Nothing Then
                LogEntry.LogLevel = "Unknown"
            End If
            If Not Levels.ContainsKey(LogEntry.LogLevel) Then
                Levels.Add(LogEntry.LogLevel, LogEntry.LogLevel)
            End If
        Next
    End Sub
    Private Sub ClientAccept(ByVal sender As Object, ByVal e As HostKeyEventArgs)
        e.CanTrust = True
    End Sub
End Class

Public Class DeviceLogEntry
    Public Property Device As UnifiDevice
    Public Property LogWhen As String
    Public Property LogModule As String
    Public Property LogLevel As String
    Public Property LogMessage As String

    Public Property LogReporter As String

    Public Sub New(Log As String, UDevice As UnifiDevice)
        Device = UDevice
        Select Case Device.DeviceType
            Case "ugw"
                Try

                    'Oct 17 15:48:50 Gateway dhcpd: execute_statement argv[0] = /opt/vyatta/sbin/on-dhcp-event.sh
                    ' Time is first 15
                    Me.LogWhen = Log.Substring(0, 15)
                    ' Module is the word before the next :
                    Dim Logsub = Log.Substring(15)
                    ' Gateway dhcpd: execute_statement argv[0] = /opt/vyatta/sbin/on-dhcp-event.sh
                    LogReporter = Logsub.Substring(0, Logsub.Substring(1).IndexOf(" ") + 1).Trim
                    Dim Logsubindex = Logsub.IndexOf(":")
                    Dim Logsub2 = Logsub.Substring(0, Logsubindex)
                    ' Gateway dhcpd
                    LogModule = Logsub2.Substring(Logsub2.LastIndexOf(" ")).Trim
                    LogLevel = "Unknown"
                    LogMessage = Logsub.Substring(Logsub.IndexOf(":") + 2)
                Catch ex As Exception
                    LogMessage = Log
                End Try

            Case Else
                    'Oct 17 15:48:50 Gateway dhcpd: execute_statement argv[0] = /opt/vyatta/sbin/on-dhcp-event.sh
                    'Jan  1 00:00:55 LoftSwitchB syslog.info syslogd started: BusyBox v1.25.1
                    Try
                    ' Time is first 15
                    Me.LogWhen = Log.Substring(0, 15)
                    ' Module is the word before the next space
                    Dim Logsub = Log.Substring(15)
                    ' LoftSwitchB syslog.info syslogd started: BusyBox v1.25.1
                    LogReporter = Logsub.Substring(0, Logsub.Substring(1).IndexOf(" ") + 1).Trim

                    Dim Logsubindex = Logsub.Substring(1).IndexOf(" ") + 1
                    Dim Logsub2 = Logsub.Substring(Logsubindex).Trim
                    Dim Logsub3 = Logsub2.Substring(0, Logsub2.IndexOf(" "))

                    ' Gateway dhcpd
                    LogModule = Logsub3.Substring(0, Logsub3.IndexOf(".")).Trim
                    LogLevel = Logsub3.Substring(Logsub3.IndexOf(".") + 1).Trim
                    LogMessage = Logsub2.Substring(Logsub2.IndexOf(" ") + 1).Trim
                Catch ex As Exception
                    LogMessage = Log
                End Try

        End Select

    End Sub
End Class

Public Class DeviceLogEntries
    Inherits List(Of DeviceLogEntry)

    Public Sub AddNew(Log As String, Device As UnifiDevice)
        Me.Add(New DeviceLogEntry(Log, Device))
    End Sub
End Class

Public Class UnifiDeviceList
    Inherits List(Of UnifiDevice)
End Class
