using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAC_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                int b = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    if (b == 0)
                        Console.Write("VSN");
                    else
                        Console.Write("VN");
                }
                else
                {
                    double x = - b * 1.0 / a;
                    Console.WriteLine("PT {0}x + {1} = 0 co nghiem x = {2}", a, b, x);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(" loi nhap lieu");
            }
            Console.ReadKey();
        }
    }
}