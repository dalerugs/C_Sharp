Module Module1

    Sub Main()
        Dim name, className, schoolName As String
        Dim rollNumber, age As Integer

        Console.WriteLine("Enter your name: ")
        name = Console.ReadLine()
        Console.WriteLine("Enter your Class Name: ")
        className = Console.ReadLine()
        Console.WriteLine("Enter your School Name: ")
        schoolName = Console.ReadLine()
        Console.WriteLine("Enter your Roll Number: ")
        rollNumber = CInt(Console.ReadLine())
        Console.WriteLine("Enter your Age: ")
        age = CInt(Console.ReadLine())
        Console.WriteLine("")
        Console.WriteLine("Roll Number: {0}, Name: {1}, School Name: {2}, Class: {3}, Age: {4} ",
                          rollNumber, name, schoolName, className, age)

        Console.ReadLine()
    End Sub

End Module
