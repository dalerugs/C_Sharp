Module Module1

    Sub Main()
        Dim number As Integer
        Console.WriteLine("Input Number:")
        number = CInt(Console.ReadLine())

        If (number Mod 2) Like 0 Then
            Console.WriteLine("The number is EVEN")
        Else
            Console.WriteLine("The number is ODD")
        End If
        Console.ReadLine()

    End Sub

End Module
