using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckedChanged_Font(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            txtBoxName.Font = new Font(rdo.Text, txtBoxName.Font.Size);
        }

        private void CheckedChanged_Color(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            txtBoxName.ForeColor = rdo.ForeColor;
        }

        private void Bold_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxName.Font = new Font(txtBoxName.Font.Name, txtBoxName.Font.Size, txtBoxName.Font.Style ^ FontStyle.Bold);
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxName.Font = new Font(txtBoxName.Font.Name, txtBoxName.Font.Size, txtBoxName.Font.Style ^ FontStyle.Italic);
        }

        private void Underline_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxName.Font = new Font(txtBoxName.Font.Name, txtBoxName.Font.Size, txtBoxName.Font.Style ^ FontStyle.Underline);
        }

        private void Strikeout_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxName.Font = new Font(txtBoxName.Font.Name, txtBoxName.Font.Size, txtBoxName.Font.Style ^ FontStyle.Strikeout);
        }

        private void LamLai_Click(object sender, EventArgs e)
        {
            txtBoxName.ForeColor = Color.Black;
            txtBoxName.Font = new Font("Arial", txtBoxName.Font.Size, FontStyle.Regular);


            foreach(Control control in groupBox1.Controls)
            {
                RadioButton rdo = (RadioButton)control;
                rdo.Checked = false;
            }
            foreach (Control control in groupBox2.Controls)
            {
                CheckBox rdo = (CheckBox)control;
                rdo.Checked = false;
            }
            foreach (Control control in groupBox3.Controls)
            {
                RadioButton rdo = (RadioButton)control;
                rdo.Checked = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}