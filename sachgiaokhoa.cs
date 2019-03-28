using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Inheritance
{
    class sachgiaokhoa : Sach
    {
        String tinhtrang;
        

        public sachgiaokhoa() : base() {
            this.tinhtrang = "cu";
        }

        public new void Nhaptt()
        {
            base.Nhaptt();
            Console.WriteLine("Tinh trang cua sach Cu / Moi: ");
            this.tinhtrang = Console.ReadLine();
        }

        public double tinhtien() {
            double thanhtien;
            if ( tinhtrang == "cu")
            
                thanhtien = this.dongia * this.soluong * 0.5;
            
            else
            
                thanhtien = this.dongia * this.soluong;
            
            return thanhtien;
        }

         public void In()
        {
            base.In();
            Console.WriteLine(" Gia Sach La: {0} ", this.tinhtien());
        }
     
    }
}
