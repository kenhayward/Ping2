Imports System.Threading

Public Class frmNetworkDiscovery
    Public Property ClienList As UnifiClientList
    Public Property DeviceList As UnifiDeviceList
    Private Sub PingsComplete()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PingsComplete))
        Else
            For Each item In ListViewX1.Items
                Dim IP = item.text
                For Each client In ClienList
                    If client.ActualIP = IP Then
                        item.subitems.add("Client")
                        Exit For
                    End If
                Next
                For Each client In DeviceList
                    If client.IP = IP Then
                        item.subitems.add("Device")
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub frmNetworkDiscovery_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim MyNetwork As New NetworkDiscovery
        AddHandler MyNetwork.Pingscomplete, AddressOf PingsComplete
        MyNetwork.getNetworkGateway()
        MyNetwork.TargetList = ListViewX1
        Debug.Print("Gateway " & MyNetwork.GatewayAddress)
        MyNetwork.Ping_all()

    End Sub
End Class