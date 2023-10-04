﻿Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Net
Imports System.Net.Sockets

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
    Public Sub ExecutePing()
        PingCount += 1
        Dim pingSender As New NetworkInformation.Ping()
        Dim options As New PingOptions With {
            .DontFragment = True
        }
        Dim data As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Dim buffer As Byte() = Encoding.ASCII.GetBytes(data)
        Dim timeout As Integer = 120
        Dim reply As PingReply = pingSender.Send(IPAddress, timeout, buffer, options)

        If reply.Status = IPStatus.Success Then
            Me.Success = True
            Me.IPAddress = reply.Address.ToString()
            Me.RoundtripTime = reply.RoundtripTime
            Me.ttl = reply.Options.Ttl
            If Me.HostName Is Nothing Then Me.HostName = GetHostName(IPAddress)
            If RoundtripTime > Worst Then Worst = RoundtripTime
            If Best = -1 Then
                Best = RoundtripTime
            Else
                If RoundtripTime < Best Then Best = RoundtripTime
            End If
            If Average = -1 Then
                Average = RoundtripTime
            Else
                Average = (((PingCount - 1) * Average) + RoundtripTime) / (PingCount)
            End If
        Else
            Me.Success = False
            Failures += 1
        End If
    End Sub
    Private Function GetHostName(ByVal ipAddress As String) As String
        Dim ReturnValue As String = ""
        Try
            Dim entry As IPHostEntry = Dns.GetHostEntry(ipAddress)
            If entry IsNot Nothing Then ReturnValue = entry.HostName
        Catch ex As SocketException
            ReturnValue = ipAddress
        End Try
        Return ReturnValue
    End Function
End Class
