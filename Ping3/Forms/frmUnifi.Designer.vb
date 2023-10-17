<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        btnCancel = New Button()
        btnOK = New Button()
        Label1 = New Label()
        txtURLBase = New TextBox()
        txtUser = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label3 = New Label()
        txtSite = New TextBox()
        Label4 = New Label()
        btnLogin = New Button()
        txtEndPoint = New TextBox()
        Label5 = New Label()
        btnTest = New Button()
        Label6 = New Label()
        txtResponse = New TextBox()
        pnlTest = New TabControl()
        TabPage2 = New TabPage()
        lblCode = New Label()
        lblRequest = New Label()
        txtDevicePassword = New TextBox()
        Label7 = New Label()
        txtDeviceUser = New TextBox()
        Label8 = New Label()
        pnlTest.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.Location = New Point(486, 455)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(88, 27)
        btnCancel.TabIndex = 0
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnOK
        ' 
        btnOK.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnOK.Location = New Point(391, 455)
        btnOK.Margin = New Padding(4, 3, 4, 3)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(88, 27)
        btnOK.TabIndex = 1
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 17)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 2
        Label1.Text = "URL Base"
        ' 
        ' txtURLBase
        ' 
        txtURLBase.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtURLBase.Location = New Point(86, 14)
        txtURLBase.Margin = New Padding(4, 3, 4, 3)
        txtURLBase.Name = "txtURLBase"
        txtURLBase.Size = New Size(486, 23)
        txtURLBase.TabIndex = 3
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(86, 44)
        txtUser.Margin = New Padding(4, 3, 4, 3)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(202, 23)
        txtUser.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 47)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 4
        Label2.Text = "User"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(86, 74)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(202, 23)
        txtPassword.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 77)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' txtSite
        ' 
        txtSite.Location = New Point(86, 104)
        txtSite.Margin = New Padding(4, 3, 4, 3)
        txtSite.Name = "txtSite"
        txtSite.Size = New Size(202, 23)
        txtSite.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 107)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 15)
        Label4.TabIndex = 8
        Label4.Text = "Site"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(481, 133)
        btnLogin.Margin = New Padding(4, 3, 4, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(88, 23)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtEndPoint
        ' 
        txtEndPoint.Location = New Point(90, 7)
        txtEndPoint.Margin = New Padding(4, 3, 4, 3)
        txtEndPoint.Name = "txtEndPoint"
        txtEndPoint.Size = New Size(202, 23)
        txtEndPoint.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 10)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 11
        Label5.Text = "Endpoint"
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(300, 6)
        btnTest.Margin = New Padding(4, 3, 4, 3)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(88, 23)
        btnTest.TabIndex = 13
        btnTest.Text = "Test"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 52)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 15
        Label6.Text = "Response"
        ' 
        ' txtResponse
        ' 
        txtResponse.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtResponse.Location = New Point(90, 48)
        txtResponse.Margin = New Padding(4, 3, 4, 3)
        txtResponse.Multiline = True
        txtResponse.Name = "txtResponse"
        txtResponse.ScrollBars = ScrollBars.Both
        txtResponse.Size = New Size(452, 200)
        txtResponse.TabIndex = 14
        ' 
        ' pnlTest
        ' 
        pnlTest.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTest.Controls.Add(TabPage2)
        pnlTest.Enabled = False
        pnlTest.Location = New Point(14, 162)
        pnlTest.Margin = New Padding(4, 3, 4, 3)
        pnlTest.Name = "pnlTest"
        pnlTest.SelectedIndex = 0
        pnlTest.Size = New Size(559, 286)
        pnlTest.TabIndex = 15
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lblCode)
        TabPage2.Controls.Add(lblRequest)
        TabPage2.Controls.Add(txtResponse)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(txtEndPoint)
        TabPage2.Controls.Add(btnTest)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Margin = New Padding(4, 3, 4, 3)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4, 3, 4, 3)
        TabPage2.Size = New Size(551, 258)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Debug Test"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lblCode
        ' 
        lblCode.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblCode.Location = New Point(18, 80)
        lblCode.Margin = New Padding(4, 0, 4, 0)
        lblCode.Name = "lblCode"
        lblCode.Size = New Size(64, 169)
        lblCode.TabIndex = 17
        ' 
        ' lblRequest
        ' 
        lblRequest.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblRequest.Location = New Point(414, 13)
        lblRequest.Margin = New Padding(4, 0, 4, 0)
        lblRequest.Name = "lblRequest"
        lblRequest.Size = New Size(129, 27)
        lblRequest.TabIndex = 16
        ' 
        ' txtDevicePassword
        ' 
        txtDevicePassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDevicePassword.Location = New Point(401, 77)
        txtDevicePassword.Margin = New Padding(4, 3, 4, 3)
        txtDevicePassword.Name = "txtDevicePassword"
        txtDevicePassword.PasswordChar = "*"c
        txtDevicePassword.Size = New Size(171, 23)
        txtDevicePassword.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(298, 80)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 15)
        Label7.TabIndex = 18
        Label7.Text = "Device Password"
        ' 
        ' txtDeviceUser
        ' 
        txtDeviceUser.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDeviceUser.Location = New Point(401, 47)
        txtDeviceUser.Margin = New Padding(4, 3, 4, 3)
        txtDeviceUser.Name = "txtDeviceUser"
        txtDeviceUser.Size = New Size(171, 23)
        txtDeviceUser.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(298, 50)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 15)
        Label8.TabIndex = 16
        Label8.Text = "Device User"
        ' 
        ' frmUnifi
        ' 
        AcceptButton = btnTest
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(587, 495)
        Controls.Add(txtDevicePassword)
        Controls.Add(Label7)
        Controls.Add(txtDeviceUser)
        Controls.Add(Label8)
        Controls.Add(pnlTest)
        Controls.Add(btnLogin)
        Controls.Add(txtSite)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(txtUser)
        Controls.Add(Label2)
        Controls.Add(txtURLBase)
        Controls.Add(Label1)
        Controls.Add(btnOK)
        Controls.Add(btnCancel)
        Margin = New Padding(1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmUnifi"
        StartPosition = FormStartPosition.CenterParent
        Text = "Setup Unifi Controller"
        pnlTest.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblCode As Label
    Friend WithEvents lblRequest As Label
    Friend WithEvents txtDevicePassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDeviceUser As TextBox
    Friend WithEvents Label8 As Label
End Class
