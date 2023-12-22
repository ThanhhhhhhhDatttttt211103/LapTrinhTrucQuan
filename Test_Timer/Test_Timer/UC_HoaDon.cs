using QuanLyKhachSan.Classes;
using QuanLyKhachSan.Home;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace QuanLyKhachSan.User_Controls
{
    public partial class UC_HoaDon : UserControl
	{
		private DataProcesser dtbase = new DataProcesser();
		private FormHoaDon that = new FormHoaDon();
		private string maPhieuDat;
		public UC_HoaDon()
		{
			InitializeComponent();
		}
		public UC_HoaDon(string maPhieuDat)
		{
			this.maPhieuDat = maPhieuDat;
			InitializeComponent();
		}
		public UC_HoaDon(FormHoaDon that, string maPhieuDat)
		{
			this.that = that;
			this.maPhieuDat = maPhieuDat;
		}

		private void UC_HoaDon_Load(object sender, EventArgs e)
		{
			string sql = string.Format("select tKhachHang.MaKhachHang, tKhachHang.TenKhachHang, tKhachHang.DiaChi, tKhachHang.DienThoai, tKhachHang.CCCD, tPhong.MaPhong, tPhieuDat.NgayDenDuKien, tPhieuDat.NgayDiDuKien," +
				" tPhieuDat.MaPhieuDat, tHoaDon.MaHoaDon, ((DATEDIFF(day,tPhieuDat.NgayDenDuKien,tPhieuDat.NgayDiDuKien)) * tPhong.DonGiaPhong) as TienPhong, tChiTietSanPham.ThanhTien, tHoaDon.TongTien " +
				"from tKhachHang " +
				"inner join tPhieuDat on tKhachHang.MaKhachHang = tPhieuDat.MaKhachHang " +
				"inner join tChiTietPhongDat on tPhieuDat.MaPhieuDat = tChiTietPhongDat.MaPhieuDat " +
				"inner join tPhong on tChiTietPhongDat.MaPhong = tPhong.MaPhong " +
				"inner join tHoaDon on tPhieuDat.MaPhieuDat = tHoaDon.MaPhieuDat " +
				"inner join tPhieuThue on tPhieuDat.MaPhieuDat = tPhieuThue.MaPhieuDat " +
				"inner join tChiTietSanPham on tPhieuThue.MaPhieuThue = tChiTietSanPham.MaPhieuThue where tPhieuDat.MaPhieuDat = N'{0}'",maPhieuDat);
			DataTable dt = dtbase.ReadData(sql);
			List<DataRow> list = dt.Select().ToList();
			foreach (var item in list)
			{
				lbHoTen.Text = item.Field<string>("TenKhachHang").ToString();
				lbmakh.Text = item.Field<string>("MaKhachHang").ToString();
				lbDiaChi.Text = item.Field<string>("DiaChi").ToString();
				lbSDT.Text = item.Field<string>("DienThoai").ToString();
				lbCCCD.Text = item.Field<string>("CCCD").ToString();
				lbSoPhong.Text = item.Field<string>("MaPhong").ToString();
				lbNgayDen.Text = item.Field<DateTime>("NgayDenDuKien").ToString("dd-MM-yyyy");
				lbNgayDi.Text = item.Field<DateTime>("NgayDiDuKien").ToString("dd-MM-yyyy");
				lbMaPhieuThue.Text = item.Field<string>("MaPhieuDat").ToString();
				lbmahoadon.Text = item.Field<string>("MaHoaDon").ToString();
				lbTienPhong.Text = item.Field<int>("TienPhong").ToString();
				lbTienDichVu.Text = item.Field<int>("ThanhTien").ToString();
				lbTongTien.Text = item.Field<int>("TongTien").ToString();
				
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}

		private void btnXuatexcel_Click(object sender, EventArgs e)
		{
			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
			Excel.Range exRange = (Excel.Range)exSheet.Cells[2, 3];
			exSheet.Range["D1"].Value = "HDATAZ Hotel";
			exSheet.Range["D1"].Font.Size = 22;
			exSheet.Range["D1"].Font.Bold = true;
			exSheet.Range["D1"].Font.Color= Color.Red;

			Excel.Range TieuDe = (Excel.Range)exSheet.Cells[3, 2];
			exRange.Font.Size = 20;
			exRange.Font.Bold = true;
			exRange.Font.Color = Color.Green;
			exRange.Value = "Hóa đơn thanh toán dịch vụ";

			exSheet.Range["B6:H20"].Font.Size = 14;
			exSheet.Range["B6"].Value = "Họ và tên: " + lbHoTen.Text;
			exSheet.Range["B7"].Value = "Mã khách hàng: " + lbmakh.Text;
			exSheet.Range["B8"].Value = "Địa chỉ: " + lbDiaChi.Text;
			exSheet.Range["B9"].Value = "SĐT: " + lbSDT.Text;
			exSheet.Range["B10"].Value = "CCCD: " + lbCCCD.Text;
			exSheet.Range["G6"].Value = "Số phòng: " + lbSoPhong.Text;
			exSheet.Range["G7"].Value = "Ngày đến: " + lbNgayDen.Text;
			exSheet.Range["G8"].Value = "Ngày đi: " + lbNgayDi.Text;
			exSheet.Range["G9"].Value = "Mã phiếu thuê: " + lbMaPhieuThue.Text;
			exSheet.Range["G10"].Value = "Mã HĐ: " + lbmahoadon.Text;
			exSheet.Range["F13"].Value = "CHI TIẾT";
			exSheet.Range["H13"].Value = "SỐ TIỀN";
			exSheet.Range["F14"].Value = "Tiền dịch vụ:";
			exSheet.Range["F15"].Value = "Tiền phòng:";
			exSheet.Range["F16"].Value = "Tổng cộng:";
			int dong = 14;
			//exSheet.Range["H14"].Value = lbTienDichVu.Text;
			//exSheet.Range["H15"].Value = lbTienPhong.Text;
			//exSheet.Range["H16"].Value = lbTongTien.Text;
			exSheet.Range["H" + dong.ToString()].Value = lbTienDichVu.Text + " đồng";
			int dong1 = 15;
			exSheet.Range["H" + dong1.ToString()].Value = lbTienPhong.Text + " đồng";
			int dong2 = 16;
			exSheet.Range["H" + dong2.ToString()].Value = lbTongTien.Text + " đồng";
			exSheet.Range["B15"].Value = "Thu Ngân";
			exSheet.Range["D15"].Value = "Khách";
			exSheet.Range["B18"].Value = "Địa chỉ: Số 3 Cầu Giấy, Láng Thượng,Đống Đa,Hà Nội";
			exSheet.Range["B19"].Value = "Điện thoại: 19001550";
			exSheet.Name = "Hóa Đơn Bán";
			exBook.Activate();
			//Lưu file
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Excel 97-2022 Workbook|*.xls|Excel Workbook|*.xlsx|All Files|*.*";
			save.FilterIndex = 2;
			if(save.ShowDialog() == DialogResult.OK)
			{
				exBook.SaveAs(save.FileName.ToLower());
			}
			exApp.Quit();
		}
	}
}
