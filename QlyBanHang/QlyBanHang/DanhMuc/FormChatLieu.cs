using QlyBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyBanHang.DanhMuc
{
    public partial class FormChatLieu : Form
    {
        private DataProcesser dtBase = new DataProcesser();

        public FormChatLieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra người dùng nhập đủ dữ liệu chưa?
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã");
                txtMa.Focus();
                return;
            }

            //Kiểm tra trùng mã
            DataTable dtCL = dtBase.ReadData("Select * from tblChatLieu where MaChatLieu='" + txtMa.Text + "'");
            if (dtCL.Rows.Count > 0)
            {
                MessageBox.Show("Mã chất liệu đã có. Bạn hãy nhập mã khác");
                txtMa.Focus();
                return;
            }

            dtBase.ChangeData("Insert into tblChatLieu values('" + txtMa.Text + "',N'" + txtTen.Text + "')");
            MessageBox.Show("Thêm mới thành công");
            FormChatLieu_Load(sender, e);
        }

        private void FormChatLieu_Load(object sender, EventArgs e)
        {
            DataTable dtCL = new DataTable();
            dtCL = dtBase.ReadData("Select * from tChatLieu");

            dgvChatLieu.DataSource = dtCL;

            dgvChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            dgvChatLieu.Columns[1].HeaderText = "Tên chất liệu";       
        }

        private void dgvChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvChatLieu.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvChatLieu.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
