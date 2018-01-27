using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, className, schoolName;
            int rollNumber, age;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Class Name: ");
            className = Console.ReadLine();
            Console.WriteLine("Enter your School Name: ");
            schoolName = Console.ReadLine();
            Console.WriteLine("Enter your Roll Number: ");
            rollNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Roll Number: {0}, Name: {1}, School Name: {2}, Class: {3}, Age: {4} "
                , rollNumber, name, schoolName, className, age);

            Console.ReadLine();
        }
    }
}
