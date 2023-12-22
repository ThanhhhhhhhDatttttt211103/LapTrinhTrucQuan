namespace Test_DaForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiTậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiTậpToolStripMenuItem
            // 
            this.bàiTậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuBai1,
            this.mnuBai2});
            this.bàiTậpToolStripMenuItem.Name = "bàiTậpToolStripMenuItem";
            this.bàiTậpToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.bàiTậpToolStripMenuItem.Text = "Bài tập";
            // 
            // nmuBai1
            // 
            this.nmuBai1.Name = "nmuBai1";
            this.nmuBai1.Size = new System.Drawing.Size(224, 26);
            this.nmuBai1.Text = "Bài 1";
            this.nmuBai1.Click += new System.EventHandler(this.nmuBai1_Click);
            // 
            // mnuBai2
            // 
            this.mnuBai2.Name = "mnuBai2";
            this.mnuBai2.Size = new System.Drawing.Size(224, 26);
            this.mnuBai2.Text = "Bài 2";
            this.mnuBai2.Click += new System.EventHandler(this.mnuBai2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nmuBai1;
        private System.Windows.Forms.ToolStripMenuItem mnuBai2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

