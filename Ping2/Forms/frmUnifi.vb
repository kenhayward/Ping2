Imports System.Xml
Imports Newtonsoft.Json.Linq

Public Class frmUnifi
    Public Property Controller As UnifiController
    Private TestController As New UnifiController

    Private Sub frmUnifi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Controller.LoadDefaults()
        txtPassword.Text = Controller.Password
        txtSite.Text = Controller.Site
        txtURLBase.Text = Controller.URLBase
        txtUser.Text = Controller.UserName
    End Sub
    Private Sub SaveFields(UC As UnifiController)
        UC.Password = txtPassword.Text.Trim
        UC.Site = txtSite.Text.Trim
        UC.URLBase = txtURLBase.Text.Trim
        If Not UC.URLBase.EndsWith("/") Then
            UC.URLBase &= "/"
        End If
        UC.UserName = Me.txtUser.Text.Trim
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
        SaveFields(Controller)
        Controller.SaveDefaults()
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        SaveFields(TestController)
        If TestController.Test() Then
            pnlTest.Enabled = True
        Else
            MsgBox("Login Failure", MsgBoxStyle.OkOnly, "Unifi Controller Login")
            pnlTest.Enabled = False
        End If
    End Sub

    Private Sub btnTest_Click_1(sender As Object, e As EventArgs) Handles btnTest.Click
        Me.txtResponse.Text = ""
        Me.lblCode.Text = ""

        Me.Cursor = Cursors.WaitCursor
        Dim Response = TestController.ExecuteGET(Me.txtEndPoint.Text)
        Me.Cursor = Cursors.Default

        Me.lblCode.Text = "Status: " & Response.StatusCode
        Me.lblRequest.Text = TestController.URLBase & txtEndPoint.Text

        Try
            Dim jsonFormatted = JValue.Parse(Response.Content).ToString(Formatting.Indented)
            Me.txtResponse.Text = jsonFormatted
        Catch ex As Exception
            Me.txtResponse.Text = Response.Content
        End Try
    End Sub

End Class


