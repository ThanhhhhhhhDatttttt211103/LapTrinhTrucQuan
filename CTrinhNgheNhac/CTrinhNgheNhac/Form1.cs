using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTrinhNgheNhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                cbO.Items.Add(drive.Name);  
            }
        }

        private void Choose_ODia(object sender, EventArgs e)
        {
            cbThuMuc.Items.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(cbO.Text);
            DirectoryInfo[] directories = directoryInfo.GetDirectories("*.*");           
            foreach (DirectoryInfo file in directories)
                cbThuMuc.Items.Add(file.Name);
        }

        private void chooseThuMuc(object sender, EventArgs e)
        {
            listCaNhac.Items.Clear();
            string[] files = Directory.GetFiles(cbO.Text + cbThuMuc.Text);
            foreach (string file in files)
            {
                if (Path.GetExtension(file).Equals(".mp3", StringComparison.OrdinalIgnoreCase))
                    listCaNhac.Items.Add(file);
            }    
        }

        private void Chon_Bai (object sender, EventArgs e)
        {
            string[] diaChi = listCaNhac.Text.Split('.');
            string diaChiLyric = diaChi[0] + ".txt";
            try
            {
                using (FileStream fs = new FileStream(diaChiLyric, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        string lyric = sr.ReadToEnd();
                        rtbLyric.Text = lyric;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                rtbLyric.Text = "";
            }
            axWindowsMediaPlayer1.URL = listCaNhac.Text;
        }
    }
}
