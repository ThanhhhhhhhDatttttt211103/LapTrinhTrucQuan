using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_P_HinhTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            Tinh();
        }

        private void btn_LamLai_Click(object sender, EventArgs e)
        {
            txtDienTich.Text = " ";
            txt_BanKinh.Text = " ";
            txt_ChuVi.Text = " ";
            txt_BanKinh.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void Tinh()
        {
            txt_ChuVi.Text = (2 * Math.PI * double.Parse(txt_BanKinh.Text)).ToString("F3");
            txtDienTich.Text = (Math.PI * double.Parse(txt_BanKinh.Text) * double.Parse(txt_BanKinh.Text)).ToString("F3");
        }

        private void txt_BanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Tinh();
            }
        }
    }
}
