using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class demo8
    {
        static void Main(string[] args)
        {
            int i, fact = 1;
            int no = int.Parse(Console.ReadLine());
            
         
            for ( i = 1; i <= no; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial is "+ fact);
        }
    }
}
