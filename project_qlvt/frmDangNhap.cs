using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_qlvt
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoiDatabaseGoc() == 0)
                return;
            layDanhSachPhanManh("SELECT * FROM Get_Subscribes WHERE TENCN != 'Z_TRA_CUU'");
            cmbChiNhanh.SelectedIndex = 0;
            cmbChiNhanh.SelectedIndex = 1;
            cmbChiNhanh.SelectedIndex = 0;

            txtTenDangNhap.Text = "tt";
            txtMatKhau.Text = "123456";
        }

        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            da.Fill(dt);

            connPublisher.Close();
            Program.bindingSource.DataSource = dt;

            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "tencn";
            cmbChiNhanh.ValueMember = "tenserver";
            
        }

        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private bool checkInput() {
            txtTenDangNhap.Text = txtTenDangNhap.Text.Trim();
            txtMatKhau.Text = txtMatKhau.Text.Trim();

            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return false;
            }
            else if (txtMatKhau.Text == "") 
            {
                MessageBox.Show("Mật khẩu không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (checkInput()) {
                Program.loginName = txtTenDangNhap.Text;
                Program.loginPassword = txtMatKhau.Text;

                if (Program.KetNoi() == 0) return;

                Program.brand = cmbChiNhanh.SelectedIndex;

                String statement = "EXEC SP_Lay_Thong_Tin_NV_Tu_Login '" + Program.loginName + "'";
                Program.myReader = Program.ExecSqlDataReader(statement);

                Program.currentLogin = Program.loginName;
                Program.currentPassword = Program.loginPassword;

                if (Program.myReader == null) return;

                Program.myReader.Read();
                Program.userName = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.userName))
                {
                    MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", 
                        "Thông Báo", MessageBoxButtons.OK);
                }

                Program.staff = Program.myReader.GetString(1);
                Program.role = Program.myReader.GetString(2);

                //MessageBox.Show(Program.userName + " " + Program.staff + " " + Program.role);
                Program.myReader.Close();
                Program.conn.Close();

                Program.formMain.toolTipMaNhanVien.Text ="Mã Nhân Viên: " + Program.userName;
                Program.formMain.toolTipHoTen.Text = "Họ tên: " + Program.staff;
                Program.formMain.toolTipQuyen.Text = "Quyền: " + Program.role;

                //this.Close();
                this.Visible = false;
                Program.formMain.enableButtons();

                if (Program.role == "USER")
                {
                    Program.formMain.btnTaoTaiKhoan.Enabled = false;
                }
                else
                {
                    Program.formMain.btnTaoTaiKhoan.Enabled = true;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}