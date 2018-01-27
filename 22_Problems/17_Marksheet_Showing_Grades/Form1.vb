Public Class Form1
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        dataGrade.Rows.Add(New String() {tbSubject.Text, tbGrade.Text})
        tbSubject.Text = ""
        tbGrade.Text = ""
    End Sub
End Class
