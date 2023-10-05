Public Class frmAddIP

    Public Property IPAddress As String
    Public Property Friendlyname As String

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
        Me.IPAddress = txtIPAddress.Text
        Me.Friendlyname = txtFriendly.Text
        Me.Close()
    End Sub

    Private Sub txtFriendly_TextChanged(sender As Object, e As EventArgs) Handles txtFriendly.TextChanged, txtIPAddress.TextChanged
        If txtIPAddress.Text.Trim = "" Or txtFriendly.Text.Trim = "" Then
            Me.btnOK.Enabled = False
        Else
            Me.btnOK.Enabled = True
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class