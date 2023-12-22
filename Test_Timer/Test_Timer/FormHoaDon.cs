using QuanLyKhachSan.Classes;
using QuanLyKhachSan.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Home
{
    public partial class FormHoaDon : Form
    {
        private DataProcesser dtbase = new DataProcesser();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void btnLeftMenu_Click(object sender, EventArgs e)
        {
            //LeftMenu leftMenu1 = new LeftMenu();
            //this.Controls.Add(leftMenu1);
            //leftMenu1.Visible = false;
            //leftMenu1.BringToFront();
            //leftMenu1.Width = 260;
            //transactionLeftMenu.ShowSync(leftMenu1);
        }

		private void grvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            string maphieudat = grvHoaDon.CurrentRow.Cells["MaPhieuDat"].Value.ToString();
			UC_HoaDon ucHoaDon = new UC_HoaDon(maphieudat);
			ucHoaDon.Location = new Point(250, 5);
			this.Controls.Add(ucHoaDon);
			ucHoaDon.BringToFront();
		}

		private void FormHoaDon_Load(object sender, EventArgs e)
		{
            string sql = string.Format("Select * from tHoaDon");
            DataTable dt = dtbase.ReadData(sql);
            grvHoaDon.RowTemplate.Height += 15;
            grvHoaDon.DataSource = dt;
            grvHoaDon.AllowUserToAddRows = false;

   //         string sql2 = string.Format("Select tKhachHang.MaKhachHang,TenKhachHang,NgaySinh,GioiTinh,DiaChi,CCCD,MaPhieuDat,NgayDenDuKien,NgayDiDuKien from tKhachHang inner join tPhieuDat on tKhachHang.MaKhachHang = tPhieuDat.MaKhachHang");
			//DataTable dt2 = dtbase.ReadData(sql2);
			//grvThongTin.RowTemplate.Height += 15;
			//grvThongTin.DataSource = dt2;
			//grvThongTin.AllowUserToAddRows = false;

   //         grvThongTin.Columns["TenKhachHang"].Width = 150;
		}

		private void txtSearchHD_TextChanged(object sender, EventArgs e)
		{
            string sql = string.Format("select MaHoaDon, MaNhanVien, MaPhieuDat, NgayLapHoaDon from tHoaDon " +
				"where MaHoaDon like '%{0}%' or MaNhanVien like '%{0}%' or MaPhieuDat like '%{0}%' or NgayLapHoaDon like '%{0}%'",txtSearchHD.Text);
            DataTable dt = dtbase.ReadData(sql);
            grvHoaDon.DataSource = dt;
		}

		private void ThoiGianHoaDon_ValueChanged(object sender, EventArgs e)
		{
			string ngayHoaDon = dtThoiGianHoaDon.Value.ToString("dd-MM-yyyy");
			LoadHoaDon(ngayHoaDon);
		}
		public void LoadHoaDon(string date)
        {
			string sql = string.Format("select MaHoaDon, MaNhanVien, MaPhieuDat, TongTien, NgayLapHoaDon, GhiChu from tHoaDon where NgayLapHoaDon like ${0}", date);
			DataTable dt = dtbase.ReadData(sql);
			grvHoaDon.DataSource = dt;
		}
	}
}
