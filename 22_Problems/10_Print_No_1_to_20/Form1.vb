Public Class Form1
    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        For i As Integer = 1 To 20
            rtbResult.Text += i & Environment.NewLine
        Next
    End Sub
End Class
