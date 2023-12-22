using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTB_SinhVien
{
    internal class MonHoc
    {
        public MonHoc() { }

        public MonHoc(string name, int tinchi, int diem)
        {
            this.name = name;
            this.tinchi = tinchi;
            this.diem = diem;
        }

        public string name { get; set; }
        public int tinchi { get; set; }
        public int diem { get; set; }

    }
}
