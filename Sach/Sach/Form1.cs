using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sach
{
    public partial class Form1 : Form
    {
        List<SachMoi> lstSach = new List<SachMoi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SachMoi book;
            string mS, tS, TG, qrCode;
            int SL;

            mS=txtMaS.Text;
            tS = txtTenS.Text;
            SL = int.Parse(txtSoLuong.Text);
            TG = txtTacGia.Text;
            qrCode = txtQrCode.Text;
            book = new SachMoi(mS, tS, TG, SL, qrCode);
            lstSach.Add(book);
            //Thêm dữ liệu vào dgvSach
           dgvSach.DataSource = null;
           dgvSach.DataSource = lstSach;
            
            

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int i;
            string qrCode=txtQrCode.Text;
            for(i=0;i<lstSach.Count;i++)
            {
                if(qrCode == lstSach[i].QrCode)
                {
                    MessageBox.Show("Sách có qrCode là " + qrCode + "còn " +
                        lstSach[i].SoLuong);
                    break;
                }    
            } 
            if(i==lstSach.Count)
            {
                MessageBox.Show("Không tìm thấy sách có qrCode là" + qrCode);
            }    
        }
    }
}
