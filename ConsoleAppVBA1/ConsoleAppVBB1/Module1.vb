Module Module1

    Sub Main()
        Dim input As String

        Console.WriteLine("Input Character:")
        input = Console.ReadLine()

        If input Like "A" Or input Like "a" Or
            input Like "E" Or input Like "e" Or
            input Like "I" Or input Like "i" Or
            input Like "O" Or input Like "o" Or
            input Like "U" Or input Like "u" Then
            Console.WriteLine("The character is Vowel")
        Else
            Console.WriteLine("The character is Consonant")
        End If

        Console.ReadLine()

    End Sub

End Module
