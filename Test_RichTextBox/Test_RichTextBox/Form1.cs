using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plain Text (*.txt)|*.txt";
            try
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtb.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                    MessageBox.Show("Lưu thành công");
                }
            }
            catch (Exception ex) { throw ex; }              
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Plain Text (*.txt)|*.txt";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = openFileDialog1.OpenFile();
                    StreamReader sr = new StreamReader(stream);

                    string line = sr.ReadLine();
                    while(line != null)
                    {
                        rtb.Text += line;
                        rtb.Text += "\n";
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void hien()
        {
            MessageBox.Show(rtb.SelectedText);
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            hien();
        }
    }
}
