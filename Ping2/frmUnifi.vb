Public Class frmUnifi
    Public Property Controller As UnifiController
    Private TestController As New UnifiController
    Private Sub frmUnifi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Controller.Load(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\UnifiController.bin")

        Me.txtPassword.Text = Controller.Password
        Me.txtSite.Text = Controller.Site
        Me.txtURLBase.Text = Controller.URLBase
        Me.txtUser.Text = Controller.UserName


    End Sub
    Private Sub SaveFields(UC As UnifiController)
        UC.Password = Me.txtPassword.Text.Trim
        UC.Site = Me.txtSite.Text.Trim
        UC.URLBase = Me.txtURLBase.Text.Trim
        If Not UC.URLBase.EndsWith("/") Then
            UC.URLBase &= "/"
        End If
        UC.UserName = Me.txtUser.Text.Trim
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
        SaveFields(Controller)
        Controller.Save(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\UnifiController.bin")

        Me.Close()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        SaveFields(TestController)
        If TestController.Test() Then
            Me.pnlTest.Enabled = True
        Else
            MsgBox("Login Failure", MsgBoxStyle.OkOnly, "Unifi Controller Login")
            Me.pnlTest.Enabled = False
        End If

    End Sub

    Private Sub btnTest_Click_1(sender As Object, e As EventArgs) Handles btnTest.Click
        Me.txtResponse.Text = ""
        Me.lblCode.Text = ""
        Me.Cursor = Cursors.WaitCursor
        Dim Response = TestController.ExecuteGET(Me.txtEndPoint.Text)
        Me.Cursor = Cursors.Default
        Me.txtResponse.Text = Response.Content
        Me.lblCode.Text = "Status: " & Response.StatusCode
        Me.lblRequest.Text = TestController.URLBase & txtEndPoint.Text
    End Sub
End Class