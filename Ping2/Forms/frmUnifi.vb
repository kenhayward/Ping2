Imports System.Xml
Imports Newtonsoft.Json.Linq

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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        SaveFields(TestController)
        If TestController.Test() Then
            Me.pnlTest.Enabled = True
            Me.lstUnifiDevices.Items.Clear()
            For Each device In TestController.DeviceList
                Dim MyItem As New ListViewItem
                MyItem.Text = device.Name
                MyItem.SubItems.Add(device.DeviceType)
                MyItem.SubItems.Add(device.Model)
                MyItem.SubItems.Add(device.IP)
                MyItem.SubItems.Add(device.IPType)
                MyItem.SubItems.Add(device.MacAddress)
                MyItem.SubItems.Add(device.Version)
                Me.lstUnifiDevices.Items.Add(MyItem)
                MyItem.Tag = device
            Next
            Me.lstClient.Items.Clear()
            For Each client In TestController.ClientList
                Dim MyItem As New ListViewItem
                MyItem.Text = client.Name
                If client.HostName IsNot Nothing Then MyItem.Text &= "(" & client.HostName & ")"
                MyItem.SubItems.Add(client.Organisation)
                MyItem.SubItems.Add(client.IP)
                MyItem.SubItems.Add(client.MacAddress)
                MyItem.SubItems.Add(client.Wifi.ToString)
                MyItem.SubItems.Add(client.FirstSeen.ToString)
                MyItem.SubItems.Add(client.LastSeen.ToString)

                MyItem.Tag = client
                Me.lstClient.Items.Add(MyItem)
            Next
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

        Me.lblCode.Text = "Status: " & Response.StatusCode
        Me.lblRequest.Text = TestController.URLBase & txtEndPoint.Text
        Try
            Dim jsonFormatted = JValue.Parse(Response.Content).ToString(Formatting.Indented)
            Me.txtResponse.Text = jsonFormatted
        Catch ex As Exception
            Me.txtResponse.Text = Response.Content
        End Try
    End Sub

    Private Sub ColumnClick(ByVal sender As Object,
    ByVal e As System.Windows.Forms.ColumnClickEventArgs) _
    Handles lstClient.ColumnClick
        If lstClient.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Descending Then
            lstClient.Columns.Item(e.Column).ListView.Sorting = SortOrder.Descending
        ElseIf lstClient.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Ascending Then
            lstClient.Columns.Item(e.Column).ListView.Sorting = SortOrder.Ascending
        End If
        lstClient.Sort()

    End Sub
End Class