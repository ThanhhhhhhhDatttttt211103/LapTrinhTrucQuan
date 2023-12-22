using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DuThuyenHoTay
{
    public partial class Form1 : Form
    {
        private List<Douong> listDoUong = new List<Douong>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNuoc();
            addSoLuong();

        }


        private void addNuoc()
        {
            cbNuoc.Items.Add("Coca Cola");
            listDoUong.Add(new Douong("Coca Cola", 12000));
            cbNuoc.Items.Add("Pepsi");
            listDoUong.Add(new Douong("Pepsi", 10000));
            cbNuoc.Items.Add("Fanta");
            listDoUong.Add(new Douong("Fanta", 8000));
            cbNuoc.Items.Add("7Up");
            listDoUong.Add(new Douong("7Up", 7000));
            cbNuoc.Items.Add("Lavie");
            listDoUong.Add(new Douong("Lavie", 5000));
            cbNuoc.Items.Add("Sting");
            listDoUong.Add(new Douong("Sting", 10000));
        }

        private void addSoLuong()
        {
            for(int i = 1; i <=10; i++)
                cbSoLuong.Items.Add(i);
        }

        private void cbSoLuong_SelectedValueChanged(object sender, EventArgs e)
        {
            listDoUong.
        }
    }
}
