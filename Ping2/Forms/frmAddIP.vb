Public Class frmAddIP

    Public Property IPAddress As String
    Public Property Friendlyname As String
    Public Property GroupName As String
    Public Property NewGroup As Boolean
    Public Property LstIP As ListView

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.IPAddress = txtIPAddress.Text
        Me.Friendlyname = txtFriendly.Text
        Me.GroupName = cmbGroup.SelectedItem.ToString
        If cmbGroup.SelectedIndex = cmbGroup.Items.Count - 1 Then
            Me.GroupName = txtGroupName.Text
        End If
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtFriendly_TextChanged(sender As Object, e As EventArgs) Handles txtFriendly.TextChanged, txtIPAddress.TextChanged, cmbGroup.SelectedIndexChanged, txtGroupName.TextChanged
        If txtIPAddress.Text.Trim = "" Or txtFriendly.Text.Trim = "" Then
            Me.btnOK.Enabled = False
        Else
            If cmbGroup.SelectedIndex = cmbGroup.Items.Count - 1 Then
                ' Need group name 
                If txtGroupName.Text.Trim = "" Then
                    Me.btnOK.Enabled = False
                Else
                    Me.btnOK.Enabled = True
                End If
            Else
                Me.btnOK.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmAddIP_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.cmbGroup.Items.Add("<Default>")
        If LstIP Is Nothing Then
            Me.cmbGroup.Enabled = False
        Else
            If LstIP.Groups IsNot Nothing Then
                For Each group In LstIP.Groups
                    Me.cmbGroup.Items.Add(group)
                Next
            End If
            Me.cmbGroup.Items.Add("New Group...")
            Me.cmbGroup.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedIndexChanged
        If cmbGroup.SelectedIndex = cmbGroup.Items.Count - 1 Then
            lblGroupName.Visible = True
            txtGroupName.Visible = True
        Else
            lblGroupName.Visible = False
            txtGroupName.Visible = False
        End If
    End Sub
End Class