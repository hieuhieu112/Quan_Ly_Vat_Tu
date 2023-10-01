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
    public partial class frmChiTietSoLuongTriGiaHangHoaNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietSoLuongTriGiaHangHoaNhapXuat()
        {
            InitializeComponent();
        }

        private void frmChiTietSoLuongTriGiaHangHoaNhapXuat_Load(object sender, EventArgs e)
        {
            cmbLoaiPhieu.SelectedIndex = 0;
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            string loaiPhieu = cmbLoaiPhieu.Text == "Nhập" ? "N" : "X";
            Xrpt_CTSoLuongTriGiaHangHoaNhapXuat xrpt = new Xrpt_CTSoLuongTriGiaHangHoaNhapXuat(
                Program.role, loaiPhieu, dateBatDau.DateTime, dateKetThuc.DateTime);

            xrpt.lblNgayBatDau.Text = "Ngày bắt đầu: " + dateBatDau.DateTime.ToString("dd/MM/yyyy");
            xrpt.lblNgayKetThuc.Text = "Ngày Kết thúc: " + dateKetThuc.DateTime.ToString("dd/MM/yyyy");


            ReportPrintTool printTool = new ReportPrintTool(xrpt);
            printTool.ShowPreviewDialog();
        }
    }
}