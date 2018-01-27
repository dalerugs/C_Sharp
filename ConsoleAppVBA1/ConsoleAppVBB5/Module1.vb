Module Module1

    Sub Main()
        Dim number, power, result As Integer
        Console.WriteLine("Input Number:")
        number = CInt(Console.ReadLine())
        Console.WriteLine("Input Power:")
        power = CInt(Console.ReadLine())

        result = number
        For ctr = 1 To power - 1
            result *= number
        Next

        Console.WriteLine("{0}^{1} = {2} ", number, power, result)
        Console.ReadLine()

    End Sub

End Module
