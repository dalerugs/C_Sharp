Public Class Form1
    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        Dim pi, radius, height, volume As Double
        pi = 3.14
        Try
            radius = CDbl(tbRadius.Text)
            height = CDbl(tbHeight.Text)
            volume = pi * (radius * radius) * height
            tbVolume.Text = volume
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
            tbVolume.Text = ""
        End Try
    End Sub
End Class
