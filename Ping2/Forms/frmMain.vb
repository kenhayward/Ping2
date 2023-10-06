Imports System.Threading
Imports System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class frmMain
#Region "Class Variables"
    Private PingList As New Pinglist ' All the IP Addresses we will ping
    Private Blocking = New Object  ' Used to Synclock the PingList with the background task
    Public UnifiController As New UnifiController ' The Unifi Controller Details
    Private ChartIPs As New List(Of PingIP)  ' The subset of the pinglist that are included in the current chart
    Private RefreshNow As Boolean  ' Refresh the ping list immediately then revert to refreshinterval
    Private RefreshInterval As Integer = 5 ' (Seconds) how long to wait between Ping cycles
    Private WithEvents RefreshWorker As BackgroundWorker ' The Ping Worker
    Private PingStep As Long  ' How many cycles have we run in this session - used for Graph x Axis
    Private Const imgPlay = 0  ' Imagelist entry for play button
    Private Const imgStop = 1  ' Imagelist entry for stop button
    Private IPListFile As String ' The current persisted IP List File
    Private Autosave As Boolean = False ' TRue if the Ping list should be autosaved each cycle, false otherwise


#End Region
#Region "Ping ListView Support Functions"
    Private Function CreateItemForListView(Pingit As PingIP)

        Dim MyItem As ListViewItem = lstIP.GetItemByTag(Pingit)
        If MyItem Is Nothing Then
            MyItem = New ListViewItem With {
                .Text = Pingit.FriendlyName,
                .Tag = Pingit,
                .UseItemStyleForSubItems = False
            }
            For x As Integer = 1 To 9
                MyItem.SubItems.Add("")
            Next
            lstIP.ApplyGroup(Pingit.Group, MyItem)
            lstIP.Items.Add(MyItem)
        End If

        Return MyItem
    End Function
    Private Sub UpdateListView(PIngit As PingIP)
        AddPointToChart(PIngit)
        Dim MyItem = CreateItemForListView(PIngit)

        ' Constants for Subitem Positioning
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
            lstIP.ApplyGroup(PIngit.Group, MyItem)
        End If
        lstIP.UpdateItem(MyItem)
        If Autosave Then SaveIPList(IPListFile)
        UpdateStatus()
    End Sub
#End Region
#Region "Background Ping Worker"
    ''' <summary>
    ''' Start the Background Ping Worker or force it to refresh now if already started
    ''' </summary>
    Private Sub StartWorker()
        If PingList.Count = 0 Then
            SetbtnToPlay()
            Exit Sub
        End If
        If RefreshWorker Is Nothing Then
            RefreshWorker = New BackgroundWorker With {.WorkerReportsProgress = True, .WorkerSupportsCancellation = True}
            RefreshWorker.RunWorkerAsync()
            SetbtnToStop()
        Else
            If isBtnPlay() Then
                RefreshWorker.RunWorkerAsync()
                SetbtnToStop()
            Else
                RefreshNow = True
            End If
        End If
    End Sub
    Private Sub SetbtnToPlay()
        PlayStopbtn.Image = My.Resources.Play
        PlayStopbtn.Text = "Play"
        PlayStopbtn.ToolTipText = "Start a new active ping session"
    End Sub
    Private Sub SetbtnToStop()
        PlayStopbtn.Image = My.Resources._Stop
        PlayStopbtn.Text = "Stop"
        PlayStopbtn.ToolTipText = "Stop the active ping session"
    End Sub
    Private Function isBtnPlay() As Boolean
        If PlayStopbtn.Text = "Play" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub RefreshWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles RefreshWorker.ProgressChanged
        If TypeOf e.UserState Is String Then
            UpdateStatus(e.UserState.ToString)
        Else
            Dim PIngit As PingIP = e.UserState
            UpdateListView(PIngit)
        End If
    End Sub
    Private Sub RefreshWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles RefreshWorker.RunWorkerCompleted
        SetbtnToPlay()
        Me.PlayStopbtn.Enabled = True
    End Sub
    Private Sub RefreshWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles RefreshWorker.DoWork
        Do

            SyncLock (Blocking)
                Dim x As Integer = 0
                If RefreshWorker.CancellationPending Then
                    e.Cancel = True
                    Exit Do
                End If
                PingStep += 1
                For Each pingit In PingList
                    x += 1
                    RefreshWorker.ReportProgress(x, "Pinging " & pingit.Value.FriendlyName & " (" & pingit.Value.RequestedAddress & ")")
                    pingit.Value.ExecutePing(RefreshWorker)
                    RefreshWorker.ReportProgress(x, pingit.Value)
                    If RefreshWorker.CancellationPending Then
                        e.Cancel = True
                        Exit Do
                    End If
                Next
            End SyncLock
            Const PingWait As Integer = 250  ' How long to wait between each check
            Const PingWaitCount As Integer = 4 ' How this converts to segments of a second
            For x As Integer = 1 To (RefreshInterval * PingWaitCount)
                If RefreshNow Then
                    RefreshNow = False
                    Exit For
                End If
                If RefreshWorker.CancellationPending Then
                    e.Cancel = True
                    Exit Do
                End If
                Thread.Sleep(PingWait)
                RefreshWorker.ReportProgress(x, "")
            Next
        Loop
        RefreshWorker.ReportProgress(100, "Active Ping Stopped")

    End Sub
    Private Sub UpdateRefreshInterval()
        RefreshInterval = NumInterval.Value
        If PingList.Count > 0 Then
            StartWorker()
        End If
    End Sub

#End Region
#Region "Ping List Management"
    Private Function CreatePing(IPAddress As String, FriendlyName As String, Group As String) As PingIP
        Dim NewPing = Nothing
        SyncLock (Blocking)
            If Not PingList.ContainsKey(IPAddress) Then
                NewPing = New PingIP(IPAddress, FriendlyName) With {.Group = Group}
                PingList.AddPing(NewPing)
                UpdateListView(NewPing)
            Else
                NewPing = PingList.Item(IPAddress)
            End If

        End SyncLock
        Return NewPing

    End Function
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
        SetIPListFile(Filename)
        UpdateStatus()
    End Sub
    Private Sub SetIPListFile(Filename As String)
        IPListFile = Filename
        Me.LblCurrentFile.Text = "Current IP List: " & IPListFile
        chkAutosave.Enabled = True
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
                        CreatePing(currentRow(1), currentRow(0), currentRow(2))
                    End If
                Catch ex As FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

#End Region
#Region "Form Interactions"


    Private Sub btnRefreshUnifi_Click(sender As Object, e As EventArgs) Handles toolRefreshUNIFI.Click, RefreshUNIFITool.Click
        toolRefreshUNIFI.Enabled = False
        RefreshUNIFITool.Enabled = False
        Cursor = Cursors.WaitCursor
        LoadUNIFI()
        Cursor = Cursors.Default
        RefreshUNIFITool.Enabled = True
        toolRefreshUNIFI.Enabled = True
    End Sub
    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click, RemoveToolStripMenuItem.Click
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles SaveIPListToolStripMenuItem.Click, SaveToolStripButton.ButtonClick
        Dim MySave As New SaveFileDialog With {
            .Title = "Save IP List",
            .FileName = "PingTest.csv",
            .AddExtension = True,
            .Filter = "*.csv|csv"
        }
        Dim Result = MySave.ShowDialog
        If Result = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            SaveIPList(MySave.FileName)
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles OpenIPListToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim MySave As New OpenFileDialog With {
            .Title = "Open IP List",
            .FileName = "PingTest.csv",
            .AddExtension = True,
            .Filter = "*.csv|csv"
        }
        Dim Result = MySave.ShowDialog
        If Result = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            SyncLock (Blocking)
                UpdateStatus("Reading IP List")
                PingList.Clear()
                lstIP.Items.Clear()
                ReadSavedList(MySave.FileName)
                StartWorker()

                SetIPListFile(MySave.FileName)
                UpdateStatus()
            End SyncLock
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        StopPingWorker()
        Me.Close()

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

    Private Sub lstContextMenu_Opening(sender As Object, e As CancelEventArgs) Handles lstContextMenu.Opening
        mnuGroups.DropDownItems.Clear()
        If lstIP.SelectedItems.Count > 0 Then
            For Each group As ListViewGroup In lstIP.Groups
                Dim newmnu = New ToolStripMenuItem(group.Header) With {.Tag = group}
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
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SetbtnToPlay()
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
        LoadUNIFI()
    End Sub

    Private Sub MnuUnifi_Click(sender As Object, e As EventArgs) Handles mnuUnifi.Click
        Dim MyForm As New frmUnifi With {.Controller = Me.UnifiController}
        If MyForm.ShowDialog() = DialogResult.OK Then
            Cursor = Cursors.WaitCursor
            LoadUnifi()
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub ShowChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowChartToolStripMenuItem.Click, btnShowChart.Click
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

    Private Sub AddToChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToChartToolStripMenuItem.Click, mnuAddToChart.Click
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
                    Chart1.Series.Add(New Series(MyIP.FriendlyName) With {
                        .Tag = MyIP,
                        .BorderWidth = 5,
                        .IsValueShownAsLabel = True,
                        .ChartType = SeriesChartType.Spline
                    })
                    If Not isChartVisible() Then ShowChart()
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
                Me.lblDevicedetail.Text = jsonFormatted
            Catch ex As Exception
                Me.lblDevicedetail.Text = thisDevice.FullDetails
            End Try
        End If
    End Sub

    Private Sub mnuAddClientToPingList_Click(sender As Object, e As EventArgs) Handles mnuAddClientToPingList.Click
        If lstClient.SelectedItems.Count > 0 Then
            Dim ClientsToAdd As New Dictionary(Of String, String)
            For Each Myitem In lstClient.SelectedItems
                Dim MyClient As UNIFIClient = Myitem.tag
                If MyClient.Name & MyClient.HostName = "" Then
                    Dim Hostname = InputBox("Host Name:", "Provide a Host Name for " & MyClient.IP, "")
                    If Hostname <> "" Then
                        ClientsToAdd.Add(MyClient.ActualIP, MyClient.Tostring)
                    End If
                Else
                    ClientsToAdd.Add(MyClient.ActualIP, MyClient.Tostring)
                End If
            Next
            SyncLock (Blocking)
                For Each client In ClientsToAdd
                    Dim NewPing = New PingIP(client.Key, client.Value) With {.Group = "Client"}
                    If PingList.AddifNew(NewPing) Then UpdateListView(NewPing)
                Next
                StartWorker()
                lstIP.Refresh()
            End SyncLock
        End If
    End Sub
#End Region
#Region "UNIFI Controller"
    Public Function LoadUNIFI() As Boolean
        Me.lstClient.Items.Clear()
        Me.lstUnifiDevices.Items.Clear()
        Me.lblDevicedetail.Text = ""
        Me.lblFullDetails.Text = ""
        Dim Success As Boolean = False
        If Not UnifiController.LoggedIn Then
            If UnifiController.LoadDefaults() Then
                UpdateStatus("UNIFI Details Loaded")
                If UnifiController.Login() Then
                    UpdateStatus("UNIFI Login Successful")
                End If
            End If
        End If
        If UnifiController.LoggedIn Then
            If UnifiController.GetDeviceList() Then
                UpdateStatus("UNIFI Devices Retrieved")
                If UnifiController.GetClientList() Then
                    UpdateStatus("UNIFI Clients Retrieved")
                    Success = True
                End If
            End If
        End If
        If Success Then
            For Each device In UnifiController.DeviceList
                Dim MyItem As New ListViewItem With {.Text = device.Name}
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
                Dim MyItem As New ListViewItem With {.Text = client.Tostring}
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
        End If
        UpdateStatus()
        Return Success
    End Function

#End Region
#Region "Chart Handling"
    Private Sub ShowChart()
        ShowChartToolStripMenuItem.Text = "Hide Chart"
        pnlChart.Visible = True
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
    Private Sub AddPointToChart(Pingit As PingIP)
        For Each ip In ChartIPs
            If ip.Equals(Pingit) Then
                For Each series In Chart1.Series
                    If series.Tag.Equals(Pingit) Then
                        If series.Points.Count = 0 Then
                            Dim MyPoint As New DataPoint(PingStep, Pingit.RoundtripTime) With {.Label = Pingit.FriendlyName}
                            series.Points.Add(MyPoint)
                        Else
                            series.Points.AddXY(PingStep, Pingit.RoundtripTime)
                        End If

                    End If
                Next
            End If
        Next
    End Sub
    Private Sub StopPingWorker()
        If RefreshWorker IsNot Nothing Then
            Me.RefreshWorker.CancelAsync()
        End If
        PlayStopbtn.Enabled = False
    End Sub
    Private Sub ResetIPListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetIPListToolStripMenuItem.Click, ResetIPListToolStripButton.Click
        ' Clear List, Chart and IP List
        Me.Cursor = Cursors.WaitCursor
        StopPingWorker()
        Thread.Sleep(2000)
        Me.PingList.Clear()
        Me.ChartIPs.Clear()
        Me.Chart1.Series.Clear()
        Me.lstIP.Items.Clear()
        Me.lstIP.Refresh()
        SetAutosaveOff
        chkAutosave.Enabled = False
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnPlayStop_Click(sender As Object, e As EventArgs) Handles btnPlayStop.Click, PlayStopbtn.Click
        If RefreshWorker Is Nothing Then
            SetbtnToPlay()
            Exit Sub
        End If
        If RefreshWorker.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            PlayStopbtn.Enabled = False
            StopPingWorker()
            SetbtnToPlay()
            Me.Cursor = Cursors.Default
        Else
            PlayStopbtn.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            StartWorker()
            SetbtnToStop()
            PlayStopbtn.Enabled = True
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        StopPingWorker()
    End Sub

    Private Sub AddIpMenu_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim MyForm As New frmAddIP
        MyForm.LstIP = lstIP
        If MyForm.ShowDialog = DialogResult.OK Then
            Cursor = Cursors.WaitCursor
            Dim MyPing = CreatePing(MyForm.IPAddress, MyForm.Friendlyname, "")
            MyPing.Group = MyForm.GroupName
            If MyForm.NewGroup Then
                Dim group As New ListViewGroup(MyForm.GroupName)
                lstIP.Groups.Add(group)
            End If
            StartWorker()
            Me.lstIP.Refresh()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SetAutosaveOff()
        Autosave = False

    End Sub
    Private Sub SetAutosaveOn()
        Autosave = True

    End Sub
    Private Sub chkAutosave_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutosave.CheckedChanged
        If chkAutosave.Checked Then
            SetAutosaveOn()
        Else
            SetAutosaveOff()
        End If
    End Sub

    Private Sub lstIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIP.SelectedIndexChanged
        If lstIP.SelectedItems.Count > 0 Then
            mnuAddToChart.Enabled = True
        Else
            mnuAddToChart.Enabled = False
        End If
    End Sub

    Private Sub NetworkDiscoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetworkDiscoveryToolStripMenuItem.Click
        Dim MyForm As New frmNetworkDiscovery
        MyForm.ClienList = UnifiController.ClientList
        MyForm.DeviceList = UnifiController.DeviceList
        MyForm.ShowDialog()

    End Sub



#End Region
End Class
