using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_OOP
{
    internal class HinhChuNhat
    {
        private float dai, rong;

        public HinhChuNhat(HinhChuNhat h1)
        {
            this.dai = h1.dai;
            this.rong = h1.rong;
        }

        public HinhChuNhat(float dai, float rong) { this.dai = dai; this.rong = rong; }

        public HinhChuNhat()
        {
            dai = 0;
            rong = 0;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap chieu dai: ");
            dai = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            rong = float.Parse(Console.ReadLine());
        }

        public float dienTich()
        {
            float dTich = dai * rong;
            return dTich;
        }

        public float chuVi()
        {
            float cVi = (dai + rong) * 2;
            return cVi;
        }


    }
}
