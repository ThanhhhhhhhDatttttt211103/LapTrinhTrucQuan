namespace S_P_HinhTron
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BanKinh = new System.Windows.Forms.TextBox();
            this.txt_ChuVi = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.btn_LamLai = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Diện Tích Và Chu Vi Hình Tròn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập bán kính (r)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chu vi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diện tích";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_BanKinh
            // 
            this.txt_BanKinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BanKinh.Location = new System.Drawing.Point(308, 141);
            this.txt_BanKinh.Name = "txt_BanKinh";
            this.txt_BanKinh.Size = new System.Drawing.Size(324, 30);
            this.txt_BanKinh.TabIndex = 4;
            this.txt_BanKinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BanKinh_KeyPress);
            // 
            // txt_ChuVi
            // 
            this.txt_ChuVi.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_ChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChuVi.Location = new System.Drawing.Point(308, 213);
            this.txt_ChuVi.Name = "txt_ChuVi";
            this.txt_ChuVi.Size = new System.Drawing.Size(324, 30);
            this.txt_ChuVi.TabIndex = 5;
            // 
            // txtDienTich
            // 
            this.txtDienTich.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Location = new System.Drawing.Point(308, 282);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(324, 30);
            this.txtDienTich.TabIndex = 6;
            this.txtDienTich.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tinh.Location = new System.Drawing.Point(144, 359);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(129, 41);
            this.btn_Tinh.TabIndex = 7;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // btn_LamLai
            // 
            this.btn_LamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamLai.Location = new System.Drawing.Point(339, 359);
            this.btn_LamLai.Name = "btn_LamLai";
            this.btn_LamLai.Size = new System.Drawing.Size(129, 41);
            this.btn_LamLai.TabIndex = 8;
            this.btn_LamLai.Text = "Làm lại";
            this.btn_LamLai.UseVisualStyleBackColor = true;
            this.btn_LamLai.Click += new System.EventHandler(this.btn_LamLai_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(532, 359);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(129, 41);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamLai);
            this.Controls.Add(this.btn_Tinh);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txt_ChuVi);
            this.Controls.Add(this.txt_BanKinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BanKinh;
        private System.Windows.Forms.TextBox txt_ChuVi;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Button btn_LamLai;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

