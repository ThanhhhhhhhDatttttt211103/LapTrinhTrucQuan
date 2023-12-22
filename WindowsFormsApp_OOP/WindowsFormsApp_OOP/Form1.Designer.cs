namespace WindowsFormsApp_OOP
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
            this.lbl_chuvi = new System.Windows.Forms.Label();
            this.lbl_dientich = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_dai = new System.Windows.Forms.TextBox();
            this.txt_rong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập dài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập rộng";
            // 
            // lbl_chuvi
            // 
            this.lbl_chuvi.AutoSize = true;
            this.lbl_chuvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chuvi.Location = new System.Drawing.Point(86, 216);
            this.lbl_chuvi.Name = "lbl_chuvi";
            this.lbl_chuvi.Size = new System.Drawing.Size(79, 25);
            this.lbl_chuvi.TabIndex = 2;
            this.lbl_chuvi.Text = "Chu vi: ";
            this.lbl_chuvi.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_dientich
            // 
            this.lbl_dientich.AutoSize = true;
            this.lbl_dientich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dientich.Location = new System.Drawing.Point(86, 273);
            this.lbl_dientich.Name = "lbl_dientich";
            this.lbl_dientich.Size = new System.Drawing.Size(93, 25);
            this.lbl_dientich.TabIndex = 3;
            this.lbl_dientich.Text = "Diện tích:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tính chu vi và diện tích";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_dai
            // 
            this.txt_dai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dai.Location = new System.Drawing.Point(192, 92);
            this.txt_dai.Name = "txt_dai";
            this.txt_dai.Size = new System.Drawing.Size(390, 30);
            this.txt_dai.TabIndex = 5;
            // 
            // txt_rong
            // 
            this.txt_rong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rong.Location = new System.Drawing.Point(192, 151);
            this.txt_rong.Name = "txt_rong";
            this.txt_rong.Size = new System.Drawing.Size(390, 30);
            this.txt_rong.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_rong);
            this.Controls.Add(this.txt_dai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_dientich);
            this.Controls.Add(this.lbl_chuvi);
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
        private System.Windows.Forms.Label lbl_chuvi;
        private System.Windows.Forms.Label lbl_dientich;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_dai;
        private System.Windows.Forms.TextBox txt_rong;
    }
}

