Imports System.ComponentModel
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets

Public Class NetworkDiscovery
    Public Property GatewayAddress As String
    Public Property Clients As New Dictionary(Of String, String)
    Private ReadOnly Blocking As New Object
    Public Property TargetList As ListView
    Public Property PingsLeft As Integer
    Public Event Pingscomplete()
    Public Sub getNetworkGateway()

        For Each f As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()

            If f.OperationalStatus = OperationalStatus.Up Then

                For Each d As GatewayIPAddressInformation In f.GetIPProperties().GatewayAddresses
                    GatewayAddress = d.Address.ToString()
                Next
            End If
        Next

    End Sub

    Public Sub Ping_all()
        getNetworkGateway()
        PingsLeft = 254
        Dim array As String() = GatewayAddress.Split("."c)
        For i As Integer = 2 To 255
            Ping(array(0) & "." & array(1) & "." & array(2) & "." & i)
        Next
    End Sub
    Private Sub StartPing(sender As Object, e As DoWorkEventArgs)

        Dim ping = New System.Net.NetworkInformation.Ping()
        AddHandler ping.PingCompleted, AddressOf PingCompleted
        ping.SendAsync(e.Argument, 120, e.Argument)
    End Sub
    Public Sub Ping(ByVal host As String)

        Dim Worker = New BackgroundWorker
        AddHandler Worker.DoWork, AddressOf StartPing
        Worker.RunWorkerAsync(argument:=host)

    End Sub
    Private Sub PingCompleted(ByVal sender As Object, ByVal e As PingCompletedEventArgs)
        Dim ip As String = CStr(e.UserState)

        If e.Reply IsNot Nothing AndAlso e.Reply.Status = IPStatus.Success Then
            'Dim hostname As String = GetHostName(ip)
            Dim macaddres As String = GetMacAddress(ip)
            SyncLock Blocking
                Dim MyItem As New ListViewItem With {.Text = ip}
                MyItem.SubItems.Add(macaddres)
                TargetList.Items.Add(MyItem)
            End SyncLock
            If Not Clients.ContainsKey(ip) Then
                Clients.Add(ip, macaddres)
            End If
        End If
        PingsLeft -= 1
        If PingsLeft = 0 Then
            RaiseEvent Pingscomplete()
        End If
    End Sub

    Public Function GetHostName(ByVal ipAddress As String) As String
            Try
                Dim entry As IPHostEntry = Dns.GetHostEntry(ipAddress)

                If entry IsNot Nothing Then
                    Return entry.HostName
                End If

            Catch __unusedSocketException1__ As SocketException
            End Try

            Return Nothing
        End Function

        Public Function GetMacAddress(ByVal ipAddress As String) As String
        Dim macAddress As String
        Dim Process As New System.Diagnostics.Process()
        Process.StartInfo.FileName = "arp"
            Process.StartInfo.Arguments = "-a " & ipAddress
            Process.StartInfo.UseShellExecute = False
            Process.StartInfo.RedirectStandardOutput = True
            Process.StartInfo.CreateNoWindow = True
            Process.Start()
            Dim strOutput As String = Process.StandardOutput.ReadToEnd()
            Dim substrings As String() = strOutput.Split("-"c)

            If substrings.Length >= 8 Then
                macAddress = substrings(3).Substring(Math.Max(0, substrings(3).Length - 2)) & "-" & substrings(4) & "-" & substrings(5) & "-" & substrings(6) & "-" & substrings(7) & "-" & substrings(8).Substring(0, 2)
                Return macAddress
            Else
                Return "OWN Machine"
            End If
        End Function

End Class
