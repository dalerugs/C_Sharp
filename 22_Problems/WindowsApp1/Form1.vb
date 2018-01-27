Public Class Form1

    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        Dim addend1, addend2, sum As Double
        Try
            addend1 = CDbl(tbAddend1.Text)
            addend2 = CDbl(tbAddend2.Text)
            sum = addend1 + addend2
            tbSum.Text = sum
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try
    End Sub
End Class
