
namespace Thuchanh
{
    partial class FormDangky
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
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhaplai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(132, 43);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(92, 20);
            this.txtTenTK.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(130, 76);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(92, 20);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // btnDangky
            // 
            this.btnDangky.Location = new System.Drawing.Point(132, 155);
            this.btnDangky.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(74, 28);
            this.btnDangky.TabIndex = 4;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtNhaplai
            // 
            this.txtNhaplai.Location = new System.Drawing.Point(132, 106);
            this.txtNhaplai.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhaplai.Name = "txtNhaplai";
            this.txtNhaplai.Size = new System.Drawing.Size(92, 20);
            this.txtNhaplai.TabIndex = 3;
            this.txtNhaplai.UseSystemPasswordChar = true;
            // 
            // FormDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 218);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhaplai);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDangky";
            this.Text = "FormDangky";
            this.Load += new System.EventHandler(this.FormDangky_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhaplai;
    }
}