using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6._4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перший член прогресії (a1):");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть різницю прогресії (d):");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість членів прогресії (n):");
            int n = int.Parse(Console.ReadLine());

            int sum = ArithmeticSum(a1, d, n);
            Console.WriteLine($"Сума перших {n} членів арифметичної прогресії: {sum}");
        }
        static int ArithmeticSum(int a1, int d, int n)
        {
            if (n == 1)
                return a1;
            else
            {
            return a1 + ArithmeticSum(a1 + d, d, n - 1); 
            }
        }
    }
}
