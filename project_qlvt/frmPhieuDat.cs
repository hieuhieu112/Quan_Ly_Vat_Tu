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

namespace project_qlvt
{
    public partial class frmPhieuDat : DevExpress.XtraEditors.XtraForm
    {
        String maChiNhanh = "";
        int viTri = 0;

        int viTriCTDDH = 0;

        public frmPhieuDat()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdPhieuDat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmPhieuDat_Load(object sender, EventArgs e)
        {

            CTDDHDataGridView.ContextMenuStrip = this.contextMenuStrip1;

            qLVTDataSet.EnforceConstraints = false;

            this.datHangAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);

            this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Fill(this.qLVTDataSet.DSNhanVien);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);

            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;
                this.btnHoanTac.Enabled = false;

                groupBoxCTTDH.Enabled = false;
            }


            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;

                //this.panelNhapLieu.Enabled = true;
                groupBoxCTTDH.Enabled = true;
            }

            txtMaSoDDH.Enabled = false;
            txtMaVT.Enabled = false;
            txtMaNhanVien.Enabled = false;
            btnHoanTac.Enabled = false;
            txtMaKho.Enabled = false;

            
        }

        private void nGAYDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdPhieuDat.Position;
            bdPhieuDat.AddNew();

            this.datHangGridControl.Enabled = false;
            this.groupCTDDH.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnLamMoi.Enabled = false;
            this.btnThem.Enabled = false;
            this.datHangGridControl.Enabled = false;

            this.btnHoanTac.Enabled = true;

            txtMaNhanVien.Text = Program.userName;
            txtMaNhanVien.ReadOnly = true;

            dateNgayDat.EditValue = DateTime.Now;
            txtMaSoDDH.Enabled = true;

            dateNgayDat.Enabled = false;

            bdDSNhanVien.Filter = "MANV = " + "'" + Program.userName +"'";
            cmbTenNhanVien.Refresh();
            //
            cmbTenNhanVien.Enabled = false;

            txtMaSoDDH.Focus(); 
        }

        //Viết hàm kiểm tra input đầu vào có hợp lệ hay không
        private bool kiemTraDauVao()
        {
            if (txtMaSoDDH.Text.Trim() == "") //Kiểm tra xem đã nhập ma số phiếu dặt chưa
            {
                MessageBox.Show("Mã số của phiếu đặt không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtNhaCungCap.Text.Trim() == "")
            {
                MessageBox.Show("Nhà cung cấp của phiếu đặt không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbTenNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbTenKho.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn kho", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private bool trangThaiXoa(string manv)
        {
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_LayTrangThaiXoaNhanVien] '" +
                    manv + "' " +
                    "SELECT 'Value' = @result";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);

            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            return result == 1;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool kiemTraDauVaoInput = kiemTraDauVao();

            //if (trangThaiXoa(txtMaNhanVien.Text))
            //{
            //    MessageBox.Show("Nhân viên không có trong chi nhanh", "Thông báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (!kiemTraDauVaoInput) return;

            if (btnThem.Enabled) //edit
            {
                if (bdPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Đơn đặt hàng đã có phiếu nhập, không thể chỉnh sửa", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    int viTriLoiQuyen = bdPhieuDat.Find("MASODDH", txtMaSoDDH.Text);
                    this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
                    bdPhieuDat.Position = viTriLoiQuyen;

                    return;
                }
                String manv = ((DataRowView)bdPhieuDat[bdPhieuDat.Position])["MANV"].ToString();
                if (manv != Program.userName)
                {
                    int viTriLoiQuyen = bdPhieuDat.Find("MASODDH", txtMaSoDDH.Text);
                    this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
                    bdPhieuDat.Position = viTriLoiQuyen;

                    MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            String maPhieuDat = txtMaSoDDH.Text.Trim();

            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_KiemTraMaDonDatHang] '" +
                    maPhieuDat + "' " +
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
                MessageBox.Show("Mã số phiếu đặt này đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
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
                        btnHoanTac.Enabled = true;

                        txtMaSoDDH.Enabled = false;

                        this.bdPhieuDat.EndEdit();
                        this.datHangAdapter.Update(this.qLVTDataSet.DatHang);
                        this.datHangGridControl.Enabled = true;

                        MessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        bdPhieuDat.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    bdDSNhanVien.Filter = "";
                    cmbTenNhanVien.Refresh();
                    this.groupCTDDH.Enabled = true;
                }
            }
        }

        private void txtMaNhanVien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenNhanVien.SelectedIndex != -1)
            {
                string maNVSelected = cmbTenNhanVien.SelectedValue.ToString();
                txtMaNhanVien.Text = maNVSelected;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdPhieuDat.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdPhieuDat.Position = viTri;
            }
            btnThem.Enabled = btnXoa.Enabled = true;
            btnHoanTac.Enabled = false;
            datHangGridControl.Enabled = true;
            btnHoanTac.Enabled = false;
            btnLamMoi.Enabled = true;

            bdDSNhanVien.Filter = "";
            cmbTenNhanVien.Refresh();
        }

        private void cmbTenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenKho.SelectedIndex != -1)
            {
                string maNVSelected = cmbTenKho.SelectedValue.ToString();
                txtMaKho.Text = maNVSelected;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = ((DataRowView)bdPhieuDat[bdPhieuDat.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                int viTriLoiQuyen = bdPhieuDat.Find("MASODDH", txtMaSoDDH.Text);
                this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
                bdPhieuDat.Position = viTriLoiQuyen;

                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String maPhieuDat = ((DataRowView)bdPhieuDat[bdPhieuDat.Position])["MasoDDH"].ToString();
            if (bdPhieuNhap.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã có phiếu nhập", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bdCTDDH.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã có chi tiết phiếu đặt", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn đặt hàng ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdPhieuDat.Position;
                    bdPhieuDat.RemoveCurrent(); //Xóa trên mà hình 

                    this.datHangAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangAdapter.Update(this.qLVTDataSet.DatHang);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdPhieuDat.Position = viTri;
                    bdPhieuDat.Position = bdPhieuDat.Find("MANV", int.Parse(maPhieuDat));
                    return;
                }
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            String maPhieuDat = ((DataRowView)bdPhieuDat[bdPhieuDat.Position])["MasoDDH"].ToString();
            if (bdPhieuNhap.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã có phiếu nhập, Không thể thêm", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String manv = ((DataRowView)bdPhieuDat[bdPhieuDat.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                int viTriLoiQuyen = bdPhieuDat.Find("MASODDH", txtMaSoDDH.Text);
                this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
                bdPhieuDat.Position = viTriLoiQuyen;

                MessageBox.Show("Không chỉnh sửa chi  tiết phiếu đặt trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bdCTDDH.AddNew();

            CTDDHDataGridView.Enabled = false;
            groupBoxCTTDH.Enabled = true;

            List<string> listMaVTTrongCTDD = new List<string>();
            foreach (DataGridViewRow row in CTDDHDataGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    listMaVTTrongCTDD.Add(row.Cells[1].Value.ToString());
                }
            }

            bdVT.Filter = String.Format("MAVT NOT IN ('{0}')",
                String.Join("','", listMaVTTrongCTDD));
            cmbTenVT.Refresh();

            txtMaSoDDHCT.Text = txtMaSoDDH.Text;
            txtMaSoDDHCT.Enabled = false;
            btnThemVT.Enabled = btnXoaVT.Enabled = false;
            btnHoanTacVT.Enabled = true;
            CTDDHDataGridView.Enabled = false;
            groupBoxCTTDH.Enabled = true;

            txtMaVT.Text = cmbTenVT.SelectedValue.ToString();   

            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = false;

            groupBoxCTTDH.ContextMenuStrip = contextMenuStrip1;

            CTDDHDataGridView.Enabled = false;
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            String manv = ((DataRowView)bdPhieuDat[bdPhieuDat.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                int viTriLoiQuyen = bdPhieuDat.Find("MASODDH", txtMaSoDDH.Text);
                this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
                bdPhieuDat.Position = viTriLoiQuyen;

                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String maVT = ((DataRowView)bdCTDDH[bdCTDDH.Position])["MAVT"].ToString();
            if (bdPhieuNhap.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã có phiếu nhập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdCTDDH.Position;
                    bdCTDDH.RemoveCurrent(); //Xóa trên mà hình 

                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTDDHTableAdapter.Update(this.qLVTDataSet.CTDDH);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.CTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdCTDDH.Position = viTri;
                    bdCTDDH.Position = bdCTDDH.Find("MAVT", int.Parse(maVT));
                    return;
                }
            }

        }


        private bool kiemTraDauVaoCTDDH()
        {
            if (cmbTenVT.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn vật tư", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSoLuongVT.Value <= 0)
            {
                MessageBox.Show("Số lượng vật tư phải lớn hơn 0", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá vật tư phải lớn hơn 0", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool kiemTraVatTuCoTrongDDH()
        {
            int viTriVT = bdCTDDH.Position;

            String maVTTrongCTDDH = txtMaVT.Text;
            foreach (DataGridViewRow row in CTDDHDataGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    string maVT = row.Cells[1].Value.ToString();
                    
                    if (maVT.Trim() == maVTTrongCTDDH.Trim() && row.Index != viTriVT)
                    {
                        MessageBox.Show("Vật tư này đã có trong đơn đặt hàng", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            String maPhieuDat = ((DataRowView)bdPhieuDat[bdPhieuDat.Position])["MasoDDH"].ToString();
            if (bdPhieuNhap.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã có phiếu nhập, Không cập nhật", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPhieuDat.Find("MASODDH", txtMaSoDDH.Text);
                this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
                bdPhieuDat.Position = viTriLoiQuyen;

                return;
            }

            String manv = ((DataRowView)bdPhieuDat[bdPhieuDat.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                int viTriLoiQuyen = bdPhieuDat.Find("MASODDH", txtMaSoDDH.Text);
                this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);
                bdPhieuDat.Position = viTriLoiQuyen;

                MessageBox.Show("Không chỉnh sửa chi  tiết phiếu đặt trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ktDauVaoDDH = kiemTraDauVaoCTDDH();

            if (!ktDauVaoDDH) return;

            if (btnThemVT.Enabled == true) // edit
            {
                if (!kiemTraVatTuCoTrongDDH())
                {
                    this.CTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);
                    return;
                }
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    if (btnThemVT.Enabled == false)
                    {
                        bdVT.Filter = "";
                        cmbTenVT.Refresh();
                    }

                    this.bdCTDDH.EndEdit();
                    this.CTDDHTableAdapter.Update(this.qLVTDataSet.CTDDH);
                    this.datHangGridControl.Enabled = true;

                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    bdCTDDH.RemoveCurrent();
                    MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

                btnThemVT.Enabled = btnXoaVT.Enabled = true;
                btnHoanTacVT.Enabled = false;
                CTDDHDataGridView.Enabled = true;

                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = true;

            }
        }

        private void datHangGridControl_Click(object sender, EventArgs e)
        {

        }

        private void cmbTenVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenVT.SelectedIndex != -1)
            {
                string maNVSelected = cmbTenVT.SelectedValue.ToString();
                txtMaVT.Text = maNVSelected;
            }
        }

        private void btnHoanTacVT_Click(object sender, EventArgs e)
        {
            bdVT.Filter = "";
            cmbTenVT.Refresh();

            bdCTDDH.CancelEdit();
            if (btnThemVT.Enabled == false)
            {
                bdCTDDH.Position = viTri;
            }
            btnThemVT.Enabled = btnXoaVT.Enabled = true;
            btnHoanTacVT.Enabled = false;
            CTDDHDataGridView.Enabled = true;
            groupBoxCTTDH.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = true;

            //bdDSNhanVien.Filter = "";
            //cmbTenNhanVien.Refresh();
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
                this.datHangAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangAdapter.Fill(this.qLVTDataSet.DatHang);

                this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);

                this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNhanVienTableAdapter.Fill(this.qLVTDataSet.DSNhanVien);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);

                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}