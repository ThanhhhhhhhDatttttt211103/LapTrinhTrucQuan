using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BTTiengAnh
{
    public partial class FormDienTu1 : Form
    {
        private BaiTapDienTu bt1;

        public FormDienTu1()
        {
            InitializeComponent();
        }

        private void FormDienTu1_Load(object sender, EventArgs e)
        {
            bt1 = new BaiTapDienTu();
            bt1.DeBai = "My grandfather was born in China. He cane from a very poor family and was (1)______ of seven children. His parents lived (2)______ a samll farm. " +
                "He didn't have a very good education. At the age of 17 he (3)______ home. First he went to Shanghai and (4)______ he went to Hong Kong. " +
                "He worded (5)______ a waiter and then as a cook. When he was 21, he (6)______ my grandmother and had four children" +
                        "My mother was (7)______ oldest, My gnandmother died recently, and my grandfather lives alone now." +
                            " He is almost 80, (8)______ he is still very active and interested in everything (9)______ 15 going on, "+
                                "He reads the papes and (10)______ television even though hảs eyesight is fairly poor.";

            bt1.DapAn = "My grandfather was born in China. He cane from a very poor family and was (1) __one__ of seven children. His parents lived (2)__on__ a samll farm. " +
                "He didn't have a very good education. At the age of 17 he (3)__left__ home. First he went to Shanghai and (4)__then__ he went to Hong Kong. " +
                "He worded (5)__as__ a waiter and then as a cook. When he was 21, he (6)_-married__ my grandmother and had four children" +
                        "My mother was (7)__the__ oldest, My gnandmother died recently, and my grandfather lives alone now." +
                            " He is almost 80, (8)__but__ he is still very active and interested in everything (9)__that__ 15 going on, " +
                                "He reads the papes and (10)__watches__ television even though hảs eyesight is fairly poor.";

            List<string> list = new List<string>();
            list.Add("one");
            list.Add("on") ;
            list.Add("left");
            list.Add("then");
            list.Add("as");
            list.Add("married");
            list.Add("the");
            list.Add("but");
            list.Add("that");
            list.Add("watches");

            bt1.DapAnTungCau = list;
            
            txtDeBai.Text = bt1.DeBai;
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            txtDeBai.Text = bt1.DapAn;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtDeBai.Text = bt1.DeBai;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = 0;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    string numberString = Regex.Replace(textBox.Name, "[^0-9]", ""); // Lọc lấy các ký tự số
                    int index = int.Parse(numberString) - 1;
                    if (bt1.DapAnTungCau[index] == textBox.Text.Trim()) diem += 1;
                }
            }
            MessageBox.Show("Bạn được " + diem.ToString() + " điểm");
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
