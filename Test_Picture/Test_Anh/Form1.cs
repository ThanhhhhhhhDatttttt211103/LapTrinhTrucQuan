using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Anh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFie = new OpenFileDialog();
            openFie.Filter = "JPEG images|*.jpg|Bitmap images|*.bmp|All Filtes|*.*";
            openFie.FilterIndex = 1;
            if(openFie.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = Image.FromFile(openFie.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
