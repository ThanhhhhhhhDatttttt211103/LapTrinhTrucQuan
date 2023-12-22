using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float dai, rong;
            dai = float.Parse(txt_dai.Text);
            rong = float.Parse(txt_rong.Text);
            HinhChuNhat h = new HinhChuNhat(dai, rong);
            lbl_chuvi.Text = "Chu vi: " + h.chuVi();
            lbl_dientich.Text = "Diện tích: " + h.dienTich();

        }
    }
}
