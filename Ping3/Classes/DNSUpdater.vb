Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets
''' <summary>
''' Retrieve Hostnames for a list of IP Addresses
''' </summary>
Public Class DNSUpdater
    Private DNSWorker As BackgroundWorker
    Public Event HostNameUpdated(Pingip As PingIP)
    Public Event UpdateStatus(Status As String)
    Public Event DNSComplete()
    Private _ActiveWorkers As Dictionary(Of PingIP, BackgroundWorker)

    Private ReadOnly Property ActiveWorkers As Dictionary(Of PingIP, BackgroundWorker)
        Get
            If _ActiveWorkers Is Nothing Then
                _ActiveWorkers = New Dictionary(Of PingIP, BackgroundWorker)
            End If
            Return _ActiveWorkers
        End Get
    End Property
    Public ReadOnly Property ActiveWorkerCount As Integer
        Get
            Return ActiveWorkers.Count
        End Get
    End Property
    Public ReadOnly SyncBlock As New Object

    Public Sub UpdateDNSNames(PingList As Pinglist)
        For Each pingKVP In PingList
            Dim Pingip = pingKVP.Value
            DNSWorker = New BackgroundWorker
            SyncLock (SyncBlock)
                ActiveWorkers.Add(Pingip, DNSWorker)
            End SyncLock

            AddHandler DNSWorker.DoWork, AddressOf GetHostName
        Next
        SyncLock (SyncBlock)
            For Each worker In ActiveWorkers
                worker.Value.RunWorkerAsync(argument:=worker.Key)
            Next
        End SyncLock
    End Sub

    Private Sub GetHostName(sender As Object, e As DoWorkEventArgs)
        Try
            Dim Worker As BackgroundWorker = sender
            Dim PIngip = e.Argument
            RaiseEvent UpdateStatus("Resolving Hostname for " & PIngip.FriendlyName & " (" & PIngip.IPAddress & ")")
            Dim entry As IPHostEntry = Nothing
            Try
                entry = Dns.GetHostEntry(PIngip.IPAddress)
            Catch ex As Exception

            End Try
            If entry IsNot Nothing Then
                PIngip.HostName = entry.HostName
            Else
                PIngip.Hostname = "<Error>"
            End If
            SyncLock (SyncBlock)
                ActiveWorkers.Remove(PIngip)
                If ActiveWorkers.Count = 0 Then
                    RaiseEvent DNSComplete()
                End If
            End SyncLock
            RaiseEvent HostNameUpdated(PIngip)
        Catch ex As SocketException
        End Try
    End Sub

End Class
