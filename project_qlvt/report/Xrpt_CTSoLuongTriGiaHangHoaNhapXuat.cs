using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace project_qlvt.report
{
    public partial class Xrpt_CTSoLuongTriGiaHangHoaNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_CTSoLuongTriGiaHangHoaNhapXuat(string quyen, string loaiPhieu, 
            DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = quyen;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = loaiPhieu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngayBatDau;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = ngayKetThuc;

            this.sqlDataSource1.Fill();
        }


        public Xrpt_CTSoLuongTriGiaHangHoaNhapXuat()
        {
            InitializeComponent();
        }
    }
}
