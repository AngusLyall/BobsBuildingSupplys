Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username = UsernameTextBox.Text
        Dim password = PasswordTextBox.Text
        If (username = "admin" And password = "test") Then
            Form4.Show()
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            Me.Hide()

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        CustomerDetails.Show()
        Me.Hide()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
