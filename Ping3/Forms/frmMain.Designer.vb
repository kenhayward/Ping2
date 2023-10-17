Imports System.Windows.Forms
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmMain))
        Dim ListViewGroup1 As ListViewGroup = New ListViewGroup("Switch", HorizontalAlignment.Left)
        Dim ListViewGroup2 As ListViewGroup = New ListViewGroup("Gateway", HorizontalAlignment.Left)
        Dim ListViewGroup3 As ListViewGroup = New ListViewGroup("Access Point", HorizontalAlignment.Left)
        PrintPreviewDialog1 = New PrintPreviewDialog()
        lstContextMenu = New ContextMenuStrip(components)
        mnuGroups = New ToolStripMenuItem()
        AddToChartToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        RemoveToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        NumInterval = New NumericUpDown()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        OpenIPListToolStripMenuItem = New ToolStripMenuItem()
        SaveIPListToolStripMenuItem = New ToolStripMenuItem()
        ResetIPListToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripSeparator()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        RemoveSelectedToolStripMenuItem = New ToolStripMenuItem()
        mnuUnifi = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        NetworkDiscoveryToolStripMenuItem = New ToolStripMenuItem()
        UpdateHostnamesToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        ShowChartToolStripMenuItem = New ToolStripMenuItem()
        toolRefreshUNIFI = New ToolStripMenuItem()
        btnPlayStop = New Button()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        LblCurrentFile = New ToolStripStatusLabel()
        ProgressLbl = New ToolStripStatusLabel()
        ProgressBar1 = New ToolStripProgressBar()
        btnResetGraph = New Button()
        pnlChart = New Panel()
        GraphControl1 = New Unvell.UIControl.PlainGraph.GraphControl()
        TabMain = New TabControl()
        TabPage1 = New TabPage()
        lstIP = New ListViewX()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        Splitter1 = New Splitter()
        TabUnifiDevices = New TabPage()
        TabDevice = New TabControl()
        TabPage2 = New TabPage()
        lblDevicedetail = New TextBox()
        TabPage3 = New TabPage()
        Splitter3 = New Splitter()
        lstUnifiDevices = New ListView()
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader15 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        ColumnHeader26 = New ColumnHeader()
        ColumnHeader16 = New ColumnHeader()
        ColumnHeader17 = New ColumnHeader()
        ColumnHeader18 = New ColumnHeader()
        DeviceContextStrip = New ContextMenuStrip(components)
        AddRemoveFromPingListToolStripMenuItem = New ToolStripMenuItem()
        mnuGetLogs = New ToolStripMenuItem()
        TabUnifiClients = New TabPage()
        lblFullDetails = New Label()
        Splitter2 = New Splitter()
        lstClient = New ListViewX()
        ColumnHeader19 = New ColumnHeader()
        ColumnHeader20 = New ColumnHeader()
        ColumnHeader21 = New ColumnHeader()
        ColumnHeader27 = New ColumnHeader()
        ColumnHeader22 = New ColumnHeader()
        ColumnHeader23 = New ColumnHeader()
        ColumnHeader24 = New ColumnHeader()
        ColumnHeader25 = New ColumnHeader()
        ClientContextStrip = New ContextMenuStrip(components)
        mnuAddClientToPingList = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        ToolStrip1 = New ToolStrip()
        ResetIPListToolStripButton = New ToolStripButton()
        OpenToolStripButton = New ToolStripButton()
        SaveToolStripButton = New ToolStripSplitButton()
        chkAutosave = New ToolStripMenuItem()
        toolStripSeparator = New ToolStripSeparator()
        ToolStripButton2 = New ToolStripButton()
        PlayStopbtn = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        RefreshUNIFITool = New ToolStripButton()
        ToolStripBtnUpdateHostnames = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        btnShowChart = New ToolStripButton()
        mnuAddToChart = New ToolStripButton()
        imgListPlayStop = New ImageList(components)
        lblMessages = New TextBox()
        lstContextMenu.SuspendLayout()
        CType(NumInterval, ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        pnlChart.SuspendLayout()
        TabMain.SuspendLayout()
        TabPage1.SuspendLayout()
        TabUnifiDevices.SuspendLayout()
        TabDevice.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        DeviceContextStrip.SuspendLayout()
        TabUnifiClients.SuspendLayout()
        ClientContextStrip.SuspendLayout()
        GroupBox1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' lstContextMenu
        ' 
        lstContextMenu.ImageScalingSize = New Size(36, 36)
        lstContextMenu.Items.AddRange(New ToolStripItem() {mnuGroups, AddToChartToolStripMenuItem, ToolStripSeparator1, RemoveToolStripMenuItem})
        lstContextMenu.Name = "ContextMenuStrip1"
        lstContextMenu.Size = New Size(212, 76)
        ' 
        ' mnuGroups
        ' 
        mnuGroups.Name = "mnuGroups"
        mnuGroups.Size = New Size(211, 22)
        mnuGroups.Text = "Group"
        ' 
        ' AddToChartToolStripMenuItem
        ' 
        AddToChartToolStripMenuItem.Name = "AddToChartToolStripMenuItem"
        AddToChartToolStripMenuItem.Size = New Size(211, 22)
        AddToChartToolStripMenuItem.Text = "Add / Remove from Chart"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(208, 6)
        ' 
        ' RemoveToolStripMenuItem
        ' 
        RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        RemoveToolStripMenuItem.Size = New Size(211, 22)
        RemoveToolStripMenuItem.Text = "Remove"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 22)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 15)
        Label2.TabIndex = 8
        Label2.Text = "Refresh (Seconds)"
        ' 
        ' NumInterval
        ' 
        NumInterval.Location = New Point(5, 42)
        NumInterval.Margin = New Padding(1)
        NumInterval.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        NumInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumInterval.Name = "NumInterval"
        NumInterval.Size = New Size(112, 23)
        NumInterval.TabIndex = 9
        NumInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(36, 36)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1307, 24)
        MenuStrip1.TabIndex = 14
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenIPListToolStripMenuItem, SaveIPListToolStripMenuItem, ResetIPListToolStripMenuItem, ExitToolStripMenuItem, ExitToolStripMenuItem1})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' OpenIPListToolStripMenuItem
        ' 
        OpenIPListToolStripMenuItem.Name = "OpenIPListToolStripMenuItem"
        OpenIPListToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenIPListToolStripMenuItem.Size = New Size(180, 22)
        OpenIPListToolStripMenuItem.Text = "&Open IP List"
        ' 
        ' SaveIPListToolStripMenuItem
        ' 
        SaveIPListToolStripMenuItem.Name = "SaveIPListToolStripMenuItem"
        SaveIPListToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveIPListToolStripMenuItem.Size = New Size(180, 22)
        SaveIPListToolStripMenuItem.Text = "&Save IP List"
        ' 
        ' ResetIPListToolStripMenuItem
        ' 
        ResetIPListToolStripMenuItem.Name = "ResetIPListToolStripMenuItem"
        ResetIPListToolStripMenuItem.Size = New Size(180, 22)
        ResetIPListToolStripMenuItem.Text = "&Reset IP List"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(177, 6)
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(180, 22)
        ExitToolStripMenuItem1.Text = "E&xit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RemoveSelectedToolStripMenuItem, mnuUnifi, ToolStripSeparator5, NetworkDiscoveryToolStripMenuItem, UpdateHostnamesToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' RemoveSelectedToolStripMenuItem
        ' 
        RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        RemoveSelectedToolStripMenuItem.ShortcutKeys = Keys.Delete
        RemoveSelectedToolStripMenuItem.Size = New Size(200, 22)
        RemoveSelectedToolStripMenuItem.Text = "&Remove Selected"
        ' 
        ' mnuUnifi
        ' 
        mnuUnifi.Name = "mnuUnifi"
        mnuUnifi.Size = New Size(200, 22)
        mnuUnifi.Text = "Unifi Controller Settings"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(197, 6)
        ' 
        ' NetworkDiscoveryToolStripMenuItem
        ' 
        NetworkDiscoveryToolStripMenuItem.Name = "NetworkDiscoveryToolStripMenuItem"
        NetworkDiscoveryToolStripMenuItem.Size = New Size(200, 22)
        NetworkDiscoveryToolStripMenuItem.Text = "Network Discovery"
        ' 
        ' UpdateHostnamesToolStripMenuItem
        ' 
        UpdateHostnamesToolStripMenuItem.Name = "UpdateHostnamesToolStripMenuItem"
        UpdateHostnamesToolStripMenuItem.Size = New Size(200, 22)
        UpdateHostnamesToolStripMenuItem.Text = "Update Hostnames"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ShowChartToolStripMenuItem, toolRefreshUNIFI})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(44, 20)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' ShowChartToolStripMenuItem
        ' 
        ShowChartToolStripMenuItem.Name = "ShowChartToolStripMenuItem"
        ShowChartToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.T
        ShowChartToolStripMenuItem.Size = New Size(175, 22)
        ShowChartToolStripMenuItem.Text = "Show Chart"
        ' 
        ' toolRefreshUNIFI
        ' 
        toolRefreshUNIFI.Name = "toolRefreshUNIFI"
        toolRefreshUNIFI.Size = New Size(175, 22)
        toolRefreshUNIFI.Text = "Refresh UNIFI Lists"
        ' 
        ' btnPlayStop
        ' 
        btnPlayStop.Location = New Point(121, 38)
        btnPlayStop.Margin = New Padding(4, 3, 4, 3)
        btnPlayStop.Name = "btnPlayStop"
        btnPlayStop.Size = New Size(88, 27)
        btnPlayStop.TabIndex = 16
        btnPlayStop.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(36, 36)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus, LblCurrentFile, ProgressLbl, ProgressBar1})
        StatusStrip1.Location = New Point(0, 516)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1307, 24)
        StatusStrip1.SizingGrip = False
        StatusStrip1.TabIndex = 16
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 19)
        lblStatus.Text = "Ready"
        ' 
        ' LblCurrentFile
        ' 
        LblCurrentFile.Name = "LblCurrentFile"
        LblCurrentFile.Size = New Size(1134, 19)
        LblCurrentFile.Spring = True
        LblCurrentFile.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ProgressLbl
        ' 
        ProgressLbl.Name = "ProgressLbl"
        ProgressLbl.Size = New Size(0, 19)
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(117, 18)
        ProgressBar1.Step = 1
        ' 
        ' btnResetGraph
        ' 
        btnResetGraph.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnResetGraph.Location = New Point(386, 404)
        btnResetGraph.Margin = New Padding(1)
        btnResetGraph.Name = "btnResetGraph"
        btnResetGraph.Size = New Size(61, 28)
        btnResetGraph.TabIndex = 19
        btnResetGraph.Text = "Reset"
        btnResetGraph.UseVisualStyleBackColor = True
        ' 
        ' pnlChart
        ' 
        pnlChart.Controls.Add(GraphControl1)
        pnlChart.Controls.Add(btnResetGraph)
        pnlChart.Dock = DockStyle.Right
        pnlChart.Location = New Point(847, 3)
        pnlChart.Margin = New Padding(1)
        pnlChart.Name = "pnlChart"
        pnlChart.Size = New Size(448, 433)
        pnlChart.TabIndex = 20
        pnlChart.Visible = False
        ' 
        ' GraphControl1
        ' 
        GraphControl1.BackColor = Color.White
        GraphControl1.DataSource = Nothing
        GraphControl1.Dock = DockStyle.Fill
        GraphControl1.GraphMargin = New Padding(0)
        GraphControl1.GraphType = Unvell.UIControl.PlainGraph.PlainGraphType.Line
        GraphControl1.LegendFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        GraphControl1.Location = New Point(0, 0)
        GraphControl1.Name = "GraphControl1"
        GraphControl1.Size = New Size(448, 433)
        GraphControl1.TabIndex = 20
        GraphControl1.Text = "GraphControl1"
        GraphControl1.XRulerFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        GraphControl1.YRulerFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' TabMain
        ' 
        TabMain.Controls.Add(TabPage1)
        TabMain.Controls.Add(TabUnifiDevices)
        TabMain.Controls.Add(TabUnifiClients)
        TabMain.Dock = DockStyle.Fill
        TabMain.Location = New Point(0, 49)
        TabMain.Margin = New Padding(4, 3, 4, 3)
        TabMain.Name = "TabMain"
        TabMain.SelectedIndex = 0
        TabMain.Size = New Size(1307, 467)
        TabMain.TabIndex = 21
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lstIP)
        TabPage1.Controls.Add(Splitter1)
        TabPage1.Controls.Add(pnlChart)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Margin = New Padding(4, 3, 4, 3)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4, 3, 4, 3)
        TabPage1.Size = New Size(1299, 439)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Ping"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lstIP
        ' 
        lstIP.Columns.AddRange(New ColumnHeader() {ColumnHeader7, ColumnHeader10, ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader8, ColumnHeader9})
        lstIP.ContextMenuStrip = lstContextMenu
        lstIP.Dock = DockStyle.Fill
        lstIP.FullRowSelect = True
        lstIP.GridLines = True
        ListViewGroup1.Header = "Switch"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Gateway"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "Access Point"
        ListViewGroup3.Name = "ListViewGroup3"
        lstIP.Groups.AddRange(New ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        lstIP.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lstIP.Location = New Point(4, 3)
        lstIP.Margin = New Padding(1)
        lstIP.Name = "lstIP"
        lstIP.Size = New Size(831, 433)
        lstIP.TabIndex = 4
        lstIP.UseCompatibleStateImageBehavior = False
        lstIP.View = View.Details
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Name"
        ColumnHeader7.Width = 200
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Requested"
        ColumnHeader10.Width = 200
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "IP Address"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "DNS Name"
        ColumnHeader2.Width = 200
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Recent"
        ColumnHeader3.TextAlign = HorizontalAlignment.Right
        ColumnHeader3.Width = 150
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Average"
        ColumnHeader4.TextAlign = HorizontalAlignment.Right
        ColumnHeader4.Width = 150
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Best"
        ColumnHeader5.TextAlign = HorizontalAlignment.Right
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Worst"
        ColumnHeader6.TextAlign = HorizontalAlignment.Right
        ColumnHeader6.Width = 150
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Count"
        ColumnHeader8.TextAlign = HorizontalAlignment.Right
        ColumnHeader8.Width = 150
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Failures"
        ColumnHeader9.TextAlign = HorizontalAlignment.Right
        ColumnHeader9.Width = 150
        ' 
        ' Splitter1
        ' 
        Splitter1.BackColor = SystemColors.Highlight
        Splitter1.Dock = DockStyle.Right
        Splitter1.Location = New Point(835, 3)
        Splitter1.Margin = New Padding(1)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(12, 433)
        Splitter1.TabIndex = 21
        Splitter1.TabStop = False
        ' 
        ' TabUnifiDevices
        ' 
        TabUnifiDevices.Controls.Add(TabDevice)
        TabUnifiDevices.Controls.Add(Splitter3)
        TabUnifiDevices.Controls.Add(lstUnifiDevices)
        TabUnifiDevices.Location = New Point(4, 24)
        TabUnifiDevices.Margin = New Padding(4, 3, 4, 3)
        TabUnifiDevices.Name = "TabUnifiDevices"
        TabUnifiDevices.Padding = New Padding(4, 3, 4, 3)
        TabUnifiDevices.Size = New Size(1299, 439)
        TabUnifiDevices.TabIndex = 1
        TabUnifiDevices.Text = "Unifi Devices"
        TabUnifiDevices.UseVisualStyleBackColor = True
        ' 
        ' TabDevice
        ' 
        TabDevice.Controls.Add(TabPage2)
        TabDevice.Controls.Add(TabPage3)
        TabDevice.Dock = DockStyle.Fill
        TabDevice.Location = New Point(4, 262)
        TabDevice.Name = "TabDevice"
        TabDevice.SelectedIndex = 0
        TabDevice.Size = New Size(1291, 174)
        TabDevice.TabIndex = 9
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lblDevicedetail)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1283, 146)
        TabPage2.TabIndex = 0
        TabPage2.Text = "Device Detail"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lblDevicedetail
        ' 
        lblDevicedetail.BorderStyle = BorderStyle.None
        lblDevicedetail.Dock = DockStyle.Fill
        lblDevicedetail.Location = New Point(3, 3)
        lblDevicedetail.Margin = New Padding(4, 3, 4, 3)
        lblDevicedetail.Multiline = True
        lblDevicedetail.Name = "lblDevicedetail"
        lblDevicedetail.ReadOnly = True
        lblDevicedetail.ScrollBars = ScrollBars.Both
        lblDevicedetail.Size = New Size(1277, 140)
        lblDevicedetail.TabIndex = 8
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(lblMessages)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1283, 146)
        TabPage3.TabIndex = 1
        TabPage3.Text = "Message Logs"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Splitter3
        ' 
        Splitter3.Dock = DockStyle.Top
        Splitter3.Location = New Point(4, 250)
        Splitter3.Margin = New Padding(4, 3, 4, 3)
        Splitter3.Name = "Splitter3"
        Splitter3.Size = New Size(1291, 12)
        Splitter3.TabIndex = 7
        Splitter3.TabStop = False
        ' 
        ' lstUnifiDevices
        ' 
        lstUnifiDevices.Columns.AddRange(New ColumnHeader() {ColumnHeader11, ColumnHeader12, ColumnHeader13, ColumnHeader15, ColumnHeader14, ColumnHeader26, ColumnHeader16, ColumnHeader17, ColumnHeader18})
        lstUnifiDevices.ContextMenuStrip = DeviceContextStrip
        lstUnifiDevices.Dock = DockStyle.Top
        lstUnifiDevices.FullRowSelect = True
        lstUnifiDevices.Location = New Point(4, 3)
        lstUnifiDevices.Margin = New Padding(4, 3, 4, 3)
        lstUnifiDevices.Name = "lstUnifiDevices"
        lstUnifiDevices.Size = New Size(1291, 247)
        lstUnifiDevices.TabIndex = 1
        lstUnifiDevices.UseCompatibleStateImageBehavior = False
        lstUnifiDevices.View = View.Details
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "Name"
        ColumnHeader11.Width = 150
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.Text = "Type"
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "Model"
        ColumnHeader13.Width = 100
        ' 
        ' ColumnHeader15
        ' 
        ColumnHeader15.Text = "Model Name"
        ColumnHeader15.Width = 150
        ' 
        ' ColumnHeader14
        ' 
        ColumnHeader14.Text = "IP Address"
        ColumnHeader14.Width = 100
        ' 
        ' ColumnHeader26
        ' 
        ColumnHeader26.Text = "Fixed IP"
        ' 
        ' ColumnHeader16
        ' 
        ColumnHeader16.Text = "IP Type"
        ' 
        ' ColumnHeader17
        ' 
        ColumnHeader17.Text = "MAC"
        ColumnHeader17.Width = 100
        ' 
        ' ColumnHeader18
        ' 
        ColumnHeader18.Text = "Version"
        ColumnHeader18.Width = 100
        ' 
        ' DeviceContextStrip
        ' 
        DeviceContextStrip.Items.AddRange(New ToolStripItem() {AddRemoveFromPingListToolStripMenuItem, mnuGetLogs})
        DeviceContextStrip.Name = "DeviceContextStrip"
        DeviceContextStrip.Size = New Size(208, 48)
        ' 
        ' AddRemoveFromPingListToolStripMenuItem
        ' 
        AddRemoveFromPingListToolStripMenuItem.Name = "AddRemoveFromPingListToolStripMenuItem"
        AddRemoveFromPingListToolStripMenuItem.Size = New Size(207, 22)
        AddRemoveFromPingListToolStripMenuItem.Text = "&Add Device to Ping List"
        ' 
        ' mnuGetLogs
        ' 
        mnuGetLogs.Name = "mnuGetLogs"
        mnuGetLogs.Size = New Size(207, 22)
        mnuGetLogs.Text = "&Get Device Log Messages"
        ' 
        ' TabUnifiClients
        ' 
        TabUnifiClients.Controls.Add(lblFullDetails)
        TabUnifiClients.Controls.Add(Splitter2)
        TabUnifiClients.Controls.Add(lstClient)
        TabUnifiClients.Location = New Point(4, 24)
        TabUnifiClients.Margin = New Padding(4, 3, 4, 3)
        TabUnifiClients.Name = "TabUnifiClients"
        TabUnifiClients.Size = New Size(1299, 439)
        TabUnifiClients.TabIndex = 2
        TabUnifiClients.Text = "Unifi Clients"
        TabUnifiClients.UseVisualStyleBackColor = True
        ' 
        ' lblFullDetails
        ' 
        lblFullDetails.Dock = DockStyle.Fill
        lblFullDetails.Location = New Point(0, 325)
        lblFullDetails.Margin = New Padding(4, 0, 4, 0)
        lblFullDetails.Name = "lblFullDetails"
        lblFullDetails.Size = New Size(1299, 114)
        lblFullDetails.TabIndex = 4
        ' 
        ' Splitter2
        ' 
        Splitter2.Dock = DockStyle.Top
        Splitter2.Location = New Point(0, 313)
        Splitter2.Margin = New Padding(4, 3, 4, 3)
        Splitter2.Name = "Splitter2"
        Splitter2.Size = New Size(1299, 12)
        Splitter2.TabIndex = 5
        Splitter2.TabStop = False
        ' 
        ' lstClient
        ' 
        lstClient.Columns.AddRange(New ColumnHeader() {ColumnHeader19, ColumnHeader20, ColumnHeader21, ColumnHeader27, ColumnHeader22, ColumnHeader23, ColumnHeader24, ColumnHeader25})
        lstClient.ContextMenuStrip = ClientContextStrip
        lstClient.Dock = DockStyle.Top
        lstClient.FullRowSelect = True
        lstClient.Location = New Point(0, 0)
        lstClient.Margin = New Padding(4, 3, 4, 3)
        lstClient.Name = "lstClient"
        lstClient.Size = New Size(1299, 313)
        lstClient.Sorting = SortOrder.Ascending
        lstClient.TabIndex = 2
        lstClient.UseCompatibleStateImageBehavior = False
        lstClient.View = View.Details
        ' 
        ' ColumnHeader19
        ' 
        ColumnHeader19.Text = "Name"
        ColumnHeader19.Width = 150
        ' 
        ' ColumnHeader20
        ' 
        ColumnHeader20.Text = "Organisation"
        ColumnHeader20.Width = 150
        ' 
        ' ColumnHeader21
        ' 
        ColumnHeader21.Text = "IP"
        ColumnHeader21.Width = 100
        ' 
        ' ColumnHeader27
        ' 
        ColumnHeader27.Text = "Fixed IP"
        ' 
        ' ColumnHeader22
        ' 
        ColumnHeader22.Text = "MAC"
        ColumnHeader22.Width = 100
        ' 
        ' ColumnHeader23
        ' 
        ColumnHeader23.Text = "WiFi"
        ' 
        ' ColumnHeader24
        ' 
        ColumnHeader24.Text = "First Seen"
        ColumnHeader24.Width = 120
        ' 
        ' ColumnHeader25
        ' 
        ColumnHeader25.Text = "Last Seen"
        ColumnHeader25.Width = 120
        ' 
        ' ClientContextStrip
        ' 
        ClientContextStrip.Items.AddRange(New ToolStripItem() {mnuAddClientToPingList})
        ClientContextStrip.Name = "ClientContextStrip"
        ClientContextStrip.Size = New Size(193, 26)
        ' 
        ' mnuAddClientToPingList
        ' 
        mnuAddClientToPingList.Name = "mnuAddClientToPingList"
        mnuAddClientToPingList.Size = New Size(192, 22)
        mnuAddClientToPingList.Text = "&Add Client to Ping List"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnPlayStop)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(NumInterval)
        GroupBox1.Location = New Point(342, 28)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(233, 68)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Active Ping"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ResetIPListToolStripButton, OpenToolStripButton, SaveToolStripButton, toolStripSeparator, ToolStripButton2, PlayStopbtn, ToolStripSeparator2, RefreshUNIFITool, ToolStripBtnUpdateHostnames, ToolStripSeparator3, btnShowChart, mnuAddToChart})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1307, 25)
        ToolStrip1.TabIndex = 22
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ResetIPListToolStripButton
        ' 
        ResetIPListToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ResetIPListToolStripButton.Image = CType(resources.GetObject("ResetIPListToolStripButton.Image"), Image)
        ResetIPListToolStripButton.ImageTransparentColor = Color.Magenta
        ResetIPListToolStripButton.Name = "ResetIPListToolStripButton"
        ResetIPListToolStripButton.Size = New Size(23, 22)
        ResetIPListToolStripButton.Text = "&Reset"
        ResetIPListToolStripButton.ToolTipText = "Reset List"
        ' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), Image)
        OpenToolStripButton.ImageTransparentColor = Color.Magenta
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(23, 22)
        OpenToolStripButton.Text = "&Open"
        ' 
        ' SaveToolStripButton
        ' 
        SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripButton.DropDownItems.AddRange(New ToolStripItem() {chkAutosave})
        SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
        SaveToolStripButton.ImageTransparentColor = Color.Magenta
        SaveToolStripButton.Name = "SaveToolStripButton"
        SaveToolStripButton.Size = New Size(32, 22)
        SaveToolStripButton.Text = "&Save"
        ' 
        ' chkAutosave
        ' 
        chkAutosave.CheckOnClick = True
        chkAutosave.Enabled = False
        chkAutosave.Name = "chkAutosave"
        chkAutosave.Size = New Size(123, 22)
        chkAutosave.Text = "Autosave"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 25)
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 22)
        ToolStripButton2.Text = "Add New IP Adress"
        ' 
        ' PlayStopbtn
        ' 
        PlayStopbtn.DisplayStyle = ToolStripItemDisplayStyle.Image
        PlayStopbtn.Image = CType(resources.GetObject("PlayStopbtn.Image"), Image)
        PlayStopbtn.ImageTransparentColor = Color.Magenta
        PlayStopbtn.Name = "PlayStopbtn"
        PlayStopbtn.Size = New Size(23, 22)
        PlayStopbtn.Text = "Play"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' RefreshUNIFITool
        ' 
        RefreshUNIFITool.DisplayStyle = ToolStripItemDisplayStyle.Image
        RefreshUNIFITool.Image = CType(resources.GetObject("RefreshUNIFITool.Image"), Image)
        RefreshUNIFITool.ImageTransparentColor = Color.Magenta
        RefreshUNIFITool.Name = "RefreshUNIFITool"
        RefreshUNIFITool.Size = New Size(23, 22)
        RefreshUNIFITool.Text = "&Refresh Unifi"
        RefreshUNIFITool.ToolTipText = "Refresh Unifi Clients and Devices"
        ' 
        ' ToolStripBtnUpdateHostnames
        ' 
        ToolStripBtnUpdateHostnames.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripBtnUpdateHostnames.Image = CType(resources.GetObject("ToolStripBtnUpdateHostnames.Image"), Image)
        ToolStripBtnUpdateHostnames.ImageTransparentColor = Color.Magenta
        ToolStripBtnUpdateHostnames.Name = "ToolStripBtnUpdateHostnames"
        ToolStripBtnUpdateHostnames.Size = New Size(23, 22)
        ToolStripBtnUpdateHostnames.Text = "Update Hostnames from DNS"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' btnShowChart
        ' 
        btnShowChart.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnShowChart.Image = CType(resources.GetObject("btnShowChart.Image"), Image)
        btnShowChart.ImageTransparentColor = Color.Magenta
        btnShowChart.Name = "btnShowChart"
        btnShowChart.Size = New Size(23, 22)
        btnShowChart.Text = "Show Chart"
        ' 
        ' mnuAddToChart
        ' 
        mnuAddToChart.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuAddToChart.Enabled = False
        mnuAddToChart.Image = CType(resources.GetObject("mnuAddToChart.Image"), Image)
        mnuAddToChart.ImageTransparentColor = Color.Magenta
        mnuAddToChart.Name = "mnuAddToChart"
        mnuAddToChart.Size = New Size(23, 22)
        mnuAddToChart.Text = "Add to Chart"
        ' 
        ' imgListPlayStop
        ' 
        imgListPlayStop.ColorDepth = ColorDepth.Depth8Bit
        imgListPlayStop.ImageStream = CType(resources.GetObject("imgListPlayStop.ImageStream"), ImageListStreamer)
        imgListPlayStop.TransparentColor = Color.Transparent
        imgListPlayStop.Images.SetKeyName(0, "Play")
        imgListPlayStop.Images.SetKeyName(1, "Stop")
        ' 
        ' lblMessages
        ' 
        lblMessages.BorderStyle = BorderStyle.None
        lblMessages.Dock = DockStyle.Fill
        lblMessages.Location = New Point(3, 3)
        lblMessages.Margin = New Padding(4, 3, 4, 3)
        lblMessages.Multiline = True
        lblMessages.Name = "lblMessages"
        lblMessages.ReadOnly = True
        lblMessages.ScrollBars = ScrollBars.Both
        lblMessages.Size = New Size(1277, 140)
        lblMessages.TabIndex = 9
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1307, 540)
        Controls.Add(TabMain)
        Controls.Add(ToolStrip1)
        Controls.Add(GroupBox1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(1)
        Name = "frmMain"
        Text = "Ping Explorer"
        lstContextMenu.ResumeLayout(False)
        CType(NumInterval, ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        pnlChart.ResumeLayout(False)
        TabMain.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabUnifiDevices.ResumeLayout(False)
        TabDevice.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        DeviceContextStrip.ResumeLayout(False)
        TabUnifiClients.ResumeLayout(False)
        ClientContextStrip.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Public WithEvents lstIP As ListViewX
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents NumInterval As NumericUpDown
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenIPListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveIPListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lstContextMenu As ContextMenuStrip
    Friend WithEvents mnuGroups As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowChartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnResetGraph As Button
    Friend WithEvents AddToChartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents pnlChart As Panel
    Friend WithEvents mnuUnifi As ToolStripMenuItem
    Friend WithEvents TabMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents TabUnifiDevices As TabPage
    Friend WithEvents TabUnifiClients As TabPage
    Friend WithEvents lstUnifiDevices As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents lstClient As ListViewX
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents lblFullDetails As Label
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents Splitter3 As Splitter
    Friend WithEvents lblDevicedetail As TextBox
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents ClientContextStrip As ContextMenuStrip
    Friend WithEvents mnuAddClientToPingList As ToolStripMenuItem
    Friend WithEvents toolRefreshUNIFI As ToolStripMenuItem
    Friend WithEvents DeviceContextStrip As ContextMenuStrip
    Friend WithEvents AddRemoveFromPingListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetIPListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPlayStop As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ResetIPListToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents PlayStopbtn As ToolStripButton
    Friend WithEvents RefreshUNIFITool As ToolStripButton
    Friend WithEvents imgListPlayStop As ImageList
    Friend WithEvents btnShowChart As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents LblCurrentFile As ToolStripStatusLabel
    Friend WithEvents mnuAddToChart As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripSplitButton
    Friend WithEvents chkAutosave As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents NetworkDiscoveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateHostnamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripBtnUpdateHostnames As ToolStripButton
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents ProgressLbl As ToolStripStatusLabel
    Friend WithEvents GraphControl1 As Unvell.UIControl.PlainGraph.GraphControl
    Friend WithEvents mnuGetLogs As ToolStripMenuItem
    Friend WithEvents TabDevice As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblMessages As TextBox
End Class
