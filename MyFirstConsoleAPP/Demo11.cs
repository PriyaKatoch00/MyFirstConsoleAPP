using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo11
    {
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (int j = 1; j <= 20; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }

        }
}
