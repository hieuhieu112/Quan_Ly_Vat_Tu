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

//using project_qlvt;

namespace project_qlvt.subForm
{
    public partial class frmChonChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public static bool trangThaiKetQuanChuyenChiNhanh = false;
        public frmChonChiNhanh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChonChiNhanh_Load(object sender, EventArgs e)
        {
            cmbChiNhanhChon.DataSource = Program.bindingSource.DataSource;
            cmbChiNhanhChon.DisplayMember = "TENCN";
            cmbChiNhanhChon.ValueMember = "TENSERVER";
            cmbChiNhanhChon.SelectedIndex = Program.brand;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            trangThaiKetQuanChuyenChiNhanh = chuyenChiNhanh();
            if (trangThaiKetQuanChuyenChiNhanh)
            {
                this.Close();
            }
        }

        private bool chuyenChiNhanh()
        {
            string nameServerChiNhanh = cmbChiNhanhChon.SelectedValue.ToString();
            if (Program.serverName.Equals(nameServerChiNhanh))
            {
                MessageBox.Show("Nhân viên đã ở chi nhanh hiện tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string maChiNhanhHienTai = "";
            string maChiNhanhChuyenDen = "";


            if (nameServerChiNhanh.Contains("1"))
            {
                maChiNhanhHienTai = "CN2";
                maChiNhanhChuyenDen = "CN1";
            }
            else if (nameServerChiNhanh.Contains("2"))
            {
                maChiNhanhHienTai = "CN1";
                maChiNhanhChuyenDen = "CN2";
            }

            String cauTruyVan = "EXEC sp_ChuyenChiNhanh " + frmNhanVien.maNhanVienChuyenChiNhanh + ",'" + maChiNhanhChuyenDen + "'";
            SqlCommand sqlcommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);
                frmNhanVien.maNhanVienChuyenChiNhanh = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        private void cmbChiNhanhChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}