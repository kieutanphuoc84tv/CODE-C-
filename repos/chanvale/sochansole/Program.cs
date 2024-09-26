using System;

namespace sochansole
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Nhap vao mot so nguyen duong: ");
            int soNguyen = Convert.ToInt32(Console.ReadLine());

            
            if (soNguyen > 0)
            {
                if (soNguyen % 2 == 0)
                {
                    Console.WriteLine("So {0} la so chan.", soNguyen);
                }
                else
                {
                    Console.WriteLine("So {0} la so le.", soNguyen);
                }
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen duong.");
            }

           
            Console.ReadKey();
        }
    }
}
