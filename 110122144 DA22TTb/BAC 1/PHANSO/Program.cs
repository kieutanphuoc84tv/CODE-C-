using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANSO
{
    class Program
    {
        static void Main(string[] args)
        {
            CLASS_PHAN_SO a = new CLASS_PHAN_SO();
            CLASS_PHAN_SO b = new CLASS_PHAN_SO();
            CLASS_PHAN_SO tam = new CLASS_PHAN_SO();

            Console.WriteLine("Nhap phan so 1");
            a.NhapPhanso();

            Console.WriteLine("Nhap phan so 2");
            b.NhapPhanso();

       
            tam = tam.congPhanso(a, b);
            Console.WriteLine("tong 2 phan so la");
            tam.Xuatphanso();
            tam = tam.hieuPhanso(a, b);
            Console.WriteLine("hieu 2 phan so la:");
            tam.Xuatphanso();
            tam = tam.tichPhanso(a, b);
            Console.WriteLine("tich 2 phan so la:");
            tam.Xuatphanso();
            tam = tam.thuongPhanso(a, b);
            Console.WriteLine("thuong 2 phan so la:");
            tam.Xuatphanso();
            Console.ReadKey();
        }
    }
}
