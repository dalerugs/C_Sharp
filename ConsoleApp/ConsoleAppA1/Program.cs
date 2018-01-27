using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppA1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, city, street, pin, houseNo;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your City: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter your Street: ");
            street = Console.ReadLine();
            Console.WriteLine("Enter your Pin: ");
            pin = Console.ReadLine();
            Console.WriteLine("Enter your houseNo: ");
            houseNo = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("{0}'s address is {1}, {2}, {3}, {4} ",name,houseNo,street,city,pin);

            Console.ReadLine();
        }
    }
}
