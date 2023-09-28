Imports System.Net.NetworkInformation
Imports System.Text
Imports System
Imports System.Net
Imports System.Threading
Imports System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class frmMain
    Public Event PingResult(Ping As PingIP)
    Dim PingList As New Dictionary(Of String, PingIP)
    Private Blocking = New Object
    Private RefreshNow As Boolean ' Refresh the ping list immediately then revert to refreshinterval
    Private RefreshInterval As Integer = 1
    Private WithEvents RefreshWorker As BackgroundWorker
    Private PingStep As Long
    Public UnifiController As New UnifiController
    Private Sub AddGroup(Pingit As PingIP, Item As ListViewItem)
        If Pingit.Group <> "" Then
            Dim thisGroup As ListViewGroup = Nothing
            For Each group In lstIP.Groups
                If group.header = Pingit.Group Then
                    thisGroup = group
                End If
            Next
            If thisGroup Is Nothing Then
                thisGroup = New ListViewGroup(Pingit.Group)
                lstIP.Groups.Add(thisGroup)
            End If
            Item.Group = thisGroup
        End If
    End Sub
    Private Sub UpdateListView(PIngit As PingIP)


        ' Update the Chart if needed
        For Each ip In ChartIPs
            If ip.Equals(PIngit) Then
                For Each series In Chart1.Series
                    If series.Tag.Equals(PIngit) Then
                        If series.Points.Count = 0 Then
                            Dim MyPoint As New DataPoint(PingStep, PIngit.RoundtripTime)
                            MyPoint.Label = PIngit.FriendlyName
                            series.Points.Add(MyPoint)
                        Else
                            series.Points.AddXY(PingStep, PIngit.RoundtripTime)
                        End If

                    End If
                Next
            End If
        Next


        Dim MyItem As ListViewItem = Nothing
        For Each item In lstIP.Items
            If item.tag.Equals(PIngit) Then
                MyItem = item
            End If
        Next

        If MyItem Is Nothing Then
            MyItem = New ListViewItem With {
                .Text = PIngit.FriendlyName,
                .Tag = PIngit,
                .UseItemStyleForSubItems = False
            }
            For x As Integer = 1 To 9
                MyItem.SubItems.Add("")
            Next
            AddGroup(PIngit, MyItem)
            lstIP.Items.Add(MyItem)
        End If
        Dim MyItemIndex As Integer = 0
        For Index = 0 To lstIP.Items.Count - 1
            If lstIP.Items(Index).Equals(MyItem) Then
                MyItemIndex = Index
                Exit For
            End If
        Next
        Const SIRequestedAddress = 1
        Const SIIPAddress = 2
        Const SIHostName = 3
        Const SIRoundtripTime = 4
        Const SIAverage = 5
        Const SIBest = 6
        Const SIWorst = 7
        Const SIPingCount = 8
        Const SIFailures = 9

        MyItem.SubItems(SIRequestedAddress).Text = PIngit.RequestedAddress
        MyItem.SubItems(SIIPAddress).Text = PIngit.IPAddress
        MyItem.SubItems(SIHostName).Text = PIngit.HostName
        Dim PCItem = MyItem.SubItems(SIRoundtripTime)
        If PIngit.PingCount > 0 Then
            If PIngit.Success Then
                PCItem.Text = PIngit.RoundtripTime.ToString()

                Select Case PIngit.RoundtripTime
                    Case < 25
                        PCItem.BackColor = Color.Green
                        PCItem.ForeColor = Color.White
                    Case 26 To 100
                        PCItem.BackColor = Color.Yellow
                        PCItem.ForeColor = Color.Black
                    Case Else
                        PCItem.BackColor = Color.Orange
                        PCItem.ForeColor = Color.Black
                End Select
            Else
                PCItem.Text = "No Response"
                PCItem.ForeColor = Color.White
                PCItem.BackColor = Color.Red
            End If

            If PIngit.Average = -1 Then
                MyItem.SubItems(SIAverage).Text = "N/A"
            Else
                MyItem.SubItems(SIAverage).Text = PIngit.Average.ToString()
            End If
            If PIngit.Best = -1 Then
                MyItem.SubItems(SIBest).Text = "N/A"
            Else
                MyItem.SubItems(SIBest).Text = PIngit.Best.ToString()
            End If
            If PIngit.Worst = -1 Then
                MyItem.SubItems(SIWorst).Text = "N/A"
            Else
                MyItem.SubItems(SIWorst).Text = PIngit.Worst.ToString()
            End If
            MyItem.SubItems(SIPingCount).Text = PIngit.PingCount.ToString()

            Dim Failitem = MyItem.SubItems(SIFailures)
            Failitem.Text = PIngit.Failures.ToString()
            If PIngit.Failures > 0 Then
                Failitem.BackColor = Color.Red
                Failitem.ForeColor = Color.White
            End If
            AddGroup(PIngit, MyItem)
        End If
        lstIP.UpdateItem(MyItemIndex)
        'lstIP.EndUpdate()

        If chkAutosave.Checked Then
            SaveIPList(Me.txtFile.Text)
        End If
        UpdateStatus()

    End Sub
    Private Sub RefreshWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles RefreshWorker.ProgressChanged
        Dim PIngit As PingIP = e.UserState
        UpdateListView(PIngit)
        RaiseEvent PingResult(PIngit)
    End Sub
    Private Function CreatePing(IPAddress As String, FriendlyName As String, Group As String) As PingIP
        Dim NewPing = Nothing
        SyncLock (Blocking)
            If Not PingList.ContainsKey(IPAddress) Then
                NewPing = New PingIP(IPAddress, FriendlyName)
                NewPing.group = Group
                PingList.Add(IPAddress, NewPing)
                UpdateListView(NewPing)
            Else
                NewPing = PingList.Item(IPAddress)
            End If

        End SyncLock
        Return NewPing

    End Function
    Private Sub btnAddIP_Click(sender As Object, e As EventArgs) Handles btnAddIP.Click
        CreatePing(txtIPAddress.Text.Trim, txtFriendly.Text.Trim, "")
        StartWorker()
        Me.lstIP.Refresh()
    End Sub

    Private Sub StartWorker()
        If RefreshWorker Is Nothing Then
            RefreshWorker = New BackgroundWorker
            RefreshWorker.WorkerReportsProgress = True
            RefreshWorker.RunWorkerAsync()
        Else
            RefreshNow = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click, RemoveToolStripMenuItem.Click
        If lstIP.SelectedItems.Count > 0 Then

            SyncLock (Blocking)
                For x As Integer = lstIP.SelectedItems.Count - 1 To 0 Step -1
                    Dim item = lstIP.SelectedItems(x)
                    Dim Key As PingIP = item.Tag
                    PingList.Remove(Key.RequestedAddress)
                    lstIP.Items.Remove(item)
                Next
                StartWorker()
            End SyncLock


        End If
    End Sub

    Private Sub RefreshWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles RefreshWorker.DoWork
        Do
            SyncLock (Blocking)
                Dim x As Integer = 0
                PingStep += 1
                For Each pingit In PingList
                    x += 1
                    UpdateStatus("Pinging " & pingit.Value.FriendlyName & " (" & pingit.Value.RequestedAddress & ")")
                    pingit.Value.ExecutePing()
                    UpdateStatus()
                    RefreshWorker.ReportProgress(x, pingit.Value)
                Next

            End SyncLock
            For x As Integer = 1 To (RefreshInterval * 4)
                If RefreshNow Then
                    RefreshNow = False
                    Exit For
                End If
                Thread.Sleep(250)
            Next
        Loop

    End Sub


    Private Sub UpdateRefreshInterval()
        RefreshInterval = NumInterval.Value
        StartWorker()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles SaveIPListToolStripMenuItem.Click
        Dim MySave As New SaveFileDialog
        MySave.Title = "Save IP List"
        MySave.FileName = "PingTest.csv"
        MySave.AddExtension = True
        MySave.Filter = "*.csv|csv"
        Dim Result = MySave.ShowDialog
        If Result = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            SaveIPList(MySave.FileName)
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub SaveIPList(Filename As String)
        UpdateStatus("Writing IP List and Statistics")
        Using Writer = New System.IO.StreamWriter(Filename)

            Writer.WriteLine(Chr(34) & "Friendlyname" & Chr(34) &
                    "," & Chr(34) & "Requested Address" & Chr(34) &
                    "," & Chr(34) & "Group" & Chr(34) &
                    "," & Chr(34) & "HostName" & Chr(34) &
                    "," & Chr(34) & "RoundtripTime" & Chr(34) &
                    "," & Chr(34) & "Best" & Chr(34) &
                    "," & Chr(34) & "Worst" & Chr(34) &
                    "," & Chr(34) & "Average" & Chr(34) &
                    "," & Chr(34) & "PingCount" & Chr(34) &
                    "," & Chr(34) & "Failures" & Chr(34)
                    )

            For Each item In PingList
                Writer.WriteLine(Chr(34) & item.Value.FriendlyName & Chr(34) & "," & Chr(34) & item.Value.RequestedAddress & Chr(34) &
                                "," & Chr(34) & item.Value.Group & Chr(34) &
                                "," & Chr(34) & item.Value.HostName & Chr(34) &
                                "," & item.Value.RoundtripTime &
                                "," & item.Value.Best &
                                "," & item.Value.Worst &
                                "," & item.Value.Average &
                                "," & item.Value.PingCount &
                                "," & item.Value.Failures)
            Next

        End Using
        Me.txtFile.Text = Filename
        chkAutosave.Enabled = True
        UpdateStatus()
    End Sub

    Private Sub ReadSavedList(Filename As String)
        Using MyReader As New FileIO.TextFieldParser(Filename)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            currentRow = MyReader.ReadFields() ' Read Headers
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    If currentRow.Count > 1 Then
                        Dim NewIP = CreatePing(currentRow(1), currentRow(0), currentRow(2))
                    End If

                Catch ex As FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles OpenIPListToolStripMenuItem.Click
        Dim MySave As New OpenFileDialog
        MySave.Title = "Open IP List"
        MySave.FileName = "PingTest.csv"
        MySave.AddExtension = True
        MySave.Filter = "*.csv|csv"
        Dim Result = MySave.ShowDialog
        If Result = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            SyncLock (Blocking)
                UpdateStatus("Reading IP List")
                PingList.Clear()
                lstIP.Items.Clear()
                ReadSavedList(MySave.FileName)
                StartWorker()
                chkAutosave.Enabled = True
                Me.txtFile.Text = MySave.FileName
                UpdateStatus()
            End SyncLock
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumInterval.ValueChanged
        UpdateRefreshInterval()
    End Sub
    Private Sub UpdateStatus()
        UpdateStatus("Ready")
    End Sub
    Private Sub UpdateStatus(Status As String)
        Me.lblStatus.Text = Status
        Me.StatusStrip1.Refresh()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Control.CheckForIllegalCrossThreadCalls = False
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        lstIP.Columns(0).Width = 122
        lstIP.Columns(1).Width = 138
        lstIP.Columns(2).Width = 81
        lstIP.Columns(3).Width = 161
        lstIP.Columns(4).Width = 77
        lstIP.Columns(5).Width = 77
        lstIP.Columns(6).Width = 77
        lstIP.Columns(7).Width = 77
        lstIP.Columns(8).Width = 77
        lstIP.Columns(9).Width = 77
        LoadUnifi()
    End Sub
    Private Sub LoadUnifi()
        Me.lstClient.Items.Clear()
        Me.lstUnifiDevices.Items.Clear()
        Me.lblDevicedetail.Text = ""
        Me.lblFullDetails.Text = ""

        If UnifiController.LoadDefaults() Then
            UpdateStatus("UNIFI Details Loaded")
            If UnifiController.Login() Then
                UpdateStatus("UNIFI Login Successful")
                If UnifiController.GetDeviceList() Then
                    UpdateStatus("UNIFI Devices Retrieved")
                    If UnifiController.GetClientList() Then
                        UpdateStatus("UNIFI Clients Retrieved")
                    End If
                End If
            End If
        End If
        For Each device In UnifiController.DeviceList
            Dim MyItem As New ListViewItem
            MyItem.Text = device.Name
            MyItem.SubItems.Add(device.DeviceType)
            MyItem.SubItems.Add(device.Model)
            Dim Model = UnifiController.DeviceTypes(device.Model)
            If Model IsNot Nothing Then
                MyItem.SubItems.Add(Model.Name)
            Else
                MyItem.SubItems.Add("")
            End If
            MyItem.SubItems.Add(device.IP)
            MyItem.SubItems.Add(device.FixedIP.ToString)
            MyItem.SubItems.Add(device.IPType)
            MyItem.SubItems.Add(device.MacAddress)
            MyItem.SubItems.Add(device.Version)
            Me.lstUnifiDevices.Items.Add(MyItem)
            MyItem.Tag = device
        Next
        For Each client In UnifiController.ClientList
            Dim MyItem As New ListViewItem
            MyItem.Text = client.Name
            If client.HostName IsNot Nothing Then MyItem.Text &= "(" & client.HostName & ")"
            MyItem.SubItems.Add(client.Organisation)
            MyItem.SubItems.Add(client.IP)
            MyItem.SubItems.Add(client.FixedIP.ToString)
            MyItem.SubItems.Add(client.MacAddress)
            MyItem.SubItems.Add(client.Wifi.ToString)
            MyItem.SubItems.Add(client.FirstSeen.ToString)
            MyItem.SubItems.Add(client.LastSeen.ToString)

            MyItem.Tag = client
            Me.lstClient.Items.Add(MyItem)
        Next
    End Sub
    Private Sub lstContextMenu_Opening(sender As Object, e As CancelEventArgs) Handles lstContextMenu.Opening
        mnuGroups.DropDownItems.Clear()
        If lstIP.SelectedItems.Count > 0 Then
            For Each group As ListViewGroup In lstIP.Groups
                Dim newmnu = New ToolStripMenuItem(group.Header)
                newmnu.Tag = group
                mnuGroups.DropDownItems.Add(newmnu)
                AddHandler newmnu.Click, AddressOf mnuGroups_Click
            Next
            Dim mnuSep = New ToolStripSeparator
            mnuGroups.DropDownItems.Add(mnuSep)
            Dim mnuAddNew = New ToolStripMenuItem("Add New...")
            mnuGroups.DropDownItems.Add(mnuAddNew)

            AddHandler mnuAddNew.Click, AddressOf mnuAddnew_click
        End If

    End Sub
    Private Sub SetSelectedItemGroup(Group As ListViewGroup)
        If lstIP.SelectedItems.Count > 0 Then
            For Each item In lstIP.SelectedItems
                item.Group = Group
                CType(item.tag, PingIP).Group = CType(item.group, ListViewGroup).Header
            Next
        End If
    End Sub
    Private Sub mnuGroups_Click(sender As Object, e As EventArgs)
        SetSelectedItemGroup(sender.tag)
    End Sub
    Private Sub mnuAddnew_click(sender As Object, e As EventArgs)
        Dim NewGroup As String = InputBox("Enter new Group Name", "IP Groups", "")
        If NewGroup IsNot Nothing Then
            Dim group As New ListViewGroup(NewGroup)
            lstIP.Groups.Add(group)
            SetSelectedItemGroup(group)
        End If
    End Sub
    Private Sub ShowChart()
        ShowChartToolStripMenuItem.Text = "Hide Chart"
        pnlChart.Visible = True

        'For Each col In lstIP.Columns
        ' Debug.Print(col.text & " " & col.width)
        ' Next
    End Sub
    Private Sub HideChart()
        ShowChartToolStripMenuItem.Text = "Show Chart"
        pnlChart.Visible = False
    End Sub
    Private Function isChartVisible() As Boolean
        If ShowChartToolStripMenuItem.Text = "Show Chart" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub ShowChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowChartToolStripMenuItem.Click
        If isChartVisible() Then
            HideChart()
        Else
            ShowChart()
        End If
    End Sub

    Private Sub btnResetGraph_Click(sender As Object, e As EventArgs) Handles btnResetGraph.Click
        Me.Chart1.Series.Clear()
        Me.ChartIPs.Clear()
    End Sub
    Private ChartIPs As New List(Of PingIP)

    Private Sub AddToChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToChartToolStripMenuItem.Click
        ' Add this one to the chart as a new series
        If lstIP.SelectedItems.Count > 0 Then
            For Each item In lstIP.SelectedItems
                Dim MyIP As PingIP = item.tag
                Dim Foundit As Boolean = False
                For Each ChartPing In ChartIPs
                    If ChartPing.Equals(MyIP) Then
                        Foundit = True
                        Exit For
                    End If
                Next
                If Not Foundit Then
                    ChartIPs.Add(MyIP)
                    Dim MySeries As New Series(MyIP.FriendlyName)
                    MySeries.Tag = MyIP
                    MySeries.BorderWidth = 5
                    MySeries.IsValueShownAsLabel = True
                    MySeries.ChartType = SeriesChartType.Spline

                    Me.Chart1.Series.Add(MySeries)
                    If Not isChartVisible() Then
                        ShowChart()
                    End If
                Else
                    ChartIPs.Remove(MyIP)
                    For Each series In Chart1.Series
                        If series.Tag.Equals(MyIP) Then
                            Chart1.Series.Remove(series)
                            Exit For
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub mnuUnifi_Click(sender As Object, e As EventArgs) Handles mnuUnifi.Click
        Dim MyForm As New frmUnifi
        MyForm.Controller = Me.UnifiController

        If MyForm.ShowDialog() = DialogResult.OK Then
            ' Try to load the controller
            Me.Cursor = Cursors.WaitCursor
            LoadUnifi()
            Me.Cursor = Cursors.Default
        End If

    End Sub


    Private Sub lstClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClient.SelectedIndexChanged
        If lstClient.SelectedItems.Count = 1 Then
            Dim Client As UNIFIClient = lstClient.SelectedItems(0).Tag
            Try
                Dim jsonFormatted = JValue.Parse(Client.FullDetails).ToString(Formatting.Indented)
                Me.lblFullDetails.Text = jsonFormatted
            Catch ex As Exception
                Me.lblFullDetails.Text = Client.FullDetails
            End Try
        End If
    End Sub

    Private Sub lstUnifiDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUnifiDevices.SelectedIndexChanged
        If lstUnifiDevices.SelectedItems.Count = 1 Then
            Dim thisDevice As UnifiDevice = lstUnifiDevices.SelectedItems(0).Tag
            Try
                Dim jsonFormatted = JValue.Parse(thisDevice.FullDetails).ToString(Formatting.Indented)
                Me.lblDeviceDetail.Text = jsonFormatted
            Catch ex As Exception
                Me.lblDeviceDetail.Text = thisDevice.FullDetails
            End Try
        End If
    End Sub
End Class
