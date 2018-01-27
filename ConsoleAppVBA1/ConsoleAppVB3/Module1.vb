Module Module1

    Sub Main()
        Dim r, pi, r_squared, result As Double
        pi = 3.14159
        Console.WriteLine("Input Radius:")
        r = CDbl(Console.ReadLine())
        r_squared = r * r
        result = pi * r_squared
        Console.WriteLine("pi({0})^2 = {1}", r, result)
        Console.ReadLine()


    End Sub

End Module
