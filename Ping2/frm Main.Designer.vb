<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewGroup1 As ListViewGroup = New ListViewGroup("Switch", HorizontalAlignment.Left)
        Dim ListViewGroup2 As ListViewGroup = New ListViewGroup("Gateway", HorizontalAlignment.Left)
        Dim ListViewGroup3 As ListViewGroup = New ListViewGroup("Access Point", HorizontalAlignment.Left)
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label1 = New Label()
        txtIPAddress = New TextBox()
        btnAddIP = New Button()
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
        lstContextMenu = New ContextMenuStrip(components)
        mnuGroups = New ToolStripMenuItem()
        RemoveToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        NumInterval = New NumericUpDown()
        txtFriendly = New TextBox()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        OpenIPListToolStripMenuItem = New ToolStripMenuItem()
        SaveIPListToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripSeparator()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        RemoveSelectedToolStripMenuItem = New ToolStripMenuItem()
        EditGroupingToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        chkAutosave = New CheckBox()
        Label4 = New Label()
        txtFile = New TextBox()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        lstContextMenu.SuspendLayout()
        CType(NumInterval, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        StatusStrip1.SuspendLayout()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 13)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 0
        Label1.Text = "Address"
        ' 
        ' txtIPAddress
        ' 
        txtIPAddress.Location = New Point(106, 11)
        txtIPAddress.Margin = New Padding(1)
        txtIPAddress.Name = "txtIPAddress"
        txtIPAddress.Size = New Size(179, 23)
        txtIPAddress.TabIndex = 1
        txtIPAddress.Text = "192.168.1.1"
        ' 
        ' btnAddIP
        ' 
        btnAddIP.Image = My.Resources.Resources.add1
        btnAddIP.Location = New Point(286, 11)
        btnAddIP.Margin = New Padding(1)
        btnAddIP.Name = "btnAddIP"
        btnAddIP.Size = New Size(38, 38)
        btnAddIP.TabIndex = 2
        btnAddIP.UseVisualStyleBackColor = True
        ' 
        ' lstIP
        ' 
        lstIP.Columns.AddRange(New ColumnHeader() {ColumnHeader7, ColumnHeader10, ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader8, ColumnHeader9})
        lstIP.ContextMenuStrip = lstContextMenu
        lstIP.Dock = DockStyle.Fill
        lstIP.FullRowSelect = True
        lstIP.GridLines = True
        ListViewGroup1.CollapsedState = ListViewGroupCollapsedState.Expanded
        ListViewGroup1.Header = "Switch"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.CollapsedState = ListViewGroupCollapsedState.Expanded
        ListViewGroup2.Header = "Gateway"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.CollapsedState = ListViewGroupCollapsedState.Expanded
        ListViewGroup3.Header = "Access Point"
        ListViewGroup3.Name = "ListViewGroup3"
        lstIP.Groups.AddRange(New ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        lstIP.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lstIP.HideSelection = True
        lstIP.Location = New Point(0, 92)
        lstIP.Margin = New Padding(1)
        lstIP.Name = "lstIP"
        lstIP.Size = New Size(1102, 360)
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
        ' lstContextMenu
        ' 
        lstContextMenu.Items.AddRange(New ToolStripItem() {mnuGroups, RemoveToolStripMenuItem})
        lstContextMenu.Name = "ContextMenuStrip1"
        lstContextMenu.Size = New Size(118, 48)
        ' 
        ' mnuGroups
        ' 
        mnuGroups.Name = "mnuGroups"
        mnuGroups.Size = New Size(117, 22)
        mnuGroups.Text = "Group"
        ' 
        ' RemoveToolStripMenuItem
        ' 
        RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        RemoveToolStripMenuItem.Size = New Size(117, 22)
        RemoveToolStripMenuItem.Text = "Remove"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(365, 13)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 15)
        Label2.TabIndex = 8
        Label2.Text = "Refresh (Seconds)"
        ' 
        ' NumInterval
        ' 
        NumInterval.Location = New Point(365, 32)
        NumInterval.Margin = New Padding(1)
        NumInterval.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        NumInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumInterval.Name = "NumInterval"
        NumInterval.Size = New Size(112, 23)
        NumInterval.TabIndex = 9
        NumInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' txtFriendly
        ' 
        txtFriendly.Location = New Point(106, 31)
        txtFriendly.Margin = New Padding(1)
        txtFriendly.Name = "txtFriendly"
        txtFriendly.Size = New Size(179, 23)
        txtFriendly.TabIndex = 10
        txtFriendly.Text = "Gateway"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 34)
        Label3.Margin = New Padding(1, 0, 1, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 11
        Label3.Text = "Friendly Name"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1102, 24)
        MenuStrip1.TabIndex = 14
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenIPListToolStripMenuItem, SaveIPListToolStripMenuItem, ExitToolStripMenuItem, ExitToolStripMenuItem1})
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
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RemoveSelectedToolStripMenuItem, EditGroupingToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' RemoveSelectedToolStripMenuItem
        ' 
        RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        RemoveSelectedToolStripMenuItem.ShortcutKeys = Keys.Delete
        RemoveSelectedToolStripMenuItem.Size = New Size(188, 22)
        RemoveSelectedToolStripMenuItem.Text = "&Remove Selected"
        ' 
        ' EditGroupingToolStripMenuItem
        ' 
        EditGroupingToolStripMenuItem.Name = "EditGroupingToolStripMenuItem"
        EditGroupingToolStripMenuItem.Size = New Size(188, 22)
        EditGroupingToolStripMenuItem.Text = "Edit Grouping"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(chkAutosave)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtFile)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtFriendly)
        Panel1.Controls.Add(txtIPAddress)
        Panel1.Controls.Add(NumInterval)
        Panel1.Controls.Add(btnAddIP)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1102, 68)
        Panel1.TabIndex = 15
        ' 
        ' chkAutosave
        ' 
        chkAutosave.AutoSize = True
        chkAutosave.Enabled = False
        chkAutosave.Location = New Point(616, 12)
        chkAutosave.Name = "chkAutosave"
        chkAutosave.Size = New Size(75, 19)
        chkAutosave.TabIndex = 14
        chkAutosave.Text = "Autosave"
        chkAutosave.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(489, 13)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 15)
        Label4.TabIndex = 13
        Label4.Text = "Current IP List File"
        ' 
        ' txtFile
        ' 
        txtFile.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFile.Location = New Point(489, 32)
        txtFile.Margin = New Padding(1)
        txtFile.Name = "txtFile"
        txtFile.ReadOnly = True
        txtFile.Size = New Size(603, 23)
        txtFile.TabIndex = 12
        txtFile.Text = "PingList.csv"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 430)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1102, 22)
        StatusStrip1.TabIndex = 16
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 17)
        lblStatus.Text = "Ready"
        ' 
        ' Form1
        ' 
        AcceptButton = btnAddIP
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 452)
        Controls.Add(StatusStrip1)
        Controls.Add(lstIP)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(1)
        Name = "Form1"
        Text = "Ping Explorer"
        lstContextMenu.ResumeLayout(False)
        CType(NumInterval, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
End Class
