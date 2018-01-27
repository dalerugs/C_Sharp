Public Class Form1
    Private Sub tbNumber_TextChanged(sender As Object, e As EventArgs) Handles tbNumber.TextChanged
        Dim number As Integer
        Try
            number = CInt(tbNumber.Text)
            If (number Mod 2) Like 0 Then
                tbResult.Text = "Even"
            Else
                tbResult.Text = "Odd"
            End If
        Catch ex As Exception
            tbResult.Text = "Invalid"
        End Try
    End Sub
End Class
