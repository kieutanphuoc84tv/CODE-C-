using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTAPTONGMANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];

            }

            Console.WriteLine("\nTong cua cac phan tu trong mang la: {0}\n", sum);
            Console.ReadKey();
        }
    }
}
