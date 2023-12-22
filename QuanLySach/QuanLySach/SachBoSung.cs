using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class SachBoSung : Sach
    {
        private string maQR;

        public SachBoSung() : base()
        {
        }

        public SachBoSung(string maSach, string tenSach, string tenTacGia, int soLuong, string maQR) : base(maSach, tenSach, tenTacGia, soLuong)
        {
            this.maQR = maQR;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ma QR: ");
            maQR = Console.ReadLine();
        }
    }
}
