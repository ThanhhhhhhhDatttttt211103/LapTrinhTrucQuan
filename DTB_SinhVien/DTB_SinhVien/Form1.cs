using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DTB_SinhVien
{
    public partial class Form1 : Form
    {
        private List<MonHoc> monHocList = new List<MonHoc>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            listMon.Items.Add(cbMon.Text + " | " + txtTinChi.Text + " | " +
                    txtDiem.Text);
            MonHoc monHoc = new MonHoc(cbMon.Text, Int32.Parse(txtTinChi.Text), Int32.Parse(txtDiem.Text));
            monHocList.Add(monHoc);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int tongTin = 0, tongDiem = 0; 
            double diemTB = 0;
            foreach(var item in monHocList)
            {
                tongTin += item.tinchi;
                tongDiem += (item.diem * item.tinchi);             
            }
            diemTB = (double)tongDiem / tongTin;

            txtTongTin.Text = tongTin.ToString();
            txtTongDiem.Text = tongDiem.ToString();
            txtDTB.Text = diemTB.ToString("F2");
        }
        private void ChonItem(object sender, EventArgs e)
        {
            if (cbMon.SelectedIndex == 0)          
                txtTinChi.Text = "2";
            else if(cbMon.SelectedIndex == 1)
                txtTinChi.Text = "3";
             else if (cbMon.SelectedIndex == 2)            
                txtTinChi.Text = "3";
             else if (cbMon.SelectedIndex == 3)           
                txtTinChi.Text = "2";
             else if (cbMon.SelectedIndex == 4)
                txtTinChi.Text = "3";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
