using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KH_GuiTK
{
    internal class NguoiGui
    {
        public NguoiGui() { }
        public NguoiGui(string maKh, string tenKH, string diaChi, string ngayGui, int tienGui, string thoiGianGui, double tienLai)
        {         
                this.maKh = maKh;
                this.tenKH = tenKH;
                this.diaChi = diaChi;
                this.ngayGui = ngayGui;
                this.tienGui = tienGui;
                this.thoiGianGui = thoiGianGui;
                this.tienLai = tienLai;
        }
        public string maKh { get; set; }
        public string tenKH { get; set; }
        public string diaChi { get; set; }
        public string ngayGui { get; set; }
        public int tienGui { get; set; }
        public string thoiGianGui { get; set; }
        public double tienLai { get; set; }

    }
}
