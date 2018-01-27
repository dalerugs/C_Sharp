Module Module1

    Sub Main()
        Dim base, height, area As Integer

        Console.WriteLine("Input Base:")
        base = CInt(Console.ReadLine())
        Console.WriteLine("Input Height:")
        height = CInt(Console.ReadLine())

        area = (base * height) / 2

        Console.WriteLine("Area of Triangle: {0}", area)
        Console.ReadLine()
    End Sub

End Module
