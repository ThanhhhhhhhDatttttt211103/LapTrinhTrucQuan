namespace DTB_SinhVien
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
            this.haha = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listMon = new System.Windows.Forms.ListBox();
            this.txtTongTin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.haha.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // haha
            // 
            this.haha.Controls.Add(this.btnThem);
            this.haha.Controls.Add(this.txtDiem);
            this.haha.Controls.Add(this.txtTinChi);
            this.haha.Controls.Add(this.cbMon);
            this.haha.Controls.Add(this.label3);
            this.haha.Controls.Add(this.label2);
            this.haha.Controls.Add(this.label1);
            this.haha.Location = new System.Drawing.Point(39, 36);
            this.haha.Margin = new System.Windows.Forms.Padding(4);
            this.haha.Name = "haha";
            this.haha.Padding = new System.Windows.Forms.Padding(4);
            this.haha.Size = new System.Drawing.Size(416, 529);
            this.haha.TabIndex = 0;
            this.haha.TabStop = false;
            this.haha.Text = "Thông tin điểm Sinh Viên";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(97, 373);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(204, 69);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm vào DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(139, 248);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(225, 27);
            this.txtDiem.TabIndex = 2;
            // 
            // txtTinChi
            // 
            this.txtTinChi.Location = new System.Drawing.Point(139, 176);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.ReadOnly = true;
            this.txtTinChi.Size = new System.Drawing.Size(225, 27);
            this.txtTinChi.TabIndex = 2;
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Giải tích",
            "Tiếng anh A1",
            "Triết học Mác-Lênin",
            "Vây lý F1"});
            this.cbMon.Location = new System.Drawing.Point(42, 102);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(322, 28);
            this.cbMon.TabIndex = 1;
            this.cbMon.SelectedIndexChanged += new System.EventHandler(this.ChonItem);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số tín chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listMon);
            this.groupBox2.Location = new System.Drawing.Point(463, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(624, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các môn học";
            // 
            // listMon
            // 
            this.listMon.FormattingEnabled = true;
            this.listMon.ItemHeight = 20;
            this.listMon.Location = new System.Drawing.Point(23, 38);
            this.listMon.Name = "listMon";
            this.listMon.Size = new System.Drawing.Size(575, 264);
            this.listMon.TabIndex = 0;
            // 
            // txtTongTin
            // 
            this.txtTongTin.Location = new System.Drawing.Point(618, 395);
            this.txtTongTin.Name = "txtTongTin";
            this.txtTongTin.ReadOnly = true;
            this.txtTongTin.Size = new System.Drawing.Size(114, 27);
            this.txtTongTin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(935, 395);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(126, 27);
            this.txtTongDiem.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng số điểm";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(618, 451);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.ReadOnly = true;
            this.txtDTB.Size = new System.Drawing.Size(114, 27);
            this.txtDTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điểm trung bình";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(486, 519);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(185, 46);
            this.btnTinh.TabIndex = 10;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(895, 519);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(192, 46);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 620);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.haha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.haha.ResumeLayout(false);
            this.haha.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox haha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtTinChi;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listMon;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

