using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTAP11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b:");
            b = Convert.ToInt32(Console.ReadLine());

            int Tinhsolonnhat = GCD(a, b);

            Console.Write("\nTinhsolonnhat cua {0} va {1} la: {2}\n\n", a, b, Tinhsolonnhat);
            Console.ReadKey();
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}