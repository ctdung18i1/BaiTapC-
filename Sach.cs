﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Inheritance
{

    //1.	. Cài đặt một lớp Sách gồm: - Các thuộc tính: mã sách, ngày nhập, đơn giá, số lượng - Hàm dựng mặc định, 
    //- Hàm dựng có tham số truyền vào  
    //- Phương thức hiển thị để in ra màn hình mã sách, ngày nhập, đơn giá, số lượng  
    /*  b. Cài đặt một lớp SachGiaoKhoa thừa kế từ lớp Sach trên và có thêm 
      - Thuộc tính: tình trạng sách (mới, cũ) 
      - Hàm dựng mặc định của lớp SachGiaoKhoa 
      - Hàm dựng có tham số truyền vào 
      - Phương thức tính tiền sách đất với công thức như sau: 	
      Nếu tình trạng sách là mới thì thành tiền = số lượng*đơn giá 	Nếu tình trạng sách là cũ thì thành tiền = số lượng*đơn giá*50% 
      - In ra màn hình mã sách giáo khoa và thành tiền của sách đó. 
      c. Cài đặt lớp SachMain để thực hiện:
      Nhập danh sách cho SachGiaoKhoa */
    class Sach
    {
      protected String masach;
      protected string ngaynhap;
      protected double dongia;
      protected double soluong;
        public Sach()
        {
            this.masach = "ABC";
            this.ngaynhap = "20/02/2019";
            this.dongia = 70000;
            this.soluong = 50;
        }
    public void Nhaptt()
        {
            Console.WriteLine(" Nhap vao ma sach:");
            this.masach = Console.ReadLine();
            Console.WriteLine(" Ngay nhap sach:");
            this.ngaynhap = Console.ReadLine();
            Console.WriteLine(" Nhap vao don gia:");
            this.dongia = double.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap vao so luong sach:");
            this.soluong = double.Parse(Console.ReadLine());
        }
    public void In()
        {
            Console.WriteLine(" thong tin cua sach la:\n Ma Sach: {0} \n Ngay Nhap: {1} \n  Don Gia: {2}\n So Luong: {3}", this.masach, this.ngaynhap,this.dongia,this.soluong);
        }
    }
}
