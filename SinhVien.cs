using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinhvien
{
    class SinhVien
    {
       public String MaSV;
        float Toan;
        float Ly;
        float Hoa;
        // default constructors
        public SinhVien()
        {
            this.MaSV = "01";
            this.Toan = (float)7.5;
            this.Ly = (float)8.5;
            this.Hoa = (float)6.0;
        }
        // tham so hoa constructors
        public SinhVien(String MaSv, float Toan, float Ly, float Hoa)
        {
            this.MaSV = MaSV;
            this.Toan = Toan;
            this.Ly = Ly;
            this.Hoa = Hoa;
        }
        // viet ham nhap diem
        // viet ham tinh diem trung binh
        // viet ham in
        public void nhap()
        {
            Console.WriteLine("Nhap ma");
            this.MaSV = Console.ReadLine();
            Console.WriteLine("Nhap diem toan");
            this.Toan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Ly");
            this.Ly = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Hoa");
            this.Hoa = float.Parse(Console.ReadLine());
        }
        public float tinhtb()
        {
            return ((this.Toan + this.Ly + this.Hoa) / 3);
        }
        public void In()
        {
            Console.WriteLine("Ma sinh vien: {0} co diem trung binh la {1}", this.MaSV, this.tinhtb());

        }
    }
}
