Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim username, password As String
        username = tbUsername.Text
        password = tbPassword.Text
        If username.Equals("") Or password.Equals("") Then
            MessageBox.Show("Please enter your username or password")
        ElseIf Not username.Equals("username") Or Not password.Equals("password") Then
            MessageBox.Show("Incorrect username or password")
        Else
            Dim welcome As New Welcome
            welcome.Show()
            Me.Hide()

        End If
        tbUsername.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs)

    End Sub
End Class
