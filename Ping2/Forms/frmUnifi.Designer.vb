﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUnifi
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtURLBase = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtEndPoint = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.pnlTest = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstUnifiDevices = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblFullDetails = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstClient = New Ping.ListViewX()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlTest.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(980, 580)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(899, 580)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "URL Base"
        '
        'txtURLBase
        '
        Me.txtURLBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURLBase.Location = New System.Drawing.Point(74, 12)
        Me.txtURLBase.Name = "txtURLBase"
        Me.txtURLBase.Size = New System.Drawing.Size(981, 20)
        Me.txtURLBase.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(74, 38)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(174, 20)
        Me.txtUser.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(74, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(174, 20)
        Me.txtPassword.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'txtSite
        '
        Me.txtSite.Location = New System.Drawing.Point(74, 90)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(174, 20)
        Me.txtSite.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Site"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(254, 90)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 20)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtEndPoint
        '
        Me.txtEndPoint.Location = New System.Drawing.Point(77, 6)
        Me.txtEndPoint.Name = "txtEndPoint"
        Me.txtEndPoint.Size = New System.Drawing.Size(174, 20)
        Me.txtEndPoint.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Endpoint"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(257, 5)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 20)
        Me.btnTest.TabIndex = 13
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Response"
        '
        'txtResponse
        '
        Me.txtResponse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResponse.Location = New System.Drawing.Point(77, 42)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResponse.Size = New System.Drawing.Size(952, 384)
        Me.txtResponse.TabIndex = 14
        '
        'pnlTest
        '
        Me.pnlTest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTest.Controls.Add(Me.TabPage1)
        Me.pnlTest.Controls.Add(Me.TabPage3)
        Me.pnlTest.Controls.Add(Me.TabPage2)
        Me.pnlTest.Enabled = False
        Me.pnlTest.Location = New System.Drawing.Point(12, 116)
        Me.pnlTest.Name = "pnlTest"
        Me.pnlTest.SelectedIndex = 0
        Me.pnlTest.Size = New System.Drawing.Size(1043, 458)
        Me.pnlTest.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstUnifiDevices)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1035, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Device List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstUnifiDevices
        '
        Me.lstUnifiDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader15, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lstUnifiDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstUnifiDevices.FullRowSelect = True
        Me.lstUnifiDevices.HideSelection = False
        Me.lstUnifiDevices.Location = New System.Drawing.Point(3, 3)
        Me.lstUnifiDevices.Name = "lstUnifiDevices"
        Me.lstUnifiDevices.Size = New System.Drawing.Size(1029, 426)
        Me.lstUnifiDevices.TabIndex = 0
        Me.lstUnifiDevices.UseCompatibleStateImageBehavior = False
        Me.lstUnifiDevices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Model"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IP Address"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "IP Type"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MAC"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Version"
        Me.ColumnHeader7.Width = 100
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblFullDetails)
        Me.TabPage3.Controls.Add(Me.Splitter1)
        Me.TabPage3.Controls.Add(Me.lstClient)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1035, 432)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Client List"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblFullDetails
        '
        Me.lblFullDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFullDetails.Location = New System.Drawing.Point(3, 285)
        Me.lblFullDetails.Name = "lblFullDetails"
        Me.lblFullDetails.Size = New System.Drawing.Size(1029, 144)
        Me.lblFullDetails.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(3, 275)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1029, 10)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblCode)
        Me.TabPage2.Controls.Add(Me.lblRequest)
        Me.TabPage2.Controls.Add(Me.txtResponse)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtEndPoint)
        Me.TabPage2.Controls.Add(Me.btnTest)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1035, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Debug Test"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCode.Location = New System.Drawing.Point(15, 69)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(55, 357)
        Me.lblCode.TabIndex = 17
        '
        'lblRequest
        '
        Me.lblRequest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRequest.Location = New System.Drawing.Point(355, 11)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(674, 23)
        Me.lblRequest.TabIndex = 16
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Model Name"
        Me.ColumnHeader15.Width = 150
        '
        'lstClient
        '
        Me.lstClient.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lstClient.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstClient.FullRowSelect = True
        Me.lstClient.HideSelection = False
        Me.lstClient.Location = New System.Drawing.Point(3, 3)
        Me.lstClient.Name = "lstClient"
        Me.lstClient.Size = New System.Drawing.Size(1029, 272)
        Me.lstClient.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstClient.TabIndex = 1
        Me.lstClient.UseCompatibleStateImageBehavior = False
        Me.lstClient.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Name"
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Organisation"
        Me.ColumnHeader9.Width = 150
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "IP"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "MAC"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "WiFi"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "First Seen"
        Me.ColumnHeader13.Width = 120
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Last Seen"
        Me.ColumnHeader14.Width = 120
        '
        'frmUnifi
        '
        Me.AcceptButton = Me.btnTest
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1067, 615)
        Me.Controls.Add(Me.pnlTest)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtSite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtURLBase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnifi"
        Me.Text = "Setup Unifi Controller"
        Me.pnlTest.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtURLBase As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSite As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtEndPoint As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtResponse As TextBox
    Friend WithEvents pnlTest As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lstUnifiDevices As ListView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents lblCode As Label
    Friend WithEvents lblRequest As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lstClient As ListViewX
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents lblFullDetails As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ColumnHeader15 As ColumnHeader
End Class
