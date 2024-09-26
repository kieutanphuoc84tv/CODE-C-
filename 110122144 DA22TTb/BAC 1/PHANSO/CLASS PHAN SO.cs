using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANSO
{
    class CLASS_PHAN_SO
    {
        public int tuso;
        public int mauso;
        public void NhapPhanso()
        {
            Console.WriteLine("Tu so ="); ;
            this.tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("mau so =");
            do
                this.mauso = int.Parse(Console.ReadLine());
            while (this.mauso == 0);
        }
        public void Xuatphanso()
        {
            Console.WriteLine("Phan so =" + tuso + "/" + mauso);
        }
        public CLASS_PHAN_SO congPhanso(CLASS_PHAN_SO a, CLASS_PHAN_SO b)
        {
            CLASS_PHAN_SO tam = new CLASS_PHAN_SO();
            tam.tuso = a.tuso * b.mauso + b.tuso * a.mauso;
            tam.mauso = a.mauso * b.mauso;
            return tam;
        }
        public CLASS_PHAN_SO hieuPhanso(CLASS_PHAN_SO a, CLASS_PHAN_SO b)
        {
            CLASS_PHAN_SO tam = new CLASS_PHAN_SO();
            tam.tuso = a.tuso * b.mauso - b.tuso * a.mauso;
            tam.mauso = a.tuso * b.mauso;
            return tam;

        }
        public CLASS_PHAN_SO tichPhanso(CLASS_PHAN_SO a, CLASS_PHAN_SO b)
        {
            CLASS_PHAN_SO tam = new CLASS_PHAN_SO();
            tam.tuso = a.tuso * b.mauso * b.tuso * a.mauso;
            tam.mauso = a.tuso * b.mauso;
            return tam;
        }
        public int UC (int a, int b)
        {
            while (a!=b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public CLASS_PHAN_SO Rutgon()
        {
            CLASS_PHAN_SO tam = new CLASS_PHAN_SO();
            int uc = UC(this.tuso, this.mauso);
            tam.tuso = this.tuso / uc;
            tam.mauso = this.mauso / uc;
            return tam;   
        }

        public CLASS_PHAN_SO thuongPhanso(CLASS_PHAN_SO a, CLASS_PHAN_SO b)
        {
            CLASS_PHAN_SO tam = new CLASS_PHAN_SO();
            tam.tuso = a.tuso * b.mauso / b.tuso * a.mauso;
            tam.mauso = a.tuso * b.mauso;
            return tam;
        }
        public static CLASS_PHAN_SO operator + ( CLASS_PHAN_SO a , CLASS_PHAN_SO b)
        {
            CLASS_PHAN_SO tam = new CLASS_PHAN_SO();
            tam.tuso = a.tuso * b.mauso + b.tuso * a.mauso;
            tam.mauso = a.mauso * b.mauso;
            return tam;
        }
    }
}

