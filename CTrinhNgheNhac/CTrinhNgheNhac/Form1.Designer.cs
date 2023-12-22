namespace CTrinhNgheNhac
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbO = new System.Windows.Forms.ComboBox();
            this.cbThuMuc = new System.Windows.Forms.ComboBox();
            this.rtbLyric = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listCaNhac = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thư mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tệp tin";
            // 
            // cbO
            // 
            this.cbO.FormattingEnabled = true;
            this.cbO.Location = new System.Drawing.Point(162, 31);
            this.cbO.Name = "cbO";
            this.cbO.Size = new System.Drawing.Size(204, 28);
            this.cbO.TabIndex = 1;
            this.cbO.SelectedValueChanged += new System.EventHandler(this.Choose_ODia);
            // 
            // cbThuMuc
            // 
            this.cbThuMuc.FormattingEnabled = true;
            this.cbThuMuc.Location = new System.Drawing.Point(162, 83);
            this.cbThuMuc.Name = "cbThuMuc";
            this.cbThuMuc.Size = new System.Drawing.Size(204, 28);
            this.cbThuMuc.TabIndex = 1;
            this.cbThuMuc.SelectedValueChanged += new System.EventHandler(this.chooseThuMuc);
            // 
            // rtbLyric
            // 
            this.rtbLyric.Location = new System.Drawing.Point(420, 31);
            this.rtbLyric.Name = "rtbLyric";
            this.rtbLyric.ReadOnly = true;
            this.rtbLyric.Size = new System.Drawing.Size(377, 540);
            this.rtbLyric.TabIndex = 2;
            this.rtbLyric.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(29, 353);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(337, 218);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // listCaNhac
            // 
            this.listCaNhac.FormattingEnabled = true;
            this.listCaNhac.ItemHeight = 20;
            this.listCaNhac.Location = new System.Drawing.Point(29, 166);
            this.listCaNhac.Name = "listCaNhac";
            this.listCaNhac.Size = new System.Drawing.Size(337, 164);
            this.listCaNhac.TabIndex = 4;
            this.listCaNhac.DoubleClick += new System.EventHandler(this.Chon_Bai);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 601);
            this.Controls.Add(this.listCaNhac);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.rtbLyric);
            this.Controls.Add(this.cbThuMuc);
            this.Controls.Add(this.cbO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbO;
        private System.Windows.Forms.ComboBox cbThuMuc;
        private System.Windows.Forms.RichTextBox rtbLyric;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listCaNhac;
    }
}

