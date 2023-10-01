using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace project_qlvt.report
{
    public partial class Xrpt_DonHangKhongCoPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DonHangKhongCoPhieuNhap()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
