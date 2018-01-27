Public Class Form1
    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        For i As Integer = 1 To 50
            Dim sqrt As Double = Math.Sqrt(i)
            If (sqrt * sqrt) = i Then
                rtbResult.Text += i & Environment.NewLine
            End If
        Next
    End Sub
End Class
