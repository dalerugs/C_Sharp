Public Class Welcome
    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Dim login As New Login
        login.Show()
        Me.Hide()

    End Sub

    Private Sub Welcome_FormClosing(sender As Object, e As FormClosingEventArgs)

    End Sub
End Class