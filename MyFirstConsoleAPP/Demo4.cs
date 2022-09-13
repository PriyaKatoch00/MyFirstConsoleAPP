using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo4
    {
        static void Main(string[] args)
        {

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i < y; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
