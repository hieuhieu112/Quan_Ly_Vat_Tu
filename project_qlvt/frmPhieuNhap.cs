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
using System.Data.SqlClient;

namespace project_qlvt
{
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public static string strListMaDDHCoPhieuNhap = "";
        public static string strListMaVTCoPhieuNhap = "";
        public static string maDonDatHang = "";

        String maChiNhanh = "";
        int viTri = 0;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.CTDDH' table. You can move, or remove it, as needed.
            qLVTDataSet.EnforceConstraints = false;

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);

            this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Fill(this.qLVTDataSet.DSNhanVien);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);

            //Phân quyền
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
            }


            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;

                //this.panelNhapLieu.Enabled = true;
            }

            groupBoxPhieuNhap.Enabled = true;
            txtMaPN.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaKho.Enabled = false;
            btnHoanTac.Enabled = false;

            txtNgayNhap.Enabled = false;
            txtMaSoDDH.Enabled = false;
            btnChonDDH.Enabled = false;

            groupBoxCTGridveiw.ContextMenuStrip = contextMenuStrip1;

            btnChonVatTu.Enabled = false;

            btnHoanTacVT.Enabled = false;
        }

        private void btnChonDDH_Click(object sender, EventArgs e)
        {
            viTri = bdPhieuNhap.Position;
            List<string> listMaDDTrongPhieuNhap = new List<string>();
            foreach (var item in bdPhieuNhap)
            {
                string columnValue = ((DataRowView)item)["MaSoDDH"].ToString();
                listMaDDTrongPhieuNhap.Add(columnValue);
            }

            strListMaDDHCoPhieuNhap = String.Join("','", listMaDDTrongPhieuNhap);

            frmChonDDH formChonDDH = new frmChonDDH();
            formChonDDH.ShowDialog();

            txtMaSoDDH.Text = frmChonDDH.maDonDatHangSubform;
            txtMaKho.Text = frmChonDDH.maKhoDonDatHangSubform;

            for (int i = 0; i < cmbTenKho.Items.Count; ++i)
            {
                if (((DataRowView)(cmbTenKho.Items[i])).Row[0].ToString() == frmChonDDH.maKhoDonDatHangSubform)
                {
                    cmbTenKho.SelectedIndex = i;
                    break;
                }
            }
        }

        private bool kiemTraDauVao()
        {
            if (txtMaPN.Text.Trim() == "") //Kiểm tra xem đã nhập ma số phiếu dặt chưa
            {
                MessageBox.Show("Mã số của phiếu nhập không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtMaSoDDH.Text == "")
            {
                MessageBox.Show("Chưa chọn đơn đặt hàng đặt", "Thông báo",
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

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraDauVao()) return;

            if (btnThem.Enabled)
            {
                String manv = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MANV"].ToString();
                if (manv != Program.userName)
                {
                    MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    int viTriLoiQuyen = bdPhieuNhap.Find("MAPN", txtMaPN.Text);
                    this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                    bdPhieuNhap.Position = viTriLoiQuyen;

                    return;
                }
            }

            String maPhieuNhap = txtMaPN.Text.Trim();

            String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_KiemTraMaPhieuNhap] '" +
                   maPhieuNhap + "' " +
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
                MessageBox.Show("Mã số phiếu nhập này đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
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

                        txtMaSoDDH.Enabled = false;

                        this.bdPhieuNhap.EndEdit();
                        this.phieuNhapTableAdapter.Update(this.qLVTDataSet.PhieuNhap);
                        this.phieuNhapGridControl.Enabled = true;

                        groupBoxThongTinCT.Enabled = true;

                        bdDSNV.Filter = "";
                        cmbTenNhanVien.Refresh();
                        groupBoxPhieuNhap.Enabled = false;

                        txtMaPN.Enabled = false;
                        btnLamMoi.Enabled = true;

                        MessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        bdPhieuNhap.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                       
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBoxPhieuNhap.Enabled = true;

            bdDSNV.Filter = "TrangThaiXoa <> '1'";
            cmbTenNhanVien.Refresh();


            viTri = bdPhieuNhap.Position;
            bdPhieuNhap.AddNew();


            this.phieuNhapGridControl.Enabled = false;

            this.btnXoa.Enabled = false;
            this.btnLamMoi.Enabled = false;
            this.btnThem.Enabled = false;

            this.btnHoanTac.Enabled = true;

            txtMaNV.Enabled = false;

            txtNgayNhap.EditValue = DateTime.Now;
            txtNgayNhap.Enabled = false;

            txtMaKho.Enabled = false;

            txtMaSoDDH.Enabled = false;

            bdDSNV.Filter = "MANV = " + "'" + Program.userName + "'";
            cmbTenNhanVien.Refresh();
            //
            txtMaPN.Enabled = true;
            txtMaPN.Focus();

            groupBoxThongTinCT.Enabled = false;

            btnChonDDH.Enabled = true;

        }

        private void cmbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenNhanVien.SelectedIndex != -1
                && cmbTenNhanVien.SelectedIndex < cmbTenNhanVien.Items.Count)
            {
                try
                {
                    string maNVSelected = cmbTenNhanVien.SelectedValue.ToString();
                    txtMaNV.Text = maNVSelected;
                }
                catch
                { }
            }
        }

        private void cmbTenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenKho.SelectedIndex != -1)
            {
                string maNVSelected = cmbTenKho.SelectedValue.ToString();
                txtMaKho.Text = maNVSelected;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);

                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);

                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);

                this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNhanVienTableAdapter.Fill(this.qLVTDataSet.DSNhanVien);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdPhieuNhap.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdPhieuNhap.Position = viTri;
            }
            btnLamMoi.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            btnHoanTac.Enabled = false;
            phieuNhapGridControl.Enabled = true;
            btnHoanTac.Enabled = false;
            

            bdDSNV.Filter = "";
            cmbTenNhanVien.Refresh();

           

            groupBoxThongTinCT.Enabled = true;
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {

            List<string> listMaVTTrongPhieuNhap = new List<string>();
            foreach (DataGridViewRow row in CTTPNDataGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    listMaVTTrongPhieuNhap.Add(row.Cells[1].Value.ToString());
                }
            }

            strListMaVTCoPhieuNhap = String.Join("','", listMaVTTrongPhieuNhap);

            maDonDatHang = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MasoDDH"].ToString();

            frmChonVatTu formChonVatTu = new frmChonVatTu();
            formChonVatTu.ShowDialog();


            txtMaVT.Text = frmChonVatTu.maVatTu;
            txtSoLuong.EditValue = frmChonVatTu.soLuongVatTu;
            txtDonGia.EditValue = frmChonVatTu.giaVatTu;

            for (int i = 0; i < cmbTenVT.Items.Count; ++i)
            {
                if (((DataRowView)(cmbTenVT.Items[i])).Row[0].ToString() == frmChonVatTu.maVatTu)
                {
                    cmbTenVT.SelectedIndex = i;
                    break;
                }
            }


        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            String manv = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPhieuNhap.Find("MAPN", txtMaPN.Text);
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                bdPhieuNhap.Position = viTriLoiQuyen;

                return;
            }

            String manvloi = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MANV"].ToString();
            if (manvloi != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPhieuNhap.Find("MAPN", txtMaPN.Text);
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                bdPhieuNhap.Position = viTriLoiQuyen;

                return;
            }
            viTri = bdCTPN.Position;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = false;

            bdCTPN.AddNew();

            txtMaPhieuNhapCT.Text = txtMaPN.Text;
            btnThemVT.Enabled = btnXoaVT.Enabled = false;
            btnHoanTacVT.Enabled = true;
            CTTPNDataGridView.Enabled = false;
            phieuNhapGridControl.Enabled = false;

            btnChonVatTu.Enabled = true;
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            String manv = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPhieuNhap.Find("MAPN", txtMaPN.Text);
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                bdPhieuNhap.Position = viTriLoiQuyen;

                return;
            }

            String manvloi = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MANV"].ToString();
            if (manvloi != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPhieuNhap.Find("MAPN", txtMaPN.Text);
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                bdPhieuNhap.Position = viTriLoiQuyen;

                return;
            }

            String maVT = ((DataRowView)bdCTPN[bdCTPN.Position])["MAVT"].ToString();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdCTPN.Position;

                    //Cập nhập lại số lượng tồn (trừ)
                    capNhatSoLuongVatTu(txtMaVT.Text, (int)txtSoLuong.Value, "MINUS");

                    bdCTPN.RemoveCurrent(); //Xóa trên mà hình 

                    this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPNTableAdapter.Update(this.qLVTDataSet.CTPN);

                    

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdCTPN.Position = viTri;
                    bdCTPN.Position = bdCTPN.Find("MAVT", int.Parse(maVT));
                    return;
                }
            }
        }

        private bool kiemTraDauVaoCTPN() 
        {
            if (txtMaVT.Text.Trim() == "") 
            {
                MessageBox.Show("Chưa chọn vật tư", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng vật tư phải lớn hơn 0", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            

            return true;
        }

        private void capNhatSoLuongVatTu(string maVatTu, int soLuong, string type)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu '"+ type +"','" + maVatTu + "', " + soLuong;
            int n = Program.ExecSqlNonQuery(cauTruyVan);
        }

        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            String manv = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPhieuNhap.Find("MAPN", txtMaPN.Text);
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                bdPhieuNhap.Position = viTriLoiQuyen;

                return;
            }

            if (!kiemTraDauVaoCTPN()) return;

            String manvloi = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MANV"].ToString();
            if (manvloi != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPhieuNhap.Find("MAPN", txtMaPN.Text);
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                bdPhieuNhap.Position = viTriLoiQuyen;

                return;
            }

            //Cập nhập phải kiểm tra lại số lượng có <= số lượng trong phiếu đặt không


            if (btnThemVT.Enabled) //Cập nhập
            {
                for(int i = 0; i < bdCTDDH.Count; ++i)
                {
                    string maVT = ((DataRowView)bdCTDDH[i])["MaVT"].ToString();
                    string maDDH = ((DataRowView)bdCTDDH[i])["MaSoDDH"].ToString();
                    if (maDDH == txtMaSoDDH.Text && txtMaVT.Text == maVT)
                    { 
                        int slVT = int.Parse(((DataRowView)bdCTDDH[i])["SOLUONG"].ToString());
                        if (txtSoLuong.Value > slVT)
                        {
                            MessageBox.Show("Số lượng vật phải <= số lượng vật tư trong phiếu đặt", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //Khôi phục lại số lượng vật tư cũ
                            foreach (DataGridViewRow row in CTTPNDataGridView.Rows)
                            {
                                if (row.Cells[2].Value != null 
                                    && row.Cells[1].Value.ToString() == txtMaVT.Text)
                                {
                                    txtSoLuong.EditValue = int.Parse(row.Cells[2].Value.ToString());
                                }
                            }

                            return;
                        }
                    }
                }
            }
            else 
            {

                if (txtSoLuong.Value > frmChonVatTu.soLuongVatTu)
                {
                    MessageBox.Show("Số lượng vật phải <= số lượng vật tư trong phiếu đặt", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                try
                {
                    if (btnThemVT.Enabled) //Cập nhập
                    {
                        int slVTCu = 0;
                        foreach (DataGridViewRow row in CTTPNDataGridView.Rows)
                        {
                            if (row.Cells[2].Value != null
                                && row.Cells[1].Value.ToString() == txtMaVT.Text)
                            {
                                slVTCu = int.Parse(row.Cells[2].Value.ToString());
                            }
                        }

                        int soLuongChenh = (int)Math.Abs(txtSoLuong.Value - slVTCu);
                        if (txtSoLuong.Value > slVTCu) //Cộng thêm
                        {
                            
                            capNhatSoLuongVatTu(txtMaVT.Text, soLuongChenh, "PLUS");
                        }
                        else if (txtSoLuong.Value < slVTCu) // trừ bớt
                        {
                            MessageBox.Show("ok");
                            capNhatSoLuongVatTu(txtMaVT.Text, soLuongChenh, "MINUS");
                        }
                    }
                    else // Thêm mới
                    {
                        capNhatSoLuongVatTu(txtMaVT.Text, (int)txtSoLuong.Value, "PLUS");
                    }

                    this.bdCTPN.EndEdit();
                    this.cTPNTableAdapter.Update(this.qLVTDataSet.CTPN);
                    MessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    bdCTPN.RemoveCurrent();
                    MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnThemVT.Enabled = btnXoaVT.Enabled = true;
                btnHoanTacVT.Enabled = false;
                CTTPNDataGridView.Enabled = true;
                phieuNhapGridControl.Enabled = true;

                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = true;

            }
        }

        private void btnHoanTacVT_Click(object sender, EventArgs e)
        {
            strListMaVTCoPhieuNhap = "";

            bdVT.Filter = "";
            cmbTenVT.Refresh();

            bdCTPN.CancelEdit();
            if (btnThemVT.Enabled == false)
            {
                bdCTPN.Position = viTri;
            }
            btnThemVT.Enabled = btnXoaVT.Enabled = true;
            btnHoanTacVT.Enabled = false;
            CTTPNDataGridView.Enabled = true;
            phieuNhapGridControl.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên đơn hàng của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPhieuNhap.Find("MAPN", txtMaPN.Text);
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                bdPhieuNhap.Position = viTriLoiQuyen;

                return;
            }

            String maPhieuNhap = ((DataRowView)bdPhieuNhap[bdPhieuNhap.Position])["MaPN"].ToString();
            if (bdCTPN.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã có chi tiết phiếu nhập", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdPhieuNhap.Position;
                    bdPhieuNhap.RemoveCurrent(); //Xóa trên mà hình 

                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.qLVTDataSet.PhieuNhap);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập. Hãy thử lại\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdPhieuNhap.Position = viTri;
                    bdPhieuNhap.Position = bdPhieuNhap.Find("MANV", int.Parse(maPhieuNhap));
                    return;
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
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);

                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);

                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);

                this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNhanVienTableAdapter.Fill(this.qLVTDataSet.DSNhanVien);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
            }
        }

        private void panelControlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}