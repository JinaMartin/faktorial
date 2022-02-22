using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Napiš 0 < x < 1");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Napiš n");
            int n = Convert.ToInt32(Console.ReadLine());

            double s = 1;
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * (Math.Pow(x, i) / i);
                s = s + factorial;
                i++;
                if (i < n)
                {
                    factorial = factorial * (Math.Pow(x, i) / i);
                    s = s - factorial;
                }
                else { break; }
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
