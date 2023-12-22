namespace DuThuyenHoTay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVao = new System.Windows.Forms.Button();
            this.cbSoLuong = new System.Windows.Forms.ComboBox();
            this.cbNuoc = new System.Windows.Forms.ComboBox();
            this.rdoNua = new System.Windows.Forms.RadioButton();
            this.rdoCa = new System.Windows.Forms.RadioButton();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listKH = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVao);
            this.groupBox1.Controls.Add(this.cbSoLuong);
            this.groupBox1.Controls.Add(this.cbNuoc);
            this.groupBox1.Controls.Add(this.rdoNua);
            this.groupBox1.Controls.Add(this.rdoCa);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Khách Hàng";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(211, 380);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(128, 33);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnThemVao
            // 
            this.btnThemVao.Location = new System.Drawing.Point(50, 380);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(128, 33);
            this.btnThemVao.TabIndex = 4;
            this.btnThemVao.Text = "Thêm vào DS";
            this.btnThemVao.UseVisualStyleBackColor = true;
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.FormattingEnabled = true;
            this.cbSoLuong.Location = new System.Drawing.Point(157, 288);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(103, 28);
            this.cbSoLuong.TabIndex = 3;
            this.cbSoLuong.SelectedValueChanged += new System.EventHandler(this.cbSoLuong_SelectedValueChanged);
            // 
            // cbNuoc
            // 
            this.cbNuoc.FormattingEnabled = true;
            this.cbNuoc.Location = new System.Drawing.Point(11, 288);
            this.cbNuoc.Name = "cbNuoc";
            this.cbNuoc.Size = new System.Drawing.Size(103, 28);
            this.cbNuoc.TabIndex = 3;
            // 
            // rdoNua
            // 
            this.rdoNua.AutoSize = true;
            this.rdoNua.Location = new System.Drawing.Point(236, 108);
            this.rdoNua.Name = "rdoNua";
            this.rdoNua.Size = new System.Drawing.Size(103, 24);
            this.rdoNua.TabIndex = 2;
            this.rdoNua.TabStop = true;
            this.rdoNua.Text = "Nửa Ngày";
            this.rdoNua.UseVisualStyleBackColor = true;
            // 
            // rdoCa
            // 
            this.rdoCa.AutoSize = true;
            this.rdoCa.Location = new System.Drawing.Point(11, 108);
            this.rdoCa.Name = "rdoCa";
            this.rdoCa.Size = new System.Drawing.Size(94, 24);
            this.rdoCa.TabIndex = 2;
            this.rdoCa.TabStop = true;
            this.rdoCa.Text = "Cả Ngày";
            this.rdoCa.UseVisualStyleBackColor = true;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(287, 289);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(120, 27);
            this.txtThanhTien.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(110, 163);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(170, 27);
            this.txtGia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thành Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(110, 53);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(170, 27);
            this.txtTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listKH);
            this.groupBox2.Location = new System.Drawing.Point(459, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(598, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // listKH
            // 
            this.listKH.FormattingEnabled = true;
            this.listKH.ItemHeight = 20;
            this.listKH.Location = new System.Drawing.Point(7, 27);
            this.listKH.Name = "listKH";
            this.listKH.Size = new System.Drawing.Size(584, 344);
            this.listKH.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(922, 466);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 531);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoNua;
        private System.Windows.Forms.RadioButton rdoCa;
        private System.Windows.Forms.ComboBox cbSoLuong;
        private System.Windows.Forms.ComboBox cbNuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVao;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ListBox listKH;
        private System.Windows.Forms.Button btnThoat;
    }
}

