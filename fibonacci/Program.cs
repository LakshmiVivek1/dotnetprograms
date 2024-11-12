using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, f3, i;
            Console.Write("Enter the number of terms for the Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The Series is:");

            for (i = 0; i < n; i++)
            {
                Console.Write(f1 + " ");
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }

            Console.ReadLine();
        }
    }
}
