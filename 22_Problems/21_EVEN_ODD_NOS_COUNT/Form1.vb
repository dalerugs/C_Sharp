Public Class Form1
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim add As Double
        Try
            add = CDbl(tbAdd.Text)
            lbNumbers.Items.Add(add)
            If (add Mod 2) = 0 Then
                tbEven.Text = CInt(tbEven.Text) + 1
            Else
                tbOdd.Text = CInt(tbOdd.Text) + 1
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input")
        End Try
        tbAdd.Text = ""
    End Sub
End Class
