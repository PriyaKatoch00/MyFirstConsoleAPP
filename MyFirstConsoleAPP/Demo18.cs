using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First word");

            string s1 = Console.ReadLine();

            Console.WriteLine("Enter Second word");

            string s2 = Console.ReadLine();

            if (s1 == s2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            

        }
    }
}
