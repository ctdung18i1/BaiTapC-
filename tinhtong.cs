using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra2
{
    class tinhtong
    {
        // S = 1-2+3-4+5-...+n
        int i = 0;
        int n = 0;
      
        double a, b, c;
        public void tinh()
        {
            Console.WriteLine(" Nhap N =");
            this.n = Convert.ToInt32(Console.ReadLine());
        }
        public double CauA()
        {
            for (int i = 1; i <= n; i++) ;
            if (i % 2 == 0)
                a -= i;
            else
                a += i;
            return a;
        }
        public double CauB()
        {
            for(i = 1; i <= n; i++)
            {
                b += i / (float)i;
            }
            return b;
        }
        public double CauC()
        {
            for(i = 1; i <= n; i++)
            {
                c += i;
            }
            return c;
        }
        public void In()
        {
            Console.WriteLine("Tong cau A= {0}\n Tong cau B= {1}\n Tong cau C= {2}\n", this.CauA(), this.CauB(), this.CauC());
        }
    }
}
