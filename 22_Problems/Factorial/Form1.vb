Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim number, result As Double
        Try
            number = CDbl(tbNumber.Text)
            tbResult.Text = Factorial(number)
        Catch ex As Exception
            MessageBox.Show("Invalid Input")
        End Try
    End Sub
    Private Function Factorial(x As Double) As Double
        If (x <= 1) Then
            Return 1
        Else
            Return x * Factorial(x - 1)
        End If
    End Function


End Class
