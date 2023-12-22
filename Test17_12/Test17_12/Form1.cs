using QuanLyKhachSan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test17_12
{
    public partial class Form1 : Form
    {
        private DataProcesser dtBase = new DataProcesser();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlHangHoa = "Select * from tblHang";
            DataTable dtHangHoa = dtBase.ReadData(sqlHangHoa);
            cbDuLieu.ValueMember = dtHangHoa.Columns["MaHang"].ToString();
            cbDuLieu.DisplayMember = dtHangHoa.Columns["TenHang"].ToString();
            cbDuLieu.DataSource = dtHangHoa;


            string sql = "Select tblHang.MaHang, TenHang, SoLuong, DonGiaBan, Thanhtien " +
                          "from tblHang inner join tblChiTietHDBan on tblHang.MaHang = tblChiTietHDBan.MaHang";
            DataTable dt = dtBase.ReadData(sql);
            dgvDuLieu.DataSource = dt;

        }

        private void hanghaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHD form2 = new FormHD();
            form2.Show();
            this.Visible = false;
        }
    }
}
