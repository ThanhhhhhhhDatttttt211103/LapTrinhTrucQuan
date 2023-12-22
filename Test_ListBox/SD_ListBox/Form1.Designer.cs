namespace SD_ListBox
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
            this.lsHang = new System.Windows.Forms.ListBox();
            this.ls_GioHang = new System.Windows.Forms.ListBox();
            this.lbl_HangHoa = new System.Windows.Forms.Label();
            this.lbl_DatHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.grbPhuongThuc = new System.Windows.Forms.GroupBox();
            this.rdoThe = new System.Windows.Forms.RadioButton();
            this.rdoSec = new System.Windows.Forms.RadioButton();
            this.rdoTienMat = new System.Windows.Forms.RadioButton();
            this.grbLienLac = new System.Windows.Forms.GroupBox();
            this.chbEmail = new System.Windows.Forms.CheckBox();
            this.chbFax = new System.Windows.Forms.CheckBox();
            this.chbDienThoat = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbPhuongThuc.SuspendLayout();
            this.grbLienLac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsHang
            // 
            this.lsHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsHang.FormattingEnabled = true;
            this.lsHang.ItemHeight = 20;
            this.lsHang.Items.AddRange(new object[] {
            "Thiết kế cơ sở dữ liệu",
            "Triết học",
            "Công nghê Java",
            "Giáo trình tin học đại cương",
            "Lập trình hướng đối tượng",
            "Quản lý dự án",
            "Toán cao cấp ",
            "Toán rời rạc",
            "Giải tích 1",
            "Giải tích 2",
            "Giải tích 3",
            "Thí nghiệm vật lí",
            "Vật lí đại cương",
            "Lịch sử đảng",
            "Tư tưởng Hồ Chí Minh",
            "Giáo dục công dân",
            "Sinh học",
            "Lập trình Web",
            "Conan",
            "Doraemon",
            "Siêu nhân điện quang",
            "Siêu nhân gao",
            "siêu nhân sấm sét"});
            this.lsHang.Location = new System.Drawing.Point(73, 172);
            this.lsHang.Name = "lsHang";
            this.lsHang.Size = new System.Drawing.Size(293, 204);
            this.lsHang.TabIndex = 0;
            this.lsHang.DoubleClick += new System.EventHandler(this.lsHang_DoubleClick);
            // 
            // ls_GioHang
            // 
            this.ls_GioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ls_GioHang.FormattingEnabled = true;
            this.ls_GioHang.ItemHeight = 20;
            this.ls_GioHang.Location = new System.Drawing.Point(440, 172);
            this.ls_GioHang.Name = "ls_GioHang";
            this.ls_GioHang.Size = new System.Drawing.Size(300, 204);
            this.ls_GioHang.TabIndex = 1;
            this.ls_GioHang.DoubleClick += new System.EventHandler(this.ls_GioHang_DoubleClick);
            // 
            // lbl_HangHoa
            // 
            this.lbl_HangHoa.AutoSize = true;
            this.lbl_HangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HangHoa.Location = new System.Drawing.Point(69, 136);
            this.lbl_HangHoa.Name = "lbl_HangHoa";
            this.lbl_HangHoa.Size = new System.Drawing.Size(163, 20);
            this.lbl_HangHoa.TabIndex = 2;
            this.lbl_HangHoa.Text = "Danh sách hàng hóa";
            // 
            // lbl_DatHang
            // 
            this.lbl_DatHang.AutoSize = true;
            this.lbl_DatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatHang.Location = new System.Drawing.Point(436, 136);
            this.lbl_DatHang.Name = "lbl_DatHang";
            this.lbl_DatHang.Size = new System.Drawing.Size(114, 20);
            this.lbl_DatHang.TabIndex = 3;
            this.lbl_DatHang.Text = "Hàng đặt mua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điện thoại";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(159, 38);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 27);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(560, 41);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(180, 27);
            this.txtDienThoai.TabIndex = 9;
            // 
            // grbPhuongThuc
            // 
            this.grbPhuongThuc.Controls.Add(this.rdoThe);
            this.grbPhuongThuc.Controls.Add(this.rdoSec);
            this.grbPhuongThuc.Controls.Add(this.rdoTienMat);
            this.grbPhuongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPhuongThuc.Location = new System.Drawing.Point(72, 407);
            this.grbPhuongThuc.Name = "grbPhuongThuc";
            this.grbPhuongThuc.Size = new System.Drawing.Size(293, 167);
            this.grbPhuongThuc.TabIndex = 10;
            this.grbPhuongThuc.TabStop = false;
            this.grbPhuongThuc.Text = "Phương thức thanh toán";
            // 
            // rdoThe
            // 
            this.rdoThe.AutoSize = true;
            this.rdoThe.Location = new System.Drawing.Point(63, 127);
            this.rdoThe.Name = "rdoThe";
            this.rdoThe.Size = new System.Drawing.Size(122, 24);
            this.rdoThe.TabIndex = 0;
            this.rdoThe.Text = "Thẻ tín dụng";
            this.rdoThe.UseVisualStyleBackColor = true;
            // 
            // rdoSec
            // 
            this.rdoSec.AutoSize = true;
            this.rdoSec.Location = new System.Drawing.Point(63, 82);
            this.rdoSec.Name = "rdoSec";
            this.rdoSec.Size = new System.Drawing.Size(59, 24);
            this.rdoSec.TabIndex = 0;
            this.rdoSec.Text = "Sec";
            this.rdoSec.UseVisualStyleBackColor = true;
            // 
            // rdoTienMat
            // 
            this.rdoTienMat.AutoSize = true;
            this.rdoTienMat.Checked = true;
            this.rdoTienMat.Location = new System.Drawing.Point(63, 42);
            this.rdoTienMat.Name = "rdoTienMat";
            this.rdoTienMat.Size = new System.Drawing.Size(95, 24);
            this.rdoTienMat.TabIndex = 0;
            this.rdoTienMat.TabStop = true;
            this.rdoTienMat.Text = "Tiền mặt";
            this.rdoTienMat.UseVisualStyleBackColor = true;
            // 
            // grbLienLac
            // 
            this.grbLienLac.Controls.Add(this.chbEmail);
            this.grbLienLac.Controls.Add(this.chbFax);
            this.grbLienLac.Controls.Add(this.chbDienThoat);
            this.grbLienLac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLienLac.Location = new System.Drawing.Point(440, 407);
            this.grbLienLac.Name = "grbLienLac";
            this.grbLienLac.Size = new System.Drawing.Size(300, 167);
            this.grbLienLac.TabIndex = 10;
            this.grbLienLac.TabStop = false;
            this.grbLienLac.Text = "Hình thức liên lạc";
            // 
            // chbEmail
            // 
            this.chbEmail.AutoSize = true;
            this.chbEmail.Location = new System.Drawing.Point(76, 127);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Size = new System.Drawing.Size(73, 24);
            this.chbEmail.TabIndex = 0;
            this.chbEmail.Text = "Email";
            this.chbEmail.UseVisualStyleBackColor = true;
            // 
            // chbFax
            // 
            this.chbFax.AutoSize = true;
            this.chbFax.Location = new System.Drawing.Point(76, 83);
            this.chbFax.Name = "chbFax";
            this.chbFax.Size = new System.Drawing.Size(58, 24);
            this.chbFax.TabIndex = 0;
            this.chbFax.Text = "Fax";
            this.chbFax.UseVisualStyleBackColor = true;
            // 
            // chbDienThoat
            // 
            this.chbDienThoat.AutoSize = true;
            this.chbDienThoat.Checked = true;
            this.chbDienThoat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDienThoat.Location = new System.Drawing.Point(76, 43);
            this.chbDienThoat.Name = "chbDienThoat";
            this.chbDienThoat.Size = new System.Drawing.Size(106, 24);
            this.chbDienThoat.TabIndex = 0;
            this.chbDienThoat.Text = "Điện thoại";
            this.chbDienThoat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(413, 602);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 40);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbLienLac);
            this.Controls.Add(this.grbPhuongThuc);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_DatHang);
            this.Controls.Add(this.lbl_HangHoa);
            this.Controls.Add(this.ls_GioHang);
            this.Controls.Add(this.lsHang);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPhuongThuc.ResumeLayout(false);
            this.grbPhuongThuc.PerformLayout();
            this.grbLienLac.ResumeLayout(false);
            this.grbLienLac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsHang;
        private System.Windows.Forms.ListBox ls_GioHang;
        private System.Windows.Forms.Label lbl_HangHoa;
        private System.Windows.Forms.Label lbl_DatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.GroupBox grbPhuongThuc;
        private System.Windows.Forms.RadioButton rdoThe;
        private System.Windows.Forms.RadioButton rdoSec;
        private System.Windows.Forms.RadioButton rdoTienMat;
        private System.Windows.Forms.GroupBox grbLienLac;
        private System.Windows.Forms.CheckBox chbEmail;
        private System.Windows.Forms.CheckBox chbFax;
        private System.Windows.Forms.CheckBox chbDienThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
    }
}

