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
    Public Property FixedIP As Boolean

    Public Function GetSSHLogs(FromController As UnifiController) As SshCommand

        Dim Result As SshCommand
        Logs = ""
        Using client = New SshClient(Me.IP, FromController.DeviceUser, FromController.DevicePassword)
            AddHandler client.HostKeyReceived, AddressOf ClientAccept
            Try
                client.Connect()
                Result = client.RunCommand("cat /var/log/messages")
                If Result.ExitStatus = 0 Then
                    Logs = Result.Result.Replace(vbLf, vbCrLf)
                End If
                client.Disconnect()
            Catch ex As Exception
                Result = Nothing
            End Try
        End Using
        Return Result
    End Function

    Private Sub ClientAccept(ByVal sender As Object, ByVal e As HostKeyEventArgs)
        e.CanTrust = True
    End Sub
End Class



Public Class UnifiDeviceList
    Inherits List(Of UnifiDevice)
End Class
