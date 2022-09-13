using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo13
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("First Number is greatest  \n\n", num1);
                }
                else
                {
                    Console.Write("Third Number is greatest  \n\n", num3);
                }
            }
            else if (num2 > num3)
                Console.Write("Second Number is greatest \n\n", num2);
            else
                Console.Write("Third Number is greatest \n\n", num3);
        }
    }
}
