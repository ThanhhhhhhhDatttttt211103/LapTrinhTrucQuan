using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuDo
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> list = new Dictionary<string, string>();
        private string qGia;

        public Form1()
        {
            InitializeComponent();
            list.Add("Japan", "Tokyo");
            list.Add("France", "Paris");
            list.Add("Hungary", "Budapest");
            list.Add("Spain", "Madrid");
            list.Add("Turkey", "Ankara");
            list.Add("The UK", "London");
            list.Add("Italy", "Rome");
            list.Add("The USA", "Washington, D.C");

        }

        private void ThuDo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            String value;
            list.TryGetValue(qGia, out value);
            if (value.Equals(rdo.Text)){
                MessageBox.Show("Bạn đã chọn đúng","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
                MessageBox.Show("Bạn đã chọn sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        private void QuocGia_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            label2.Text = "Bạn hãy chọn thủ đô cho " + rdo.Text;
            qGia = rdo.Text;
            EmptyOpiton();
        }

        private void EmptyOpiton()
        {
            foreach (Control control in groupBox2.Controls)
            {
                RadioButton rdo = (RadioButton)control;
                rdo.Checked = false;
            }
        }

    }
}
