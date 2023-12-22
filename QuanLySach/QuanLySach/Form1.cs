using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class Form1 : Form
    {
        private List<SachBoSung> ds = new List<SachBoSung>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            string maSach, tenSach, tenTacGia, maQR;
            int soLuong;

            maSach = txt_MaSach.Text;
            tenSach = txt_TenSach.Text;
            tenTacGia = txt_TacGia.Text;
            maQR = txt_MaQR.Text;
            soLuong = int.Parse(txt_SoLuong.Text);
            SachBoSung book = new SachBoSung(maSach, tenSach, tenTacGia, soLuong, maQR);
            ds.Add(book);

            table.DataSource = null;  // Xóa nguồn dữ liệu hiện tại của DataGridView
            table.DataSource = ds;    // Gán lại nguồn dữ liệu cho DataGridView

            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            txt_TacGia.Text = "";
            txt_MaQR.Text = "";
            txt_SoLuong.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string ma = txt_Search.Text;
            for(int i  = 0; i < ds.Count(); i ++ ) {
                if (ds[i].getMaSach().Equals(ma))
                    txt_Ton.Text = Convert.ToString(ds[i].getSoLuong());
            }
        }
    }
}
