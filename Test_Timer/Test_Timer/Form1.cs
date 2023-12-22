using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int m, s;
            m = int.Parse(txtPhut.Text);
            s = int.Parse(txtGiay.Text);
            if (s > 0 && s <= 59)
                s = s - 1;
            else
            {
                if (m > 0 && s == 0)
                {
                    s = 59; m = m -1;
                }
                if(m == 0 && s == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Hết giờ");
                }
                
            }
            txtPhut.Text = m.ToString();
            txtGiay.Text = s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPhut.Text = "0";
            txtGiay.Text = "0";
            
        }
    }
}
