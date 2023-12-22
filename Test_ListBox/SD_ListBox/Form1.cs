using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SD_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsHang_DoubleClick(object sender, EventArgs e)
        {
            int i;
            //1. Lấy ra sản phẩm được chọn
            string book = lsHang.SelectedItem.ToString();
            //2. Kiểm tra sản phẩm book đã có trong giỏ hàng chưa
            for(i  = 0; i < ls_GioHang.Items.Count; i++) {
                if(book == ls_GioHang.Items[i].ToString())
                {
                    MessageBox.Show("Bạn đã mua cuốn " + book + " rồi");
                    break;
                }
            }
            if(i == ls_GioHang.Items.Count)
            {
                ls_GioHang.Items.Add(book);
            }
        }

        private void ls_GioHang_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                if (ls_GioHang.SelectedItem != null)
                {
                    string book = ls_GioHang.SelectedItem.ToString();
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ls_GioHang.Items.Remove(book);
                    }
                }
                else
                {
                    MessageBox.Show("Không có sách nào trong danh sách");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lỗi xảy ra khi xóa sách");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phuongThuc = "";
            string lienLac = "";
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ và tên");
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Số điện thoại");
                return;
            }
            try
            {
                int.Parse(txtDienThoai.Text);

            }
            catch(FormatException)
            {
                MessageBox.Show("Số điện thoại phải là số nguyên");
                return;
            }

            if (ls_GioHang.Items.Count <1)
            {
                MessageBox.Show("Chưa có sách nào");
                return;
            }

                foreach (Control control in grbPhuongThuc.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                {
                    phuongThuc = radioButton.Text;
                    break;
                }
            }

            foreach (Control control in grbLienLac.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                   lienLac +=  checkBox.Text + " ";
                }
            }

            string danhSach = "";

            foreach (object item in ls_GioHang.Items)
            {
                danhSach += item.ToString() + "\n";
            }





            MessageBox.Show(txtHoTen.Text + "\nSố điện thoại: " + txtDienThoai.Text + "\nPhương thức thanh toán: " + phuongThuc + "\nHình thức liên lạc: " + lienLac + "\nDanh sách mua hàng: \n" + danhSach);
                ;
        }
    }
}
