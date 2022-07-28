Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Dim username = txt_username.Text
        Dim password = txt_password.Text
        If (username = "admin" And password = "%Lg3tW(@") Then ' if the password is correct
            Form4.Show() ' open form4
            txt_username.Text = "" ' set the textbox value to blank
            txt_password.Text = ""
            Me.Hide() ' hide this form

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        CustomerDetails.Show() ' if the user clicks cancel returns to form 1
        Me.Hide() ' hides current form
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles lbl_username.Click

    End Sub
End Class
