using QLBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh5
{
    public partial class FormDangNhap : Form
    {
        private DataProcesser dtBase = new DataProcesser();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sqlSearch = String.Format("Select * from tUser where Username = N'{0}' and Pass = N'{1}'", txtUser.Text, txtPass.Text);
            DataTable dtCL = new DataTable();
            dtCL = dtBase.ReadData(sqlSearch);
            if(dtCL.Rows.Count < 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản không chính xác");
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
            else
            {
                Form1 form = new Form1(txtUser.Text);
                this.Visible = false;
                form.Show();

            }
                
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();   
            }
        }
    }
}
