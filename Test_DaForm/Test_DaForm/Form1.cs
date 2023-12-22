using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_DaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nmuBai1_Click(object sender, EventArgs e)
        {
            Form_Bai1 formBai1 = new Form_Bai1();
            formBai1.Show();
            this.Visible = false;
        }

        private void mnuBai2_Click(object sender, EventArgs e)
        {
            Form_Bai2 formBai2 = new Form_Bai2();
            formBai2.Show();
            this.Visible = false;
        }
    }
}
