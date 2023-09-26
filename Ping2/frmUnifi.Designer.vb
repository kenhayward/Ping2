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
        Me.pnlTest = New System.Windows.Forms.Panel()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.pnlTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(1227, 689)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(175, 51)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(1038, 689)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(175, 51)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "URL Base"
        '
        'txtURLBase
        '
        Me.txtURLBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURLBase.Location = New System.Drawing.Point(173, 27)
        Me.txtURLBase.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtURLBase.Name = "txtURLBase"
        Me.txtURLBase.Size = New System.Drawing.Size(1224, 35)
        Me.txtURLBase.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(173, 85)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(401, 35)
        Me.txtUser.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(173, 143)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(401, 35)
        Me.txtPassword.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'txtSite
        '
        Me.txtSite.Location = New System.Drawing.Point(173, 201)
        Me.txtSite.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(401, 35)
        Me.txtSite.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Site"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(593, 201)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(175, 45)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtEndPoint
        '
        Me.txtEndPoint.Location = New System.Drawing.Point(173, 31)
        Me.txtEndPoint.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtEndPoint.Name = "txtEndPoint"
        Me.txtEndPoint.Size = New System.Drawing.Size(401, 35)
        Me.txtEndPoint.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 38)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Endpoint"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(593, 29)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(175, 45)
        Me.btnTest.TabIndex = 13
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'pnlTest
        '
        Me.pnlTest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTest.Controls.Add(Me.lblRequest)
        Me.pnlTest.Controls.Add(Me.lblCode)
        Me.pnlTest.Controls.Add(Me.Label6)
        Me.pnlTest.Controls.Add(Me.txtResponse)
        Me.pnlTest.Controls.Add(Me.btnTest)
        Me.pnlTest.Controls.Add(Me.txtEndPoint)
        Me.pnlTest.Controls.Add(Me.Label5)
        Me.pnlTest.Enabled = False
        Me.pnlTest.Location = New System.Drawing.Point(35, 279)
        Me.pnlTest.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.pnlTest.Name = "pnlTest"
        Me.pnlTest.Size = New System.Drawing.Size(1367, 397)
        Me.pnlTest.TabIndex = 14
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCode.Location = New System.Drawing.Point(35, 176)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(121, 214)
        Me.lblCode.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Response"
        '
        'txtResponse
        '
        Me.txtResponse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResponse.Location = New System.Drawing.Point(173, 112)
        Me.txtResponse.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.Size = New System.Drawing.Size(1182, 274)
        Me.txtResponse.TabIndex = 14
        '
        'lblRequest
        '
        Me.lblRequest.AutoSize = True
        Me.lblRequest.Location = New System.Drawing.Point(804, 34)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(0, 29)
        Me.lblRequest.TabIndex = 17
        '
        'frmUnifi
        '
        Me.AcceptButton = Me.btnTest
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1430, 767)
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
        Me.Controls.Add(Me.pnlTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnifi"
        Me.Text = "Setup Unifi Controller"
        Me.pnlTest.ResumeLayout(False)
        Me.pnlTest.PerformLayout()
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
    Friend WithEvents pnlTest As Panel
    Friend WithEvents lblCode As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtResponse As TextBox
    Friend WithEvents lblRequest As Label
End Class
