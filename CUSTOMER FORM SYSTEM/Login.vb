Public Class FormLogIn
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UsernameText.TextChanged

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If UsernameText.Text = "Admin" And PasswordText.Text = "12345" Then
            Dim form As New Direction
            form.ShowDialog()
        Else
            MsgBox("Login failed")
            UsernameText.Text = String.Empty
            PasswordText.Text = String.Empty
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PasswordText.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelButton.Click

        UsernameText.Text = String.Empty
        PasswordText.Text = String.Empty

    End Sub

    Private Sub FormLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub PasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordCheckBox.CheckedChanged
        If PasswordCheckBox.Checked = True Then
            PasswordText.UseSystemPasswordChar = False
        Else
            PasswordText.UseSystemPasswordChar = True
        End If
    End Sub
End Class
