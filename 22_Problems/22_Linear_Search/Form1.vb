Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputString, inputCharacter As String
        inputString = tbInput.Text
        inputCharacter = tbCharacter.Text
        For i As Integer = 0 To inputString.Length - 1
            If inputCharacter Like inputString.Chars(i) Then
                tbResult.Text = "'" & inputCharacter & "' is in " & (i + 1).ToString & " Position"
                Exit For
            Else
                tbResult.Text = "No search result"
            End If
        Next
    End Sub
End Class
