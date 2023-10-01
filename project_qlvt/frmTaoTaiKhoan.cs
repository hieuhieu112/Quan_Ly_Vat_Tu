using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_qlvt.subForm;
using System.Data.SqlClient;

namespace project_qlvt
{
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        public static string maNhanVien = "";
        public static string hoTenNhanVien = "";

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.role == "CONGTY")
            {

                rbChiNhanh.Enabled = rbUser.Enabled = false;
                rbConTy.Checked = true;
                rbConTy.Enabled = false;

            }
            else if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                rbConTy.Enabled = false;
                rbUser.Checked = true;   
            }
        }

        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            frmChonNhanVien formChonNhanVien = new frmChonNhanVien();
            formChonNhanVien.ShowDialog();

            txtMaNhanVien.Text = frmTaoTaiKhoan.maNhanVien;
            txtTenDangNhap.Text = frmTaoTaiKhoan.hoTenNhanVien + frmTaoTaiKhoan.maNhanVien;
        }

        private bool kiemTraDauVao()
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtRePassword.Focus();
                return false;
            }

            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!kiemTraDauVao()) return;

            String vaiTro = "CONGTY";
            if (Program.role == "CHINHANH")
            {
                vaiTro = (rbChiNhanh.Checked == true) ? "CHINHANH" : "USER";
            }

            String cauTruyVan =
                    "EXEC sp_TaoTaiKhoan '" + (frmTaoTaiKhoan.hoTenNhanVien + frmTaoTaiKhoan.maNhanVien) + "' , '" + txtPassword.Text + "', '"
                    + frmTaoTaiKhoan.maNhanVien + "', '" + vaiTro + "'";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}