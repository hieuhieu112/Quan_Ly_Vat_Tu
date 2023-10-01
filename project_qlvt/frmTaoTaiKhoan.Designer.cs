namespace project_qlvt
{
    partial class frmTaoTaiKhoan
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.btnChonNhanVien = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.rbChiNhanh = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbConTy = new System.Windows.Forms.RadioButton();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(293, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(396, 52);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đăng ký tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(221, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(119, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(424, 144);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(100, 32);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // btnChonNhanVien
            // 
            this.btnChonNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonNhanVien.Location = new System.Drawing.Point(571, 141);
            this.btnChonNhanVien.Name = "btnChonNhanVien";
            this.btnChonNhanVien.Size = new System.Drawing.Size(177, 37);
            this.btnChonNhanVien.TabIndex = 3;
            this.btnChonNhanVien.Text = "Chọn nhân viên";
            this.btnChonNhanVien.UseVisualStyleBackColor = true;
            this.btnChonNhanVien.Click += new System.EventHandler(this.btnChonNhanVien_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(424, 242);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(324, 32);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(221, 245);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(424, 308);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(324, 32);
            this.txtRePassword.TabIndex = 7;
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(221, 311);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(163, 24);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Nhập lại mật khẩu";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(388, 466);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(246, 51);
            this.btnDangKy.TabIndex = 8;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseMnemonic = false;
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(221, 385);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 24);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Vai trò";
            // 
            // rbChiNhanh
            // 
            this.rbChiNhanh.AutoSize = true;
            this.rbChiNhanh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChiNhanh.Location = new System.Drawing.Point(424, 390);
            this.rbChiNhanh.Name = "rbChiNhanh";
            this.rbChiNhanh.Size = new System.Drawing.Size(120, 28);
            this.rbChiNhanh.TabIndex = 10;
            this.rbChiNhanh.TabStop = true;
            this.rbChiNhanh.Text = "Chi nhánh";
            this.rbChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUser.Location = new System.Drawing.Point(563, 390);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(71, 28);
            this.rbUser.TabIndex = 11;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // rbConTy
            // 
            this.rbConTy.AutoSize = true;
            this.rbConTy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConTy.Location = new System.Drawing.Point(649, 390);
            this.rbConTy.Name = "rbConTy";
            this.rbConTy.Size = new System.Drawing.Size(99, 28);
            this.rbConTy.TabIndex = 12;
            this.rbConTy.TabStop = true;
            this.rbConTy.Text = "Công ty";
            this.rbConTy.UseVisualStyleBackColor = true;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(424, 195);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(324, 32);
            this.txtTenDangNhap.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(221, 198);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(134, 24);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Tên đăng nhập";
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 585);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.rbConTy);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbChiNhanh);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnChonNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Button btnChonNhanVien;
        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtRePassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button btnDangKy;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RadioButton rbChiNhanh;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbConTy;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}