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
    public partial class frmVatTu : Form
    {
        int vitri = 0;
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);

            if (Program.role == "CONGTY")
            {
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;

            }
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
            }

        }

        private void vattuBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private bool kiemTraDauVao() 
        {
            if (txtMaVT.Text.Trim() == "") //Kiểm tra xem đã nhập ma số phiếu dặt chưa
            {
                MessageBox.Show("Mã số vật tư không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDVT.Text.Trim() == "") //Kiểm tra xem đã nhập ma số phiếu dặt chưa
            {
                MessageBox.Show("Đơn vị vật tư không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtTenVT.Text.Trim() == "") //Kiểm tra xem đã nhập ma số phiếu dặt chưa
            {
                MessageBox.Show("Tên vật tư không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdVT.Position;
            bdVT.AddNew();

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;

            btnGhi.Enabled = true;
            btnHoanTac.Enabled = true;

            txtMaVT.Enabled = true;

            vattuGridControl.Enabled = false;
            txtSoLuong.EditValue = 0;
        }

        private int kiemTraVatTuCoSuDungTaiChiNhanhKhac(String maVatTu)
        {
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaVatTuChiNhanhConLai '" +
                    maVatTu + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 1;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            //Console.WriteLine("line 535");
            //Console.WriteLine(result);
            Program.myReader.Close();

            /*result = 1 nghia la vat tu nay dang duoc su dung o chi nhanh con lai*/
            int ketQua = (result == 1) ? 1 : 0;

            return ketQua;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maPhieuDat = ((DataRowView)bdVT[bdVT.Position])["MaVT"].ToString();
            if (bdCTDDH.Count > 0)
            {
                MessageBox.Show("Vật tư đã có trong chi tiết đơn đặt hàng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bdCTPN.Count > 0)
            {
                MessageBox.Show("Vật tư đã có trong chi tiết phiếu nhập", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String maVatTu = txtMaVT.Text.Trim();// Trim() de loai bo khoang trang thua
            int ketQua = kiemTraVatTuCoSuDungTaiChiNhanhKhac(maVatTu);

            if (ketQua == 1)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đang được sử dụng ở chi nhánh khác", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }



            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn đặt hàng ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdVT.Position;
                    bdVT.RemoveCurrent(); //Xóa trên mà hình 

                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.qLVTDataSet.Vattu);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdVT.Position = vitri;
                    bdVT.Position = bdVT.Find("MaVT", int.Parse(maPhieuDat));
                    return;
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraDauVao()) return;

            //Kiểm tra xem mã vật tư có trùng không
            string maVT = txtMaVT.Text.Trim();
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_KiemTraMaVatTu] '" +
                    maVT + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            if (result == 1 && btnThem.Enabled == false)
            {
                MessageBox.Show("Mã vật tư này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnGhi.Enabled = true;
                        btnHoanTac.Enabled = false;
                        btnLamMoi.Enabled = true;

                        txtMaVT.Enabled = false;

                        this.bdVT.EndEdit();
                        this.vattuTableAdapter.Update(this.qLVTDataSet.Vattu);
                        this.vattuGridControl.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        bdVT.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdVT.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdVT.Position = vitri;

            }
            btnThem.Enabled = btnThem.Enabled = true;
            btnHoanTac.Enabled = false;
            vattuGridControl.Enabled = true;
            txtMaVT.Enabled=false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
