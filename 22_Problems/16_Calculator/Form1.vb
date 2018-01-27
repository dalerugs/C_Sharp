Public Class Form1
    Dim value1 As String = ""
    Dim value2 As String = ""
    Dim value3 As Double = 0.0
    Private Sub bt0_Click(sender As Object, e As EventArgs) Handles bt0.Click
        If tbInput.Text = value1 Then
            tbInput.Text = "0."
        ElseIf tbInput.Text = "0." Then
            tbInput.Text = "0."
        ElseIf tbInput.Text = "0" Then
            tbInput.Text = "0."
        ElseIf tbInput.Text = value1 Then
            tbInput.Text = "0."
        Else : tbInput.Text = tbInput.Text & "0"
        End If
    End Sub
    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        value1 = ""
        value2 = ""
        value3 = 0.0
        tbInput.Text = 0.0
    End Sub
    Private Sub btDot_Click(sender As Object, e As EventArgs) Handles btDot.Click
        If tbInput.Text = "0." Then
            tbInput.Text = "."
        ElseIf tbInput.Text = value3 Then
            tbInput.Text = "."
        ElseIf tbInput.Text = value1 Then
            tbInput.Text = "."
        Else
            If tbInput.Text.Contains(".") Then
            Else
                tbInput.Text = tbInput.Text & "."
            End If
        End If
    End Sub
    Private Sub btEquals_Click(sender As Object, e As EventArgs) Handles btEquals.Click
        If value1 > "" And value2 = "+" Then
            tbInput.Text = Val(value1) + Val(tbInput.Text)
            value3 = tbInput.Text
        ElseIf value2 > "" And value2 = "-" Then
            tbInput.Text = Val(value1) - Val(tbInput.Text)
            value3 = tbInput.Text
        ElseIf value2 > "" And value2 = "X" Then
            tbInput.Text = Val(value1) * Val(tbInput.Text)
            value3 = tbInput.Text
        ElseIf value2 > "" And value2 = "/" Then
            tbInput.Text = Val(value1) / Val(tbInput.Text)
            value3 = tbInput.Text
        Else
        End If
    End Sub
    Private Sub btAdd_Click_1(sender As Object, e As EventArgs) Handles btSub.Click, btMul.Click, btDiv.Click, btAdd.Click
        value2 = sender.text
        value1 = tbInput.Text
    End Sub
    Private Sub bt1_Click_1(sender As Object, e As EventArgs) Handles bt9.Click, bt8.Click, bt7.Click, bt6.Click, bt5.Click, bt4.Click, bt3.Click, bt2.Click, bt1.Click
        If tbInput.Text = value1 Then
            tbInput.Text = sender.text
        ElseIf tbInput.Text = "0." Then
            tbInput.Text = sender.text
        ElseIf tbInput.Text = value3 Then
            tbInput.Text = sender.text
        Else
            tbInput.Text = tbInput.Text & sender.text
        End If
    End Sub
End Class
