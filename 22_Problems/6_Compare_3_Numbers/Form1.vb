Public Class Form1
    Private Sub btCompare_Click(sender As Object, e As EventArgs) Handles btCompare.Click
        Dim num1, num2, num3, highestIndex As Double
        Try
            num1 = CDbl(tbNum1.Text)
            num2 = CDbl(tbNum2.Text)
            num3 = CDbl(tbNum3.Text)
            Dim numbers As New ArrayList From {
                num1,
                num2,
                num3
            }
            highestIndex = 0
            For i As Integer = 0 To numbers.Count - 1
                If numbers.Item(i) > numbers.Item(highestIndex) Then
                    highestIndex = i
                End If
            Next
            tbResult.Text = "Highest number is " & numbers.Item(highestIndex)
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try
    End Sub
End Class
