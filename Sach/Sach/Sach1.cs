using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    public class Sach1
    {
        public string MaSach
        {
            get;
            set;

        }
        public string TenSach
        {
            get;
            set;
        }
        public string TenTG
        {
            get;
            set;
        }
        public int SoLuong
        {
            get;
            set;
        }
        public Sach1(string maSach, string tenSach, string tenTG, int soLuong)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TenTG = tenTG;
            SoLuong = soLuong;
        }
        
    }
}
