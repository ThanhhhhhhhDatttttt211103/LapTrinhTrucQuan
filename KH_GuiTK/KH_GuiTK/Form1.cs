using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KH_GuiTK
{
    public partial class Form1 : Form
    {
        private List<NguoiGui> listNguoiGui = new List<NguoiGui>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTime.Items.Add("1");
            cbTime.Items.Add("3");
            cbTime.Items.Add("6");
            cbTime.Items.Add("12");
        }

        private void btnThemVao_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (txtMa.TextLength < 6)
            {
                MessageBox.Show("Nhập lại vì mã < 6");
                kt = 0;
            }
            if (txtDiaChi.TextLength == 0 || txtTen.TextLength == 0)
            {
                MessageBox.Show("Nhập lại vì tên hoặc địa chỉ rỗng");
                kt = 0;
            }

            double tienlai = 0;
            if (kt == 1)
            {
                if (rdoThuong.Checked == true)
                {
                    if (cbTime.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.06;

                    }
                    if (cbTime.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.07;

                    }
                    if (cbTime.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.08;

                    }
                    if (cbTime.SelectedItem == "12")
                    {
                        tienlai = Convert.ToDouble(txtTien.Text) * 0.09;
                    }
                }
                else if (rdoPhatLoc.Checked == true)
                {
                    if (cbTime.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.07;

                    }
                    if (cbTime.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.08;

                    }
                    if (cbTime.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.09;

                    }
                    if (cbTime.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(txtTien.Text) * 0.1;

                    }
                }
                lbDanhSach.Items.Add(txtMa.Text + " | " + txtTen.Text + " | " +
                    txtDiaChi.Text
                    + " | " + ngayGui.Text + " | " + txtTien.Text + " | "
                    + cbTime.Text + " tháng | " + tienlai);
                }
            listNguoiGui.Add(new NguoiGui(txtMa.Text, txtTen.Text, txtDiaChi.Text, ngayGui.Text,Int32.Parse(txtTien.Text), cbTime.Text + " Tháng", tienlai));

            
            }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtTien.Text = "";
            ngayGui.Text = "";
            cbTime.Text = "";
            cbTime.SelectedIndex = -1;
            rdoThuong.Checked = false;
            rdoPhatLoc.Checked = false;

        }

        private void MaKH_TienKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiem FormTK = new FormTimKiem(listNguoiGui);
            FormTK.Show();

        }
    }
}
