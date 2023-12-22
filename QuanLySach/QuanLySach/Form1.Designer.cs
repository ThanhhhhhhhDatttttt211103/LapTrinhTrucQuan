namespace QuanLySach
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
            this.lbl_Masach = new System.Windows.Forms.Label();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_TacGia = new System.Windows.Forms.Label();
            this.lbl_QR = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_TacGia = new System.Windows.Forms.TextBox();
            this.txt_MaQR = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txt_Ton = new System.Windows.Forms.TextBox();
            this.lbl_Ton = new System.Windows.Forms.Label();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Masach
            // 
            this.lbl_Masach.AutoSize = true;
            this.lbl_Masach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Masach.Location = new System.Drawing.Point(106, 33);
            this.lbl_Masach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Masach.Name = "lbl_Masach";
            this.lbl_Masach.Size = new System.Drawing.Size(87, 25);
            this.lbl_Masach.TabIndex = 0;
            this.lbl_Masach.Text = "Mã sách";
            this.lbl_Masach.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSach.Location = new System.Drawing.Point(106, 103);
            this.lbl_TenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(94, 25);
            this.lbl_TenSach.TabIndex = 1;
            this.lbl_TenSach.Text = "Tên sách";
            this.lbl_TenSach.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(106, 242);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(96, 25);
            this.lbl_SoLuong.TabIndex = 2;
            this.lbl_SoLuong.Text = "Số lượng:";
            this.lbl_SoLuong.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_TacGia
            // 
            this.lbl_TacGia.AutoSize = true;
            this.lbl_TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TacGia.Location = new System.Drawing.Point(106, 177);
            this.lbl_TacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TacGia.Name = "lbl_TacGia";
            this.lbl_TacGia.Size = new System.Drawing.Size(120, 25);
            this.lbl_TacGia.TabIndex = 3;
            this.lbl_TacGia.Text = "Tên tác giả: ";
            this.lbl_TacGia.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_QR
            // 
            this.lbl_QR.AutoSize = true;
            this.lbl_QR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QR.Location = new System.Drawing.Point(106, 310);
            this.lbl_QR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QR.Name = "lbl_QR";
            this.lbl_QR.Size = new System.Drawing.Size(80, 25);
            this.lbl_QR.TabIndex = 4;
            this.lbl_QR.Text = "Ma QR:";
            this.lbl_QR.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(242, 33);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(394, 30);
            this.txt_MaSach.TabIndex = 5;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(242, 242);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(394, 30);
            this.txt_SoLuong.TabIndex = 6;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(242, 103);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(394, 30);
            this.txt_TenSach.TabIndex = 7;
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Location = new System.Drawing.Point(242, 174);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.Size = new System.Drawing.Size(394, 30);
            this.txt_TacGia.TabIndex = 8;
            // 
            // txt_MaQR
            // 
            this.txt_MaQR.Location = new System.Drawing.Point(242, 305);
            this.txt_MaQR.Name = "txt_MaQR";
            this.txt_MaQR.Size = new System.Drawing.Size(394, 30);
            this.txt_MaQR.TabIndex = 9;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(242, 372);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(116, 30);
            this.txt_Search.TabIndex = 11;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(106, 377);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(91, 25);
            this.lbl_TimKiem.TabIndex = 10;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // txt_Ton
            // 
            this.txt_Ton.Location = new System.Drawing.Point(532, 372);
            this.txt_Ton.Name = "txt_Ton";
            this.txt_Ton.Size = new System.Drawing.Size(104, 30);
            this.txt_Ton.TabIndex = 13;
            // 
            // lbl_Ton
            // 
            this.lbl_Ton.AutoSize = true;
            this.lbl_Ton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ton.Location = new System.Drawing.Point(396, 377);
            this.lbl_Ton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ton.Name = "lbl_Ton";
            this.lbl_Ton.Size = new System.Drawing.Size(47, 25);
            this.lbl_Ton.TabIndex = 12;
            this.lbl_Ton.Text = "Tồn";
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(132, 444);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(225, 59);
            this.btn_Nhap.TabIndex = 14;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(460, 444);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(225, 59);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(723, 48);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(551, 375);
            this.table.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1390, 527);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.txt_Ton);
            this.Controls.Add(this.lbl_Ton);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txt_MaQR);
            this.Controls.Add(this.txt_TacGia);
            this.Controls.Add(this.txt_TenSach);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_MaSach);
            this.Controls.Add(this.lbl_QR);
            this.Controls.Add(this.lbl_TacGia);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_TenSach);
            this.Controls.Add(this.lbl_Masach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "QLy_Sach";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Masach;
        private System.Windows.Forms.Label lbl_TenSach;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_TacGia;
        private System.Windows.Forms.Label lbl_QR;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_TacGia;
        private System.Windows.Forms.TextBox txt_MaQR;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox txt_Ton;
        private System.Windows.Forms.Label lbl_Ton;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView table;
    }
}

