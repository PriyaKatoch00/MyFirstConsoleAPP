using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo2
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter a Number : ");

            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Even Number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Odd Number");
                Console.Read();
            }

        }
    }
}

