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



namespace project_qlvt.subForm
{
    public partial class frmChonDDH : DevExpress.XtraEditors.XtraForm
    {
        public static string maDonDatHangSubform = "";
        public static string maKhoDonDatHangSubform = "";

        public frmChonDDH()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmChonDDH_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);

            bdDDH.Filter = String.Format("MaSoDDH NOT IN ('{0}')",frmPhieuNhap.strListMaDDHCoPhieuNhap);
            datHangGridControl.Refresh();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            maDonDatHangSubform = ((DataRowView)bdDDH[bdDDH.Position])["MasoDDH"].ToString();
            maKhoDonDatHangSubform = ((DataRowView)bdDDH[bdDDH.Position])["MaKho"].ToString();
            this.Close();
        }

    }
}