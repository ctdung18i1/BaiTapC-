using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinhvien
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so sinh vien");
            n = Int32.Parse(Console.ReadLine());
            // tao mang doi tuong sinh vien
            SinhVien[] sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].nhap();
                sv[i].In();
            }
            float min = sv[0].tinhtb();
            for (int i = 1; i < n; i++)
            {
                if (sv[i].tinhtb() < min) min = sv[i].tinhtb();
            }
            Console.WriteLine(" Sinh vien co diem thap nhat la: {0}", min);
            for (int i = 1; i < n; i++)
            {
                if (sv[i].MaSV.Contains("IT"))
                    Console.WriteLine(" SV ma {0} co diem tb la {1}", sv[i].MaSV, sv[i].tinhtb());
            }
            // sap xep mang sv theo diem tb tang giam dan?
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (sv[j].tinhtb() < sv[i].tinhtb())
                    {
                        SinhVien t = new SinhVien();
                        t = sv[i];
                        sv[i] = sv[j];
                        sv[j] = t;
                    }
                }
            }
            Console.WriteLine("Diem Trung Binh Sap Xep Theo Thu Tu Tang Dan:");
            for (int i = 0; i < n; i++)
                Console.WriteLine("MaSv: {0} Diem TB: {1}", sv[i].MaSV, sv[i].tinhtb());
            Console.ReadLine();
        }
    }
}
