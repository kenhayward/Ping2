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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.lstContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuGroups = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumInterval = New System.Windows.Forms.NumericUpDown()
        Me.txtFriendly = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenIPListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveIPListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditGroupingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAutosave = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.btnAddIP = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.btnResetGraph = New System.Windows.Forms.Button()
        Me.AddToChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnlChart = New System.Windows.Forms.Panel()
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
        Me.lstContextMenu.SuspendLayout()
        CType(Me.NumInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChart.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Address"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(212, 21)
        Me.txtIPAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(354, 35)
        Me.txtIPAddress.TabIndex = 1
        Me.txtIPAddress.Text = "192.168.1.1"
        '
        'lstContextMenu
        '
        Me.lstContextMenu.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.lstContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGroups, Me.AddToChartToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveToolStripMenuItem})
        Me.lstContextMenu.Name = "ContextMenuStrip1"
        Me.lstContextMenu.Size = New System.Drawing.Size(398, 142)
        '
        'mnuGroups
        '
        Me.mnuGroups.Name = "mnuGroups"
        Me.mnuGroups.Size = New System.Drawing.Size(397, 44)
        Me.mnuGroups.Text = "Group"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(397, 44)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(730, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Refresh (Seconds)"
        '
        'NumInterval
        '
        Me.NumInterval.Location = New System.Drawing.Point(730, 62)
        Me.NumInterval.Margin = New System.Windows.Forms.Padding(2)
        Me.NumInterval.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumInterval.Name = "NumInterval"
        Me.NumInterval.Size = New System.Drawing.Size(224, 35)
        Me.NumInterval.TabIndex = 9
        Me.NumInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtFriendly
        '
        Me.txtFriendly.Location = New System.Drawing.Point(212, 60)
        Me.txtFriendly.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFriendly.Name = "txtFriendly"
        Me.txtFriendly.Size = New System.Drawing.Size(354, 35)
        Me.txtFriendly.TabIndex = 10
        Me.txtFriendly.Text = "Gateway"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Friendly Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(2204, 54)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenIPListToolStripMenuItem, Me.SaveIPListToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(80, 46)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenIPListToolStripMenuItem
        '
        Me.OpenIPListToolStripMenuItem.Name = "OpenIPListToolStripMenuItem"
        Me.OpenIPListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenIPListToolStripMenuItem.Size = New System.Drawing.Size(405, 48)
        Me.OpenIPListToolStripMenuItem.Text = "&Open IP List"
        '
        'SaveIPListToolStripMenuItem
        '
        Me.SaveIPListToolStripMenuItem.Name = "SaveIPListToolStripMenuItem"
        Me.SaveIPListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveIPListToolStripMenuItem.Size = New System.Drawing.Size(405, 48)
        Me.SaveIPListToolStripMenuItem.Text = "&Save IP List"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(402, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(405, 48)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedToolStripMenuItem, Me.EditGroupingToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(85, 46)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(426, 48)
        Me.RemoveSelectedToolStripMenuItem.Text = "&Remove Selected"
        '
        'EditGroupingToolStripMenuItem
        '
        Me.EditGroupingToolStripMenuItem.Name = "EditGroupingToolStripMenuItem"
        Me.EditGroupingToolStripMenuItem.Size = New System.Drawing.Size(426, 48)
        Me.EditGroupingToolStripMenuItem.Text = "Edit Grouping"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowChartToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(97, 46)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ShowChartToolStripMenuItem
        '
        Me.ShowChartToolStripMenuItem.Name = "ShowChartToolStripMenuItem"
        Me.ShowChartToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ShowChartToolStripMenuItem.Size = New System.Drawing.Size(394, 48)
        Me.ShowChartToolStripMenuItem.Text = "Show Chart"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkAutosave)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtFile)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFriendly)
        Me.Panel1.Controls.Add(Me.txtIPAddress)
        Me.Panel1.Controls.Add(Me.NumInterval)
        Me.Panel1.Controls.Add(Me.btnAddIP)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2204, 131)
        Me.Panel1.TabIndex = 15
        '
        'chkAutosave
        '
        Me.chkAutosave.AutoSize = True
        Me.chkAutosave.Enabled = False
        Me.chkAutosave.Location = New System.Drawing.Point(1232, 23)
        Me.chkAutosave.Margin = New System.Windows.Forms.Padding(6)
        Me.chkAutosave.Name = "chkAutosave"
        Me.chkAutosave.Size = New System.Drawing.Size(143, 33)
        Me.chkAutosave.TabIndex = 14
        Me.chkAutosave.Text = "Autosave"
        Me.chkAutosave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(978, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Current IP List File"
        '
        'txtFile
        '
        Me.txtFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFile.Location = New System.Drawing.Point(978, 62)
        Me.txtFile.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(1202, 35)
        Me.txtFile.TabIndex = 12
        Me.txtFile.Text = "PingList.csv"
        '
        'btnAddIP
        '
        Me.btnAddIP.Image = Global.Ping.My.Resources.Resources.add1
        Me.btnAddIP.Location = New System.Drawing.Point(572, 21)
        Me.btnAddIP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddIP.Name = "btnAddIP"
        Me.btnAddIP.Size = New System.Drawing.Size(82, 74)
        Me.btnAddIP.TabIndex = 2
        Me.btnAddIP.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 826)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(2204, 48)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(89, 37)
        Me.lblStatus.Text = "Ready"
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
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(897, 641)
        Me.Chart1.TabIndex = 17
        Me.Chart1.Text = "Chart1"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(1297, 185)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 641)
        Me.Splitter1.TabIndex = 18
        Me.Splitter1.TabStop = False
        '
        'btnResetGraph
        '
        Me.btnResetGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetGraph.Location = New System.Drawing.Point(773, 585)
        Me.btnResetGraph.Name = "btnResetGraph"
        Me.btnResetGraph.Size = New System.Drawing.Size(121, 53)
        Me.btnResetGraph.TabIndex = 19
        Me.btnResetGraph.Text = "Reset"
        Me.btnResetGraph.UseVisualStyleBackColor = True
        '
        'AddToChartToolStripMenuItem
        '
        Me.AddToChartToolStripMenuItem.Name = "AddToChartToolStripMenuItem"
        Me.AddToChartToolStripMenuItem.Size = New System.Drawing.Size(397, 44)
        Me.AddToChartToolStripMenuItem.Text = "Add / Remove from Chart"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(394, 6)
        '
        'pnlChart
        '
        Me.pnlChart.Controls.Add(Me.btnResetGraph)
        Me.pnlChart.Controls.Add(Me.Chart1)
        Me.pnlChart.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlChart.Location = New System.Drawing.Point(1307, 185)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(897, 641)
        Me.pnlChart.TabIndex = 20
        Me.pnlChart.Visible = False
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
        Me.lstIP.Location = New System.Drawing.Point(0, 185)
        Me.lstIP.Margin = New System.Windows.Forms.Padding(2)
        Me.lstIP.Name = "lstIP"
        Me.lstIP.Size = New System.Drawing.Size(1297, 641)
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
        'frmMain
        '
        Me.AcceptButton = Me.btnAddIP
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2204, 874)
        Me.Controls.Add(Me.lstIP)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlChart)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Ping Explorer"
        Me.lstContextMenu.ResumeLayout(False)
        CType(Me.NumInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChart.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label

    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents txtFriendly As TextBox
    Friend WithEvents btnAddIP As Button
    Friend WithEvents lstIP As ListViewX
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFile As TextBox
    Friend WithEvents chkAutosave As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents EditGroupingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstContextMenu As ContextMenuStrip
    Friend WithEvents mnuGroups As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowChartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnResetGraph As Button
    Friend WithEvents AddToChartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents pnlChart As Panel
End Class
