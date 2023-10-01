using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_qlvt.report
{
    public partial class frmBaoCaoDanhSachVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoDanhSachVatTu()
        {
            InitializeComponent();
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            Xrpt_DanhSachVatTu xrpt_DanhSachNhanVien = new Xrpt_DanhSachVatTu();
            ReportPrintTool printTool = new ReportPrintTool(xrpt_DanhSachNhanVien);
            printTool.ShowPreviewDialog();
        }
    }
}