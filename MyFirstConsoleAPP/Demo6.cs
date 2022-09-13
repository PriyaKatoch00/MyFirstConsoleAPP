using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo6
    {
        static void Main(string[] args)
        {

            

            double cel;
            Console.WriteLine("Enter temp in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            

            cel = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temp in Celsius " + cel);

            Console.ReadLine();
        }
    }
}
