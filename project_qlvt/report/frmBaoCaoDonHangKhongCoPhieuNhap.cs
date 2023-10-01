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
using project_qlvt.report;
using DevExpress.XtraReports.UI;

namespace project_qlvt.report
{
    public partial class frmBaoCaoDonHangKhongCoPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoDonHangKhongCoPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDonHangKhongCoPhieuNhap_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xrpt_DonHangKhongCoPhieuNhap xrpt = new Xrpt_DonHangKhongCoPhieuNhap();
            ReportPrintTool printTool = new ReportPrintTool(xrpt);
            printTool.ShowPreviewDialog();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbChiNhanh.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbChiNhanh.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                //this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NhanVien);
            }
        }
    }
}