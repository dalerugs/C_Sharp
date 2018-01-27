Module Module1

    Sub Main()
        Dim a, b As Integer

        Console.WriteLine("Input A:")
        a = CInt(Console.ReadLine())
        Console.WriteLine("Input B:")
        b = CInt(Console.ReadLine())

        Dim sum As Integer
        sum = a + b
        Dim finalResult As Integer
        finalResult = sum * sum
        Console.WriteLine("({0} + {1})^2 = {2}", a, b, finalResult)
        Console.ReadLine()



    End Sub

End Module
