using QLBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        private DataProcesser dtBase = new DataProcesser();
        public Form1()
        {
            InitializeComponent();
        }

        private void HienChiTiet(bool hien)
        {
            txt_ChiTietMa.Enabled = hien;
            txt_ChiTietTen.Enabled = hien;
            dateHH.Enabled = hien;
            dateSX.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btn_Luu.Enabled = hien;
            btn_Huy.Enabled = hien;
        }

        private void HienDuLieu()
        {
            txt_ChiTietMa.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txt_ChiTietTen.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            dateSX.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            dateHH.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            txtDonVi.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            lblTieuDe.Text = "TÌM KIẾM MẶT HÀNG";
            DataTable dtCL = new DataTable();
            string sqlSearch = String.Format("Select * from tMatHang where MaSanPham = N'{0}' or TenSanPham = N'{1}'", txtMa.Text, txtTen.Text);
            dtCL = dtBase.ReadData(sqlSearch);
            dgvSanPham.Columns[0].HeaderText = "Mã SP";
            dgvSanPham.Columns[1].HeaderText = "Tên SP";
            dgvSanPham.Columns[2].HeaderText = "Ngày SX";
            dgvSanPham.Columns[3].HeaderText = "Ngày HH";
            dgvSanPham.Columns[4].HeaderText = "Đơn Vi";
            dgvSanPham.Columns[5].HeaderText = "Đơn Giá";
            dgvSanPham.BackgroundColor = Color.LightPink;
            dgvSanPham.DataSource = dtCL;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienChiTiet(false);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            DataTable dtCL = new DataTable();
            dtCL = dtBase.ReadData("Select * from tMatHang");
            dgvSanPham.DataSource = dtCL;
            dgvSanPham.Columns[0].HeaderText = "Mã SP";
            dgvSanPham.Columns[1].HeaderText = "Tên SP";
            dgvSanPham.Columns[2].HeaderText = "Ngày SX";
            dgvSanPham.Columns[3].HeaderText = "Ngày HH";
            dgvSanPham.Columns[4].HeaderText = "Đơn Vi";
            dgvSanPham.Columns[5].HeaderText = "Đơn Giá";
            dgvSanPham.BackgroundColor = Color.LightPink;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM MẶT HÀNG MỚI";
            btn_Luu.Text = "Lưu";
            HienChiTiet(true);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            foreach (Control control in groupChiTiet.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
            txt_ChiTietMa.Focus();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "CẬP NHẬT MẶT HÀNG";
            btn_Luu.Text = "Lưu";
            HienChiTiet(true);
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            HienDuLieu();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupChiTiet.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
            lblTieuDe.Text = "QUẢN LÝ SẢN PHẨM";
            HienChiTiet(false);
            btn_Sua.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = false;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "XÓA MẶT HÀNG";
            btn_Luu.Text = "Xóa";
            btn_Sua.Enabled = false;
            btn_Them.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            HienDuLieu();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            if(btn_Them.Enabled == true)
            {
                if (txt_ChiTietMa.Text.Trim() == "")
                {
                    errChiTiet.SetError(txt_ChiTietMa, "Bạn không để trống mã sản phẩm trường này!");
                    return;
                }
                else
                { //Kiểm tra xem mã sản phẩm đã tồn tại chưa đẻ tránh
                    string sql = String.Format("Select * From tMathang Where MaSanPham = N'{0}'", txt_ChiTietMa.Text);
                    DataTable dtSP = dtBase.ReadData(sql);
                    if (dtSP.Rows.Count > 0)
                    {
                        errChiTiet.SetError(txt_ChiTietMa, "Mã sản phẩm trùng trong cơ sở dữ liệu");
                        return;
                    }
                    errChiTiet.Clear();
                }
                //Kiểm tra tên sản phầm có bị để trống không
            }
            if (txt_ChiTietTen.Text.Trim() == "")
            {
                errChiTiet.SetError(txt_ChiTietTen, "Bạn không để trống tên sản phẩm!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra ngày sản xuất, lỗi nếu người sử dụng nhập vào ngày sản xuất lớn hơn ngày hiện tại         
            if (dateSX.Value > DateTime.Now)
            {
                errChiTiet.SetError(dateSX, "Ngày sản xuất không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra ngày hết hạn xem có lớn hơn ngày sản xuất không
            if (dateSX.Value < dateHH.Value)
            {
                errChiTiet.SetError(dateHH, "Ngay hết hạn nhỏ hơn ngày sản xuất!");             
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra đơn vị xem có để trống không
            if (txtDonVi.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDonVi, "Bạn không để trống đơn vi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra đơn giá
            if (txtDonGia.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDonGia, "Bạn không để trống đơn giá!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            // Thêm sửa xóa dữ liệu
            if (btn_Them.Enabled == true)
                {
                    string sqlInsert = String.Format("Insert into tMathang Values (N'{0}', N'{1}', '{2}', '{3}', N'{4}', {5}, N'{6}')"
                                    , txt_ChiTietMa.Text, txt_ChiTietTen.Text, dateSX.Text, dateHH.Text, txtDonVi.Text, Int32.Parse(txtDonGia.Text), txtGhiChu.Text);
                    dtBase.ChangeData(sqlInsert);
                    MessageBox.Show("Thêm thành công sản phẩm");
                }

            if (btn_Sua.Enabled == true)
            {
                string sqlUpdate = String.Format("Update tMathang set MaSanPham = N'{0}', TenSanPham =  N'{1}', NgaySX = '{2}', NgayHH = '{3}',Donvi =  N'{4}', DonGia =  {5}, GhiChu = N'{6}' where MaSanPham = N'{0}'"
                                , txt_ChiTietMa.Text, txt_ChiTietTen.Text, dateSX.Text, dateHH.Text, txtDonVi.Text, Int32.Parse(txtDonGia.Text), txtGhiChu.Text);
                dtBase.ChangeData(sqlUpdate);
                MessageBox.Show("Sửa thành công sản phẩm");
            }
            if (btn_Xoa.Enabled == true)
            {
                string sqlDelete = String.Format("Delete from tMathang  where MaSanPham = N'{0}'"
                                , txt_ChiTietMa.Text);
                dtBase.ChangeData(sqlDelete);
                MessageBox.Show("Xóa thành công sản phẩm");
                btn_Them.Enabled = true;
                lblTieuDe.Text = "QUẢN LÝ SẢN PHẨM";

            }
            Form1_Load(sender, e);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
