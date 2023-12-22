using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Scrollbar
{
    public partial class Form1 : Form
    {
        private int r;
        private int g;
        private int b;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void ColorChange(object sender, EventArgs e)
        {
            r = hsbRed.Value;
            g = hsbGreen.Value;
            b = hsbBlue.Value;

            txtNen.BackColor = Color.FromArgb(r, g, b);
            
        }
    }
}
