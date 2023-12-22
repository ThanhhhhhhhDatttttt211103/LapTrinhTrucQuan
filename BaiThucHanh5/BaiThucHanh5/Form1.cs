using QLBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh5
{
    public partial class Form1 : Form
    {
        string name;
        private DataProcesser dtBase = new DataProcesser();
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string name)
        {
            InitializeComponent();
            this.name = name;
            label2.Text = label2.Text + " " + name;
        }

        private void LamMoi()
        {
            foreach (Control control in DuLieu.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        public void load_cb()
        {
            string sql = String.Format("Select * From tChatLieu");
            DataTable dtSP = dtBase.ReadData(sql);
            cbChatLieu.ValueMember = dtSP.Columns["MaChatLieu"].ToString();
            cbChatLieu.DisplayMember = dtSP.Columns["TenChatLieu"].ToString();
            cbChatLieu.DataSource = dtSP;
        }
       

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFie = new OpenFileDialog();
            openFie.Filter = "JPEG images|*.jpg|Bitmap images|*.bmp|All Filtes|*.*";
            openFie.FilterIndex = 1;
            if (openFie.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = Image.FromFile(openFie.FileName);           
                fileName = openFie.SafeFileName;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_cb();
            DataTable dtCL = new DataTable();
            dtCL = dtBase.ReadData("Select * from tHang");
            dgvSanPham.DataSource = dtCL;
            dgvSanPham.Columns[0].HeaderText = "Mã SP";
            dgvSanPham.Columns[1].HeaderText = "Tên SP";
            dgvSanPham.Columns[2].HeaderText = "Chất liệu";
            dgvSanPham.Columns[3].HeaderText = "Số lượng";
            dgvSanPham.Columns[4].HeaderText = "Đơn giá nhập";
            dgvSanPham.Columns[5].HeaderText = "Đơn giá bán" ;
            dgvSanPham.Columns[6].HeaderText = "Ghi chú";
            dgvSanPham.Columns[7].HeaderText = "Ảnh";
            dgvSanPham.BackgroundColor = Color.LightPink;

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            cbChatLieu.SelectedValue = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            txtGiaNhap.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
            txtGiaBan.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            txtGhiChu.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
            string nameImage = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
            if(nameImage == "")
            {
                
            }
            else
                picBox.Image =  Image.FromFile(Application.StartupPath + "\\" + nameImage);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi          
            if (txtMa.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMa, "Bạn không để trống mã sản phẩm trường này!");
                return;
            }
            else
            { 
                errChiTiet.Clear();
            }
            //Kiểm tra tên sản phầm có bị để trống không            
            if (txtTen.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTen, "Bạn không để trống tên sản phẩm!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra ngày hết hạn xem có lớn hơn ngày sản xuất không
            if (txtGiaNhap.Text.Trim() == "")
            {
                errChiTiet.SetError(txtGiaNhap, "Ngay hết hạn nhỏ hơn ngày sản xuất!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra đơn vị xem có để trống không
            if (txtGiaBan.Text.Trim() == "")
            {
                errChiTiet.SetError(txtGiaBan, "Bạn không để trống đơn vi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            string sqlUpdate = String.Format("Update tHang set TenHang =  N'{1}', MaChatLieu = '{2}', SoLuong = '{3}',DonGiaNhap =  {4}, DonGaiBan =  {5}, GhiChu = N'{6}',Anh = N'{7}'  where MaHang = N'{0}'"
                               , txtMa.Text, txtTen.Text, cbChatLieu.SelectedValue, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaNhap.Text), Int32.Parse(txtGiaBan.Text), txtGhiChu.Text, fileName);
            dtBase.ChangeData(sqlUpdate);
            MessageBox.Show("Sửa thành công sản phẩm");
            Form1_Load(sender, e);
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = String.Format("Delete from tHang  where MaHang = N'{0}'"
                , txtMa.Text);
            dtBase.ChangeData(sqlDelete);
            MessageBox.Show("Xóa thành công sản phẩm");
            Form1_Load(sender, e);
            LamMoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi          
            if (txtMa.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMa, "Bạn không để trống mã sản phẩm trường này!");
                return;
            }
            else
            { //Kiểm tra xem mã sản phẩm đã tồn tại chưa đẻ tránh
                string sql = String.Format("Select * From tHang Where MaHang = N'{0}'", txtMa.Text);
                DataTable dtSP = dtBase.ReadData(sql);
                if (dtSP.Rows.Count > 0)
                {
                    errChiTiet.SetError(txtMa, "Mã sản phẩm trùng trong cơ sở dữ liệu");
                    return;
                }
                errChiTiet.Clear();
            }
            //Kiểm tra tên sản phầm có bị để trống không            
            if (txtTen.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTen, "Bạn không để trống tên sản phẩm!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra ngày hết hạn xem có lớn hơn ngày sản xuất không
            if (txtGiaNhap.Text.Trim() == "")
            {
                errChiTiet.SetError(txtGiaNhap, "Ngay hết hạn nhỏ hơn ngày sản xuất!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra đơn vị xem có để trống không
            if (txtGiaBan.Text.Trim() == "")
            {
                errChiTiet.SetError(txtGiaBan, "Bạn không để trống đơn vi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            string sqlInsert = String.Format("Insert into tHang Values (N'{0}', N'{1}', '{2}', '{3}', N'{4}', {5}, N'{6}', N'{7}')"
                                     , txtMa.Text, txtTen.Text, cbChatLieu.SelectedValue, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaNhap.Text), Int32.Parse(txtGiaBan.Text), txtGhiChu.Text, fileName);
            dtBase.ChangeData(sqlInsert);
            MessageBox.Show("Thêm thành công sản phẩm");
            Form1_Load(sender, e);
            LamMoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormDangNhap formDN = new FormDangNhap();
                formDN.Show();
                this.Visible = false;
            }
                
        }

    }
}
