Public Class Form1
    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        Dim total As Integer = 0
        For i As Integer = 1 To 30
            rtbResult.Text += i & Environment.NewLine
            total += i
        Next
        rtbResult.Text += "Total: " & total & Environment.NewLine
    End Sub
End Class
