Imports System.ComponentModel
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Text

Public Class PingIP
    Public Property RequestedAddress As String
    Public Property IPAddress As String
    Public Property Group As String
    Public Property RoundtripTime As Long
    Public Property FriendlyName As String
    Public Property TTL As Integer
    Public Property HostName As String
    Public Property Success As Boolean
    Public Property PingCount As Long
    Public Property Failures As Long
    Public Property Best As Long = -1
    Public Property Worst As Long = -1
    Public Property Average As Long = -1
    Private Worker As BackgroundWorker
    Private _Timeout As Integer = 120
    Public Property Timeout As Integer
        Get
            Return _Timeout
        End Get
        Set(value As Integer)
            _Timeout = value
        End Set
    End Property
    Public Sub New(ByVal IPAddressToPing As String, Friendly As String)
        Me.IPAddress = IPAddressToPing
        Me.RequestedAddress = IPAddressToPing
        Me.FriendlyName = Friendly
    End Sub
    Public Sub ExecutePing(RefreshWorker As BackgroundWorker)
        Me.Worker = RefreshWorker
        PingCount += 1
        Dim pingSender As New NetworkInformation.Ping()
        Dim options As New PingOptions With {
            .DontFragment = True
        }
        Dim data As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Dim buffer As Byte() = Encoding.ASCII.GetBytes(data)
        Dim timeout As Integer = 120
        Dim reply As PingReply = Nothing
        Try
            AddHandler pingSender.PingCompleted, AddressOf PingCompleted
            pingSender.SendAsync(IPAddress, timeout, buffer, options, Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub StartPing(sender As Object, e As DoWorkEventArgs)

        Dim ping = New System.Net.NetworkInformation.Ping()
        AddHandler ping.PingCompleted, AddressOf PingCompleted
        ping.SendAsync(e.Argument, 120, e.Argument)
    End Sub
    Public Sub Ping(ByVal host As String)

        Dim thisWorker = New BackgroundWorker
        AddHandler thisWorker.DoWork, AddressOf StartPing
        thisWorker.RunWorkerAsync(argument:=host)

    End Sub


    Private Sub PingCompleted(ByVal sender As Object, ByVal e As PingCompletedEventArgs)
        Dim PingIp As PingIP = e.UserState
        Dim reply = e.Reply


        If reply IsNot Nothing Then
            If reply.Status = IPStatus.Success Then
                PingIp.Success = True
                PingIp.IPAddress = reply.Address.ToString()
                PingIp.RoundtripTime = reply.RoundtripTime
                PingIp.TTL = reply.Options.Ttl

                If PingIp.RoundtripTime > PingIp.Worst Then PingIp.Worst = PingIp.RoundtripTime
                If PingIp.Best = -1 Then
                    PingIp.Best = PingIp.RoundtripTime
                Else
                    If PingIp.RoundtripTime < PingIp.Best Then PingIp.Best = PingIp.RoundtripTime
                End If
                If PingIp.Average = -1 Then
                    PingIp.Average = PingIp.RoundtripTime
                Else
                    PingIp.Average = (((PingIp.PingCount - 1) * PingIp.Average) + PingIp.RoundtripTime) / (PingCount)
                End If
            Else
                PingIp.Success = False
                PingIp.Failures += 1
            End If
        Else
            PingIp.Success = False
            PingIp.Failures += 1
        End If
        If Not Worker.CancellationPending Then
            Worker.ReportProgress(1, PingIp)
        End If
    End Sub


End Class

Public Class Pinglist
    Inherits Dictionary(Of String, PingIP)

    Public Sub AddPing(Ping As PingIP)
        Me.Add(Ping.IPAddress, Ping)
    End Sub

    ''' <summary>
    ''' Adds a new Ping to the list
    ''' </summary>
    ''' <param name="Ping">The Ping to add</param>
    ''' <returns>True if it was added to the list, false if it already existed</returns>
    Public Function AddifNew(Ping As PingIP) As Boolean
        If Not ContainsKey(Ping.IPAddress) Then
            Dim NewPing = New PingIP(Ping.IPAddress, Ping.FriendlyName) With {.Group = "Client"}
            AddPing(NewPing)
            Return True
        Else
            Return False
        End If
    End Function
    Public Function AddifNew(IPAddress As String, FriendlyName As String, Group As String) As Boolean
        Dim NewPing As New PingIP(IPAddress, FriendlyName) With {.Group = Group}
        Return AddifNew(NewPing)
    End Function

End Class
