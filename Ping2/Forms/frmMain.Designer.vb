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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Switch", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Gateway", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Access Point", System.Windows.Forms.HorizontalAlignment.Left)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lstContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuGroups = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumInterval = New System.Windows.Forms.NumericUpDown()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenIPListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveIPListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetIPListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditGroupingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnifi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolRefreshUNIFI = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPlayStop = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblCurrentFile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnResetGraph = New System.Windows.Forms.Button()
        Me.pnlChart = New System.Windows.Forms.Panel()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstIP = New Ping.ListViewX()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabUnifiDevices = New System.Windows.Forms.TabPage()
        Me.lblDevicedetail = New System.Windows.Forms.TextBox()
        Me.Splitter3 = New System.Windows.Forms.Splitter()
        Me.lstUnifiDevices = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceContextStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddRemoveFromPingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabUnifiClients = New System.Windows.Forms.TabPage()
        Me.lblFullDetails = New System.Windows.Forms.Label()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.lstClient = New Ping.ListViewX()
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClientContextStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAddClientToPingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ResetIPListToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.chkAutosave = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PlayStopbtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshUNIFITool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnShowChart = New System.Windows.Forms.ToolStripButton()
        Me.mnuAddToChart = New System.Windows.Forms.ToolStripButton()
        Me.imgListPlayStop = New System.Windows.Forms.ImageList(Me.components)
        Me.lstContextMenu.SuspendLayout()
        CType(Me.NumInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChart.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabUnifiDevices.SuspendLayout()
        Me.DeviceContextStrip.SuspendLayout()
        Me.TabUnifiClients.SuspendLayout()
        Me.ClientContextStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lstContextMenu
        '
        Me.lstContextMenu.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.lstContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGroups, Me.AddToChartToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveToolStripMenuItem})
        Me.lstContextMenu.Name = "ContextMenuStrip1"
        Me.lstContextMenu.Size = New System.Drawing.Size(212, 76)
        '
        'mnuGroups
        '
        Me.mnuGroups.Name = "mnuGroups"
        Me.mnuGroups.Size = New System.Drawing.Size(211, 22)
        Me.mnuGroups.Text = "Group"
        '
        'AddToChartToolStripMenuItem
        '
        Me.AddToChartToolStripMenuItem.Name = "AddToChartToolStripMenuItem"
        Me.AddToChartToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.AddToChartToolStripMenuItem.Text = "Add / Remove from Chart"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Refresh (Seconds)"
        '
        'NumInterval
        '
        Me.NumInterval.Location = New System.Drawing.Point(4, 36)
        Me.NumInterval.Margin = New System.Windows.Forms.Padding(1)
        Me.NumInterval.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumInterval.Name = "NumInterval"
        Me.NumInterval.Size = New System.Drawing.Size(96, 20)
        Me.NumInterval.TabIndex = 9
        Me.NumInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1120, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenIPListToolStripMenuItem, Me.SaveIPListToolStripMenuItem, Me.ResetIPListToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenIPListToolStripMenuItem
        '
        Me.OpenIPListToolStripMenuItem.Name = "OpenIPListToolStripMenuItem"
        Me.OpenIPListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenIPListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenIPListToolStripMenuItem.Text = "&Open IP List"
        '
        'SaveIPListToolStripMenuItem
        '
        Me.SaveIPListToolStripMenuItem.Name = "SaveIPListToolStripMenuItem"
        Me.SaveIPListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveIPListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveIPListToolStripMenuItem.Text = "&Save IP List"
        '
        'ResetIPListToolStripMenuItem
        '
        Me.ResetIPListToolStripMenuItem.Name = "ResetIPListToolStripMenuItem"
        Me.ResetIPListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetIPListToolStripMenuItem.Text = "&Reset IP List"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedToolStripMenuItem, Me.EditGroupingToolStripMenuItem, Me.mnuUnifi})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "&Remove Selected"
        '
        'EditGroupingToolStripMenuItem
        '
        Me.EditGroupingToolStripMenuItem.Name = "EditGroupingToolStripMenuItem"
        Me.EditGroupingToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.EditGroupingToolStripMenuItem.Text = "Edit Grouping"
        '
        'mnuUnifi
        '
        Me.mnuUnifi.Name = "mnuUnifi"
        Me.mnuUnifi.Size = New System.Drawing.Size(200, 22)
        Me.mnuUnifi.Text = "Unifi Controller Settings"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowChartToolStripMenuItem, Me.toolRefreshUNIFI})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ShowChartToolStripMenuItem
        '
        Me.ShowChartToolStripMenuItem.Name = "ShowChartToolStripMenuItem"
        Me.ShowChartToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ShowChartToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ShowChartToolStripMenuItem.Text = "Show Chart"
        '
        'toolRefreshUNIFI
        '
        Me.toolRefreshUNIFI.Name = "toolRefreshUNIFI"
        Me.toolRefreshUNIFI.Size = New System.Drawing.Size(175, 22)
        Me.toolRefreshUNIFI.Text = "Refresh UNIFI"
        '
        'btnPlayStop
        '
        Me.btnPlayStop.Location = New System.Drawing.Point(104, 33)
        Me.btnPlayStop.Name = "btnPlayStop"
        Me.btnPlayStop.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayStop.TabIndex = 16
        Me.btnPlayStop.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.LblCurrentFile})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 446)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1120, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 17)
        Me.lblStatus.Text = "Ready"
        '
        'LblCurrentFile
        '
        Me.LblCurrentFile.Name = "LblCurrentFile"
        Me.LblCurrentFile.Size = New System.Drawing.Size(1068, 17)
        Me.LblCurrentFile.Spring = True
        Me.LblCurrentFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chart1
        '
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Gray
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Gray
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.AxisY.Title = "Milliseconds"
        ChartArea1.BorderColor = System.Drawing.Color.Silver
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.IsDockedInsideChartArea = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(1)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(384, 365)
        Me.Chart1.TabIndex = 17
        Me.Chart1.Text = "Chart1"
        '
        'btnResetGraph
        '
        Me.btnResetGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetGraph.Location = New System.Drawing.Point(331, 340)
        Me.btnResetGraph.Margin = New System.Windows.Forms.Padding(1)
        Me.btnResetGraph.Name = "btnResetGraph"
        Me.btnResetGraph.Size = New System.Drawing.Size(52, 24)
        Me.btnResetGraph.TabIndex = 19
        Me.btnResetGraph.Text = "Reset"
        Me.btnResetGraph.UseVisualStyleBackColor = True
        '
        'pnlChart
        '
        Me.pnlChart.Controls.Add(Me.btnResetGraph)
        Me.pnlChart.Controls.Add(Me.Chart1)
        Me.pnlChart.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlChart.Location = New System.Drawing.Point(725, 3)
        Me.pnlChart.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(384, 365)
        Me.pnlChart.TabIndex = 20
        Me.pnlChart.Visible = False
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.TabPage1)
        Me.TabMain.Controls.Add(Me.TabUnifiDevices)
        Me.TabMain.Controls.Add(Me.TabUnifiClients)
        Me.TabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMain.Location = New System.Drawing.Point(0, 49)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(1120, 397)
        Me.TabMain.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstIP)
        Me.TabPage1.Controls.Add(Me.Splitter1)
        Me.TabPage1.Controls.Add(Me.pnlChart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1112, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ping"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstIP
        '
        Me.lstIP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lstIP.ContextMenuStrip = Me.lstContextMenu
        Me.lstIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstIP.FullRowSelect = True
        Me.lstIP.GridLines = True
        ListViewGroup1.Header = "Switch"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Gateway"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "Access Point"
        ListViewGroup3.Name = "ListViewGroup3"
        Me.lstIP.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.lstIP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstIP.HideSelection = False
        Me.lstIP.Location = New System.Drawing.Point(3, 3)
        Me.lstIP.Margin = New System.Windows.Forms.Padding(1)
        Me.lstIP.Name = "lstIP"
        Me.lstIP.Size = New System.Drawing.Size(712, 365)
        Me.lstIP.TabIndex = 4
        Me.lstIP.UseCompatibleStateImageBehavior = False
        Me.lstIP.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Name"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Requested"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP Address"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DNS Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Recent"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Average"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Best"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Worst"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Count"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Failures"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 150
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(715, 3)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(1)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 365)
        Me.Splitter1.TabIndex = 21
        Me.Splitter1.TabStop = False
        '
        'TabUnifiDevices
        '
        Me.TabUnifiDevices.Controls.Add(Me.lblDevicedetail)
        Me.TabUnifiDevices.Controls.Add(Me.Splitter3)
        Me.TabUnifiDevices.Controls.Add(Me.lstUnifiDevices)
        Me.TabUnifiDevices.Location = New System.Drawing.Point(4, 22)
        Me.TabUnifiDevices.Name = "TabUnifiDevices"
        Me.TabUnifiDevices.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUnifiDevices.Size = New System.Drawing.Size(1112, 371)
        Me.TabUnifiDevices.TabIndex = 1
        Me.TabUnifiDevices.Text = "Unifi Devices"
        Me.TabUnifiDevices.UseVisualStyleBackColor = True
        '
        'lblDevicedetail
        '
        Me.lblDevicedetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDevicedetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDevicedetail.Location = New System.Drawing.Point(3, 228)
        Me.lblDevicedetail.Multiline = True
        Me.lblDevicedetail.Name = "lblDevicedetail"
        Me.lblDevicedetail.ReadOnly = True
        Me.lblDevicedetail.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.lblDevicedetail.Size = New System.Drawing.Size(1106, 140)
        Me.lblDevicedetail.TabIndex = 8
        '
        'Splitter3
        '
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter3.Location = New System.Drawing.Point(3, 218)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(1106, 10)
        Me.Splitter3.TabIndex = 7
        Me.Splitter3.TabStop = False
        '
        'lstUnifiDevices
        '
        Me.lstUnifiDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader15, Me.ColumnHeader14, Me.ColumnHeader26, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lstUnifiDevices.ContextMenuStrip = Me.DeviceContextStrip
        Me.lstUnifiDevices.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstUnifiDevices.FullRowSelect = True
        Me.lstUnifiDevices.HideSelection = False
        Me.lstUnifiDevices.Location = New System.Drawing.Point(3, 3)
        Me.lstUnifiDevices.Name = "lstUnifiDevices"
        Me.lstUnifiDevices.Size = New System.Drawing.Size(1106, 215)
        Me.lstUnifiDevices.TabIndex = 1
        Me.lstUnifiDevices.UseCompatibleStateImageBehavior = False
        Me.lstUnifiDevices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Name"
        Me.ColumnHeader11.Width = 150
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Type"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Model"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Model Name"
        Me.ColumnHeader15.Width = 150
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "IP Address"
        Me.ColumnHeader14.Width = 100
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Fixed IP"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "IP Type"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "MAC"
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Version"
        Me.ColumnHeader18.Width = 100
        '
        'DeviceContextStrip
        '
        Me.DeviceContextStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRemoveFromPingListToolStripMenuItem})
        Me.DeviceContextStrip.Name = "DeviceContextStrip"
        Me.DeviceContextStrip.Size = New System.Drawing.Size(197, 26)
        '
        'AddRemoveFromPingListToolStripMenuItem
        '
        Me.AddRemoveFromPingListToolStripMenuItem.Name = "AddRemoveFromPingListToolStripMenuItem"
        Me.AddRemoveFromPingListToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AddRemoveFromPingListToolStripMenuItem.Text = "&Add Device to Ping List"
        '
        'TabUnifiClients
        '
        Me.TabUnifiClients.Controls.Add(Me.lblFullDetails)
        Me.TabUnifiClients.Controls.Add(Me.Splitter2)
        Me.TabUnifiClients.Controls.Add(Me.lstClient)
        Me.TabUnifiClients.Location = New System.Drawing.Point(4, 22)
        Me.TabUnifiClients.Name = "TabUnifiClients"
        Me.TabUnifiClients.Size = New System.Drawing.Size(1112, 371)
        Me.TabUnifiClients.TabIndex = 2
        Me.TabUnifiClients.Text = "Unifi Clients"
        Me.TabUnifiClients.UseVisualStyleBackColor = True
        '
        'lblFullDetails
        '
        Me.lblFullDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFullDetails.Location = New System.Drawing.Point(0, 282)
        Me.lblFullDetails.Name = "lblFullDetails"
        Me.lblFullDetails.Size = New System.Drawing.Size(1112, 89)
        Me.lblFullDetails.TabIndex = 4
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(0, 272)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(1112, 10)
        Me.Splitter2.TabIndex = 5
        Me.Splitter2.TabStop = False
        '
        'lstClient
        '
        Me.lstClient.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader27, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25})
        Me.lstClient.ContextMenuStrip = Me.ClientContextStrip
        Me.lstClient.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstClient.FullRowSelect = True
        Me.lstClient.HideSelection = False
        Me.lstClient.Location = New System.Drawing.Point(0, 0)
        Me.lstClient.Name = "lstClient"
        Me.lstClient.Size = New System.Drawing.Size(1112, 272)
        Me.lstClient.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstClient.TabIndex = 2
        Me.lstClient.UseCompatibleStateImageBehavior = False
        Me.lstClient.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Name"
        Me.ColumnHeader19.Width = 150
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Organisation"
        Me.ColumnHeader20.Width = 150
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "IP"
        Me.ColumnHeader21.Width = 100
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Fixed IP"
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "MAC"
        Me.ColumnHeader22.Width = 100
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "WiFi"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "First Seen"
        Me.ColumnHeader24.Width = 120
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Last Seen"
        Me.ColumnHeader25.Width = 120
        '
        'ClientContextStrip
        '
        Me.ClientContextStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddClientToPingList})
        Me.ClientContextStrip.Name = "ClientContextStrip"
        Me.ClientContextStrip.Size = New System.Drawing.Size(193, 26)
        '
        'mnuAddClientToPingList
        '
        Me.mnuAddClientToPingList.Name = "mnuAddClientToPingList"
        Me.mnuAddClientToPingList.Size = New System.Drawing.Size(192, 22)
        Me.mnuAddClientToPingList.Text = "&Add Client to Ping List"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPlayStop)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumInterval)
        Me.GroupBox1.Location = New System.Drawing.Point(293, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 59)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Active Ping"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetIPListToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.ToolStripButton2, Me.PlayStopbtn, Me.ToolStripSeparator2, Me.RefreshUNIFITool, Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.btnShowChart, Me.mnuAddToChart})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1120, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ResetIPListToolStripButton
        '
        Me.ResetIPListToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ResetIPListToolStripButton.Image = CType(resources.GetObject("ResetIPListToolStripButton.Image"), System.Drawing.Image)
        Me.ResetIPListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResetIPListToolStripButton.Name = "ResetIPListToolStripButton"
        Me.ResetIPListToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ResetIPListToolStripButton.Text = "&Reset"
        Me.ResetIPListToolStripButton.ToolTipText = "Reset List"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.chkAutosave})
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(32, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'chkAutosave
        '
        Me.chkAutosave.CheckOnClick = True
        Me.chkAutosave.Enabled = False
        Me.chkAutosave.Name = "chkAutosave"
        Me.chkAutosave.Size = New System.Drawing.Size(180, 22)
        Me.chkAutosave.Text = "Autosave"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Ping.My.Resources.Resources.add1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Add New IP Adress"
        '
        'PlayStopbtn
        '
        Me.PlayStopbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlayStopbtn.Image = Global.Ping.My.Resources.Resources.Play
        Me.PlayStopbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PlayStopbtn.Name = "PlayStopbtn"
        Me.PlayStopbtn.Size = New System.Drawing.Size(23, 22)
        Me.PlayStopbtn.Text = "Play"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RefreshUNIFITool
        '
        Me.RefreshUNIFITool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshUNIFITool.Image = CType(resources.GetObject("RefreshUNIFITool.Image"), System.Drawing.Image)
        Me.RefreshUNIFITool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshUNIFITool.Name = "RefreshUNIFITool"
        Me.RefreshUNIFITool.Size = New System.Drawing.Size(23, 22)
        Me.RefreshUNIFITool.Text = "&Refresh Unifi"
        Me.RefreshUNIFITool.ToolTipText = "Refresh Unifi Clients and Devices"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnShowChart
        '
        Me.btnShowChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnShowChart.Image = CType(resources.GetObject("btnShowChart.Image"), System.Drawing.Image)
        Me.btnShowChart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnShowChart.Name = "btnShowChart"
        Me.btnShowChart.Size = New System.Drawing.Size(23, 22)
        Me.btnShowChart.Text = "Show Chart"
        '
        'mnuAddToChart
        '
        Me.mnuAddToChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuAddToChart.Enabled = False
        Me.mnuAddToChart.Image = Global.Ping.My.Resources.Resources.AddToChart
        Me.mnuAddToChart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuAddToChart.Name = "mnuAddToChart"
        Me.mnuAddToChart.Size = New System.Drawing.Size(23, 22)
        Me.mnuAddToChart.Text = "ToolStripButton1"
        '
        'imgListPlayStop
        '
        Me.imgListPlayStop.ImageStream = CType(resources.GetObject("imgListPlayStop.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListPlayStop.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListPlayStop.Images.SetKeyName(0, "Play")
        Me.imgListPlayStop.Images.SetKeyName(1, "Stop")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 468)
        Me.Controls.Add(Me.TabMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "frmMain"
        Me.Text = "Ping Explorer"
        Me.lstContextMenu.ResumeLayout(False)
        CType(Me.NumInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChart.ResumeLayout(False)
        Me.TabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabUnifiDevices.ResumeLayout(False)
        Me.TabUnifiDevices.PerformLayout()
        Me.DeviceContextStrip.ResumeLayout(False)
        Me.TabUnifiClients.ResumeLayout(False)
        Me.ClientContextStrip.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents EditGroupingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstContextMenu As ContextMenuStrip
    Friend WithEvents mnuGroups As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
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
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnuAddToChart As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripSplitButton
    Friend WithEvents chkAutosave As ToolStripMenuItem
End Class
