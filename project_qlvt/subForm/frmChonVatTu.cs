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

namespace project_qlvt.subForm
{
    public partial class frmChonVatTu : DevExpress.XtraEditors.XtraForm
    {
        public static string maVatTu = "";
        public static int soLuongVatTu = 0;
        public static float giaVatTu = 0;

        public frmChonVatTu()
        {
            InitializeComponent();
        }

        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdCTDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmChonVatTu_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);

            bdCTDDH.Filter = String.Format("MaSoDDH = '{0}' AND MAVT NOT IN ('{1}')",
                frmPhieuNhap.maDonDatHang, frmPhieuNhap.strListMaVTCoPhieuNhap);

            cTDDHGridControl.Refresh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (bdCTDDH.Count == 0)
            {
                MessageBox.Show("Không có bật tư!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
                return;
            }
            maVatTu = ((DataRowView)bdCTDDH[bdCTDDH.Position])["MaVT"].ToString();
            soLuongVatTu = int.Parse(((DataRowView)bdCTDDH[bdCTDDH.Position])["SOLUONG"].ToString());
            giaVatTu = float.Parse(((DataRowView)bdCTDDH[bdCTDDH.Position])["DONGIA"].ToString());

            this.Close();

        }
    }
}