using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class Demo15
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            int j;
            int c = 0;
            int k = 0;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > c)
                    c = arr[i];
                if (arr[i] < k)
                    k = arr[i];
            }
            Array.Sort(arr);
            int sum = arr.Sum();
            int avg = sum / 10;

            Console.WriteLine(avg);
            Console.WriteLine(sum);
            Console.WriteLine(c);
            Console.WriteLine(k);


            for (j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine();
            Array.Reverse(arr);
            for (j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
