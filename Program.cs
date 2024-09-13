using System;

namespace NHAPXUAT2NGAY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("NHAP NGAY DAU TIEN (NAM/THANG /NGAY): ");
            string input1 = Console.ReadLine();
            DateTime ngay1;
            if (DateTime.TryParse(input1, out ngay1))
            {
                Console.Write("NHAP NGAY THU 2  (NAM/THANG /NGAY): ");
                string input2 = Console.ReadLine();
                DateTime ngay2;
                if (DateTime.TryParse(input2, out ngay2))
                {
                    TimeSpan khoangCach = ngay2 - ngay1;
                    Console.WriteLine($"KHOAN CACH GIU NGAY LA {khoangCach.Days} ngày.");
                }
                else
                {
                    Console.WriteLine("NGAY THU 2 KHONG HOP LE.VUI LONG NHAP LAI!.");
                }
            }
            else
            {
                Console.WriteLine("NGAY THU 2 KHONG HOP LE. VUI LONG NHAP LAI!.");
            }
        }
    }
}