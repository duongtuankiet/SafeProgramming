namespace App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýUserMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.đềThiHêĐiềuHànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đềThiCơSởDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.thiHêĐiềuHànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiCơSởDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.xemĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýUserMớiToolStripMenuItem,
            this.đổiMậtKhẩuUserToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(85, 24);
            this.fileMenu.Text = "&Hệ thống";
            // 
            // đăngKýUserMớiToolStripMenuItem
            // 
            this.đăngKýUserMớiToolStripMenuItem.Name = "đăngKýUserMớiToolStripMenuItem";
            this.đăngKýUserMớiToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.đăngKýUserMớiToolStripMenuItem.Text = "Đăng ký user mới";
            this.đăngKýUserMớiToolStripMenuItem.Click += new System.EventHandler(this.đăngKýUserMớiToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuUserToolStripMenuItem
            // 
            this.đổiMậtKhẩuUserToolStripMenuItem.Name = "đổiMậtKhẩuUserToolStripMenuItem";
            this.đổiMậtKhẩuUserToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.đổiMậtKhẩuUserToolStripMenuItem.Text = "Đổi mật khẩu user";
            this.đổiMậtKhẩuUserToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuUserToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đềThiHêĐiềuHànhToolStripMenuItem,
            this.đềThiCơSởDữLiệuToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(61, 24);
            this.editMenu.Text = "&Ra đề";
            // 
            // đềThiHêĐiềuHànhToolStripMenuItem
            // 
            this.đềThiHêĐiềuHànhToolStripMenuItem.Name = "đềThiHêĐiềuHànhToolStripMenuItem";
            this.đềThiHêĐiềuHànhToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đềThiHêĐiềuHànhToolStripMenuItem.Text = "Đề thi Hê điều hành";
            this.đềThiHêĐiềuHànhToolStripMenuItem.Click += new System.EventHandler(this.đềThiHêĐiềuHànhToolStripMenuItem_Click);
            // 
            // đềThiCơSởDữLiệuToolStripMenuItem
            // 
            this.đềThiCơSởDữLiệuToolStripMenuItem.Name = "đềThiCơSởDữLiệuToolStripMenuItem";
            this.đềThiCơSởDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đềThiCơSởDữLiệuToolStripMenuItem.Text = "Đề thi Cơ sở dữ liệu";
            this.đềThiCơSởDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.đềThiCơSởDữLiệuToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thiHêĐiềuHànhToolStripMenuItem,
            this.thiCơSởDữLiệuToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(43, 24);
            this.viewMenu.Text = "Thi";
            // 
            // thiHêĐiềuHànhToolStripMenuItem
            // 
            this.thiHêĐiềuHànhToolStripMenuItem.Name = "thiHêĐiềuHànhToolStripMenuItem";
            this.thiHêĐiềuHànhToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thiHêĐiềuHànhToolStripMenuItem.Text = "Thi Hê điều hành";
            this.thiHêĐiềuHànhToolStripMenuItem.Click += new System.EventHandler(this.thiHêĐiềuHànhToolStripMenuItem_Click);
            // 
            // thiCơSởDữLiệuToolStripMenuItem
            // 
            this.thiCơSởDữLiệuToolStripMenuItem.Name = "thiCơSởDữLiệuToolStripMenuItem";
            this.thiCơSởDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thiCơSởDữLiệuToolStripMenuItem.Text = "Thi Cơ sở dữ liệu";
            this.thiCơSởDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.thiCơSởDữLiệuToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemĐềToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(77, 24);
            this.toolsMenu.Text = "Công cụ";
            // 
            // xemĐềToolStripMenuItem
            // 
            this.xemĐềToolStripMenuItem.Name = "xemĐềToolStripMenuItem";
            this.xemĐềToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xemĐềToolStripMenuItem.Text = "Xem đề";
            this.xemĐềToolStripMenuItem.Click += new System.EventHandler(this.xemĐềToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Thi Trac nghiem he dieu hanh";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem đềThiHêĐiềuHànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đềThiCơSởDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiHêĐiềuHànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiCơSởDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemĐềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýUserMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
    }
}



