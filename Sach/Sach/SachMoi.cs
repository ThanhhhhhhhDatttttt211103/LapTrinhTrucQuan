﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    public class SachMoi:Sach1
    {
        public string QrCode
        {
            get;
            set;
        }
        public SachMoi(string maSach, string tenSach, string tenTG, 
            int soLuong,string qrCode):base(maSach,tenSach,tenTG,soLuong)
        {
            QrCode = qrCode;
        }
       
    }
}
