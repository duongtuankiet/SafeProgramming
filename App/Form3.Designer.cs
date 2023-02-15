namespace Buoi2_LapTrinhAnToan
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soanDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemĐềThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiTrắcNghiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deThiToolStripMenuItem,
            this.thiTrắcNghiệmToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deThiToolStripMenuItem
            // 
            this.deThiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soanDeToolStripMenuItem,
            this.xemĐềThiToolStripMenuItem});
            this.deThiToolStripMenuItem.Name = "deThiToolStripMenuItem";
            this.deThiToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.deThiToolStripMenuItem.Text = "Đề thi";
            this.deThiToolStripMenuItem.Click += new System.EventHandler(this.deThiToolStripMenuItem_Click);
            // 
            // soanDeToolStripMenuItem
            // 
            this.soanDeToolStripMenuItem.Name = "soanDeToolStripMenuItem";
            this.soanDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soanDeToolStripMenuItem.Text = "Soạn đề thi";
            this.soanDeToolStripMenuItem.Click += new System.EventHandler(this.soanDeToolStripMenuItem_Click);
            // 
            // xemĐềThiToolStripMenuItem
            // 
            this.xemĐềThiToolStripMenuItem.Name = "xemĐềThiToolStripMenuItem";
            this.xemĐềThiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xemĐềThiToolStripMenuItem.Text = "Xem đề thi";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thiTrắcNghiệmToolStripMenuItem
            // 
            this.thiTrắcNghiệmToolStripMenuItem.Name = "thiTrắcNghiệmToolStripMenuItem";
            this.thiTrắcNghiệmToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.thiTrắcNghiệmToolStripMenuItem.Text = "Thi trắc nghiệm";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 472);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Thi trac nghiem he dieu hanh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soanDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemĐềThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiTrắcNghiệmToolStripMenuItem;
    }
}