namespace Thuchanh
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NVToolStripMenuItem,
            this.SPToolStripMenuItem,
            this.HDToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NVToolStripMenuItem
            // 
            this.NVToolStripMenuItem.Name = "NVToolStripMenuItem";
            this.NVToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.NVToolStripMenuItem.Text = "Quản lý nhân viên";
            this.NVToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
            // 
            // SPToolStripMenuItem
            // 
            this.SPToolStripMenuItem.Name = "SPToolStripMenuItem";
            this.SPToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.SPToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.SPToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // HDToolStripMenuItem
            // 
            this.HDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnNhậpToolStripMenuItem,
            this.hóaĐơnXuấtToolStripMenuItem});
            this.HDToolStripMenuItem.Name = "HDToolStripMenuItem";
            this.HDToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.HDToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.HDToolStripMenuItem.Click += new System.EventHandler(this.HDToolStripMenuItem_Click);
            // 
            // hóaĐơnNhậpToolStripMenuItem
            // 
            this.hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
            this.hóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hóaĐơnNhậpToolStripMenuItem.Text = "Hóa đơn nhập";
            // 
            // hóaĐơnXuấtToolStripMenuItem
            // 
            this.hóaĐơnXuấtToolStripMenuItem.Name = "hóaĐơnXuấtToolStripMenuItem";
            this.hóaĐơnXuấtToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hóaĐơnXuấtToolStripMenuItem.Text = "Hóa đơn xuất";
            this.hóaĐơnXuấtToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnXuấtToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem
            // 
            this.danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem.Name = "danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem";
            this.danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem.Text = "Danh sách sản phẩm";
            this.danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHome";
            this.Text = "Phần mềm quản lý kinh doanh máy tính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NVToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem SPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSảnPhẩmBánChạyNhất2021ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnXuấtToolStripMenuItem;
    }
}