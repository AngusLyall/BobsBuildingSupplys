Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username = UsernameTextBox.Text
        Dim password = PasswordTextBox.Text
        If (username = "admin" And password = "%Lg3tW(@") Then ' if the password is correct
            Form4.Show() ' open form4
            UsernameTextBox.Text = "" ' set the textbox value to blank
            PasswordTextBox.Text = ""
            Me.Hide() ' hide this form

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        CustomerDetails.Show() ' if the user clicks cancel returns to form 1
        Me.Hide() ' hides current form
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
