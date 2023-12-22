using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class Sach
    {
        private string maSach, tenSach, tenTacGia;
        private int soLuong;

        public Sach()
        {

        }

        public Sach(string maSach, string tenSach, string tenTacGia, int soLuong)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tenTacGia = tenTacGia;
            this.soLuong = soLuong;
        }

        public string getMaSach()
        {
            return maSach;
        }

        public int getSoLuong()
        {
            return soLuong;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma sach: ");
            maSach = Console.ReadLine();
            Console.WriteLine("Nhap ten sach: ");
            tenSach = Console.ReadLine();
            Console.WriteLine("Nhap ten tac gia: ");
            tenTacGia = Console.ReadLine();
            Console.WriteLine("Nhap so luong: ");
            soLuong = int.Parse(Console.ReadLine());
        }

    }
}
