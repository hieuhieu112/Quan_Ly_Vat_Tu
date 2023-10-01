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
    public partial class frmKho : Form
    {
        string maChiNhanh = "";
        int vitri = 0;
        public frmKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);

            maChiNhanh = ((DataRowView)bdKho[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            if (Program.role == "CONGTY")
            {
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;
                groupBoxKho.Enabled = false;
                cmbChiNhanh.Enabled = true;
            }
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                cmbChiNhanh.Enabled = false;
            }

            

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdKho.Position;
            bdKho.AddNew();

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;

            btnGhi.Enabled = true;
            btnHoanTac.Enabled = true;

            txtMaKho.Enabled = true;

            khoGridControl.Enabled = false;

            txtMaCN.Text = maChiNhanh;
        }

        private bool kiemTraDauVao() 
        {
            if (txtMaKho.Text.Trim() == "") //Kiểm tra xem đã nhập ma số phiếu dặt chưa
            {
                MessageBox.Show("Mã số kho không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtTenKho.Text.Trim() == "") //Kiểm tra xem đã nhập ma số phiếu dặt chưa
            {
                MessageBox.Show("Tên kho không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDiaChi.Text.Trim() == "") //Kiểm tra xem đã nhập ma số phiếu dặt chưa
            {
                MessageBox.Show("Địa chỉ kho không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;    
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String makho = ((DataRowView)bdKho[bdKho.Position])["MaKho"].ToString();
            if (bdPhieuDat.Count > 0)
            {
                MessageBox.Show("Kho đã đã có trong phiếu đặt", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bdPhieuNhap.Count > 0)
            {
                MessageBox.Show("Kho đã đã có trong phiếu nhập", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bdPhieuXuat.Count > 0)
            {
                MessageBox.Show("Kho đã đã có trong phiếu xuất", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn đặt hàng ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdKho.Position;
                    bdKho.RemoveCurrent(); //Xóa trên mà hình 

                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.qLVTDataSet.Kho);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdKho.Position = vitri;
                    bdKho.Position = bdKho.Find("MaVT", int.Parse(makho));
                    return;
                }
            }

        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdKho.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdKho.Position = vitri;

            }
            btnThem.Enabled = btnThem.Enabled = true;
            btnHoanTac.Enabled = false;
            khoGridControl.Enabled = true;
            txtMaKho.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraDauVao()) return;

            //Kiểm tra xem mã vật tư có trùng không
            string maKho = txtMaKho.Text.Trim();
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaKho] '" +
                    maKho + "' " +
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
                MessageBox.Show("Mã kho này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
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

                        txtMaKho.Enabled = false;

                        this.bdKho.EndEdit();
                        this.khoTableAdapter.Update(this.qLVTDataSet.Kho);
                        this.khoGridControl.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        bdKho.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                /*Do du lieu tu dataSet vao grid Control*/
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);
            }
        }
    }
}
