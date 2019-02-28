using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra
{
    class doantau
    { //  Tạo lóp đoàn tàu gồm các thông tin
      // - số lượng khách
      // - mã đoàn tàu
      // nhập mã đoàn tàu, số lượng khách
      // tính tiền theo công thức sau:
      // nếu số lượng khách  < 100: tien=soluong*100000
      // ngược lại: tien=soluong*80000
      // in ra màn hình mã tàu và tiền
        int Soluongkhach;
        string Madt;
        double tien1, tien2;
        public void tinh()
        {
            Console.WriteLine(" Nhap ma doan tau ");
            this.Madt = Console.ReadLine();
            Console.WriteLine(" Nhap so luong khach");
            this.Soluongkhach = Convert.ToInt32(Console.ReadLine());
            if (Soluongkhach < 100)
            {
                tien1 = Soluongkhach * 100000;
                Console.WriteLine(" Ma tau {0} : Tien la {1} :", Madt, tien1);
            }
            else
            {
                tien2 = Soluongkhach * 80000;
                Console.WriteLine(" Ma doan tau : {0} Tien la  {1} :", Madt, tien2);
            }
        }
    }
}