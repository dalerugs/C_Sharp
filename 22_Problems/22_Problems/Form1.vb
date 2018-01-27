Public Class Form1
    Private Sub tbRadius_TextChanged(sender As Object, e As EventArgs) Handles tbRadius.TextChanged
        Dim pi, radius, area As Double
        pi = 3.14
        Try
            radius = CDbl(tbRadius.Text)
            area = pi * (radius * radius)
            tbArea.Text = area
        Catch ex As Exception
            MessageBox.Show("Invalid Radius")
            tbArea.Text = ""
        End Try
    End Sub
End Class
