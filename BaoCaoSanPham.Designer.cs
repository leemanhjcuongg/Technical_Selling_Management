
namespace Thuchanh
{
    partial class BaoCaoSanPham
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbNguoiLap = new System.Windows.Forms.TextBox();
            this.btnSetNguoiLap = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1092, 736);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // tbNguoiLap
            // 
            this.tbNguoiLap.Location = new System.Drawing.Point(343, 764);
            this.tbNguoiLap.Name = "tbNguoiLap";
            this.tbNguoiLap.Size = new System.Drawing.Size(188, 20);
            this.tbNguoiLap.TabIndex = 1;
            // 
            // btnSetNguoiLap
            // 
            this.btnSetNguoiLap.Location = new System.Drawing.Point(599, 762);
            this.btnSetNguoiLap.Name = "btnSetNguoiLap";
            this.btnSetNguoiLap.Size = new System.Drawing.Size(158, 23);
            this.btnSetNguoiLap.TabIndex = 2;
            this.btnSetNguoiLap.Text = "Đặt tên người lập báo cáo";
            this.btnSetNguoiLap.UseVisualStyleBackColor = true;
            this.btnSetNguoiLap.Click += new System.EventHandler(this.btnSetNguoiLap_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(781, 761);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // BaoCaoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 811);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSetNguoiLap);
            this.Controls.Add(this.tbNguoiLap);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "BaoCaoSanPham";
            this.Text = "Báo cáo sản phẩm";
            this.Load += new System.EventHandler(this.BaoCaoSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox tbNguoiLap;
        private System.Windows.Forms.Button btnSetNguoiLap;
        private System.Windows.Forms.Button btnHome;
    }
}