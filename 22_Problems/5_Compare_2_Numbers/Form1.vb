Public Class Form1
    Private Sub btCompare_Click(sender As Object, e As EventArgs) Handles btCompare.Click
        Dim num1, num2, highest As Double
        Try
            num1 = CDbl(tbNum1.Text)
            num2 = CDbl(tbNum2.Text)
            If num1 > num2 Then
                tbResult.Text = num1 & " is greater than " & num2
            ElseIf num2 > num1 Then
                tbResult.Text = num2 & " is greater than " & num1
            Else
                tbResult.Text = num1 & " & " & num2 & " are Equal"
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try
    End Sub

    Private Sub tbNum2_TextChanged(sender As Object, e As EventArgs) Handles tbNum2.TextChanged

    End Sub

    Private Sub tbResult_TextChanged(sender As Object, e As EventArgs) Handles tbResult.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub tbNum1_TextChanged(sender As Object, e As EventArgs) Handles tbNum1.TextChanged

    End Sub
End Class
