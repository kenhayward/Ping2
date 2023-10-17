Imports System.Xml
Imports Newtonsoft.Json.Linq

Public Class frmUnifi
    ''' <summary>
    ''' Details of the UNIFI Controller, Devices and Clients
    ''' </summary>
    Public Property Controller As UnifiController
#Region "Private Properties"
    Private TestController As New UnifiController
    Private Const ForwardSlash = "/"
#End Region

    Private Sub frmUnifi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Controller.LoadDefaults() Then
            txtPassword.Text = Controller.Password
            txtSite.Text = Controller.Site
            txtURLBase.Text = Controller.URLBase
            txtUser.Text = Controller.UserName
            txtDevicePassword.Text = Controller.DevicePassword
            txtDeviceUser.Text = Controller.DeviceUser

        End If
    End Sub
    Private Sub SaveFields(UC As UnifiController)
        UC.Password = txtPassword.Text.Trim
        UC.Site = txtSite.Text.Trim
        UC.URLBase = txtURLBase.Text.Trim
        UC.UserName = Me.txtUser.Text.Trim
        UC.DevicePassword = txtDevicePassword.Text
        UC.DeviceUSer = txtDeviceUser.Text
        If Not UC.URLBase.EndsWith(ForwardSlash) Then UC.URLBase &= ForwardSlash
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
        txtResponse.Text = ""
        lblCode.Text = ""

        Cursor = Cursors.WaitCursor
        Dim Response = TestController.ExecuteGET(Me.txtEndPoint.Text)
        Cursor = Cursors.Default

        lblCode.Text = "Status: " & Response.StatusCode
        lblRequest.Text = TestController.URLBase & txtEndPoint.Text

        Try
            Dim jsonFormatted = JToken.Parse(Response.Content).ToString(Formatting.Indented)
            txtResponse.Text = jsonFormatted
        Catch ex As Exception
            txtResponse.Text = Response.Content
        End Try
    End Sub

End Class


