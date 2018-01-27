Public Class Form1
    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        For i As Integer = 20 To 1 Step -1
            If Not (i Mod 2) = 0 Then
                rtbResult.Text += i & Environment.NewLine
            End If
        Next
    End Sub
End Class
