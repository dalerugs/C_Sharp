Public Class Form1
    Private Sub btCalculate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbValue_TextChanged(sender As Object, e As EventArgs) Handles tbValue.TextChanged
        Dim value, percentage, interest As Double
        Try
            value = CDbl(tbValue.Text)
            percentage = numPercentage.Value
            interest = value * (percentage / 100)
            tbInterest.Text = interest
        Catch ex As Exception
            MessageBox.Show("Invalid Value")
        End Try
    End Sub
End Class
