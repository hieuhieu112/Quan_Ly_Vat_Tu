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
    public partial class frmPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdPX.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.Vattu' table. You can move, or remove it, as needed.

            qLVTDataSet.EnforceConstraints = false;

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);

            this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Fill(this.qLVTDataSet.DSNhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);

            // Phân quyền
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
            }

            groupBoxCTTPX.ContextMenuStrip = contextMenuStrip1;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdDSNV.Filter = "TrangThaiXoa <> '1'";
            cmbTenNhanVien.Refresh();


            viTri = bdPX.Position;
            bdPX.AddNew();

            this.phieuXuatGridControl.Enabled = false;

            this.btnXoa.Enabled = false;
            this.btnLamMoi.Enabled = false;
            this.btnThem.Enabled = false;

            this.btnHoanTac.Enabled = true;

            txtMaPX.Enabled = true;
            dateNgay.EditValue = DateTime.Now;
            dateNgay.Enabled = false;

            txtMaNV.Enabled = false;
            txtMaKho.Enabled = false;

            groupBoxTTCTPX.Enabled = false;


            bdDSNV.Filter = "MANV = " + "'" + Program.userName + "'";
            cmbTenNhanVien.Refresh();
            //
            cmbTenNhanVien.Enabled = false;

            txtMaPX.Focus();
        }

        private bool kiemTraDauVao() 
        {
            if (txtMaPX.Text == "")
            {
                MessageBox.Show("Mã phiếu xuất không đươc để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtHoTenHK.Text == "")
            {
                MessageBox.Show("Tên khách hàng không đươc để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Chưa chọn kho nhân viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraDauVao()) return;

            //Nếu update thì kiểm tra xem có trung không

            if (btnThem.Enabled)
            {
                String manv = ((DataRowView)bdPX[bdPX.Position])["MANV"].ToString();
                if (manv != Program.userName)
                {
                    MessageBox.Show("Không chỉnh sửa trên phiếu xuất của người khác!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    int viTriLoiQuyen = bdPX.Find("MAPX", txtMaPX.Text);
                    this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
                    bdPX.Position = viTriLoiQuyen;
                    return;
                }
            }


            String maPhieuXuat = txtMaPX.Text.Trim();

            String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_KiemTraMaPhieuXuat] '" +
                   maPhieuXuat + "' " +
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
                MessageBox.Show("Mã số phiếu xuất này đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
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


                        this.bdPX.EndEdit();
                        this.phieuXuatTableAdapter.Update(this.qLVTDataSet.PhieuXuat);
                        this.phieuXuatGridControl.Enabled = true;

                        groupBoxTTCTPX.Enabled = true;

                        MessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        bdPX.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    bdDSNV.Filter = "";
                    cmbTenNhanVien.Refresh();
                }
            }

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

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdPX.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdPX.Position = viTri;
            }
            btnThem.Enabled = btnXoa.Enabled = true;
            btnHoanTac.Enabled = false;
            phieuXuatGridControl.Enabled = true;
            btnHoanTac.Enabled = false;

            btnLamMoi.Enabled = true;

            bdDSNV.Filter = "";
            cmbTenNhanVien.Refresh();
            txtMaPX.Enabled = false;

            groupBoxTTCTPX.Enabled = true;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);

                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);

                this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNhanVienTableAdapter.Fill(this.qLVTDataSet.DSNhanVien);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            String manv = ((DataRowView)bdPX[bdPX.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên phiếu xuất của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPX.Find("MAPX", txtMaPX.Text);
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
                bdPX.Position = viTriLoiQuyen;
                return;
            }

            String maPhieuDat = ((DataRowView)bdPX[bdPX.Position])["MAPX"].ToString();

            

            List<string> listMaVTTrongCTDD = new List<string>();
            foreach (DataGridViewRow row in cTPXDataGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    listMaVTTrongCTDD.Add(row.Cells[1].Value.ToString());
                }
            }

            

            txtMaPXCT.Text = txtMaPX.Text;
            txtMaPXCT.Enabled = false;
            btnThemVT.Enabled = btnXoaVT.Enabled = false;
            btnHoanTacVT.Enabled = true;
            cTPXDataGridView.Enabled = false;


            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = false;

            groupBoxTTCTPX.ContextMenuStrip = contextMenuStrip1;
            cmbTenVT.SelectedIndex = -1;

            bdVT.Filter = String.Format("MAVT NOT IN ('{0}')",
                String.Join("','", listMaVTTrongCTDD));
            cmbTenVT.Refresh();

            bdCTTPX.AddNew();

            cTPXDataGridView.Enabled = false;

            btnThemVT.Enabled = true;
            cmbTenVT.Enabled = true;
            viTri = bdCTTPX.Position;

            btnThemVT.Enabled = false;
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            String manv = ((DataRowView)bdPX[bdPX.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên phiếu xuất của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPX.Find("MAPX", txtMaPX.Text);
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
                bdPX.Position = viTriLoiQuyen;
                return;
            }

            String maVT = ((DataRowView)bdCTTPX[bdCTTPX.Position])["MAVT"].ToString();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdCTTPX.Position;

                    //Cập nhập lại số lượng tồn (trừ)
                    capNhatSoLuongVatTu(txtMaVT.Text, (int)txtSoLuong.Value, "PLUS");

                    bdCTTPX.RemoveCurrent(); //Xóa trên mà hình 

                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPXTableAdapter.Update(this.qLVTDataSet.CTPX);



                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdCTTPX.Position = viTri;
                    bdCTTPX.Position = bdCTTPX.Find("MAVT", int.Parse(maVT));
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

            if (txtSoLuong.Value <= 0)
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

        private void capNhatSoLuongVatTu(string maVatTu, int soLuong, string type)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu '" + type + "','" + maVatTu + "', " + soLuong;
            int n = Program.ExecSqlNonQuery(cauTruyVan);
        }

        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            String manv = ((DataRowView)bdPX[bdPX.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên phiếu xuất của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPX.Find("MAPX", txtMaPX.Text);
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
                bdPX.Position = viTriLoiQuyen;
                return;
            }

            bool ktDauVaoDDH = kiemTraDauVaoCTDDH();

            if (!ktDauVaoDDH) return;

            String manvloi = ((DataRowView)bdPX[bdPX.Position])["MANV"].ToString();
            if (manvloi != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa chi  tiết phiếu đặt trên phiếu nhập của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra số lượng trong kho còn không
            int soLuongTon = int.Parse(((DataRowView)bdVT[bdVT.Position])["SOLUONGTON"].ToString());
            if (!btnThemVT.Enabled)
            { 
                if (txtSoLuong.Value > soLuongTon)
                {
                    MessageBox.Show("Số lượng tồn trong kho không đủ", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                int slVTCu = 0;
                foreach (DataGridViewRow row in cTPXDataGridView.Rows)
                {
                    if (row.Cells[2].Value != null
                        && row.Cells[1].Value.ToString() == txtMaVT.Text)
                    {
                        slVTCu = int.Parse(row.Cells[2].Value.ToString());
                        break;
                    }
                }
                int soLuongChenh = (int)Math.Abs(txtSoLuong.Value - slVTCu);
                if (txtSoLuong.Value > slVTCu) //Cộng thêm
                {
                    if (soLuongChenh > soLuongTon)
                    {
                        MessageBox.Show("Số lượng tồn trong kho không đủ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            if (btnThemVT.Enabled)
            {
                //foreach (DataGridViewRow row in cTPXDataGridView.Rows)
                //{
                //    if (row.Cells[2].Value != null
                //        && row.Cells[1].Value.ToString() == txtMaVT.Text)
                //    {
                //        MessageBox.Show("Vật tư đã tồn tại", "Thông báo",
                //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
                //}

                for (int i = 0; i < bdCTTPX.Count; ++i)
                {
                    string mavt = ((DataRowView)bdCTTPX[i])["MAVT"].ToString();
                    if (mavt == txtMaVT.Text && i != bdCTTPX.Position)
                    {
                        MessageBox.Show(mavt + " | " + txtMaVT.Text + " | " + bdCTTPX.Position + " | " + i);
                        MessageBox.Show("Vật tư đã tồn tại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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

                    

                    //Cập nhập lại số lượng
                    if (btnThemVT.Enabled) //edit
                    {
                        int slVTCu = 0;
                        foreach (DataGridViewRow row in cTPXDataGridView.Rows)
                        {
                            if (row.Cells[2].Value != null
                                && row.Cells[1].Value.ToString() == txtMaVT.Text)
                            {
                                slVTCu = int.Parse(row.Cells[2].Value.ToString());
                                break;
                            }
                        }
                        int soLuongChenh = (int)Math.Abs(txtSoLuong.Value - slVTCu);
                        if (txtSoLuong.Value > slVTCu) //trừ bớt
                        {
                            capNhatSoLuongVatTu(txtMaVT.Text, soLuongChenh, "MINUS");
                        }
                        else if (txtSoLuong.Value < slVTCu) //cộng thêm
                        {
                            capNhatSoLuongVatTu(txtMaVT.Text, soLuongChenh, "PLUS");
                        }
                    }
                    else //add:  Trừ số lượng trong kho
                    {
                        capNhatSoLuongVatTu(txtMaVT.Text, (int)txtSoLuong.Value, "MINUS");
                    }

                    this.bdCTTPX.EndEdit();
                    this.cTPXTableAdapter.Update(this.qLVTDataSet.CTPX);

                }
                catch (Exception ex)
                {
                    bdCTTPX.RemoveCurrent();
                    MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtMaPXCT.Enabled = true;
                btnThemVT.Enabled = btnXoaVT.Enabled = true;
                btnHoanTacVT.Enabled = false;
                cTPXDataGridView.Enabled = true;

                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = true;

            }
        }

        private void btnHoanTacVT_Click(object sender, EventArgs e)
        {
            bdVT.Filter = "";
            cmbTenVT.Refresh();

            bdCTTPX.CancelEdit();
            if (btnThemVT.Enabled == false)
            {
                bdCTTPX.Position = viTri;
            }
            btnThemVT.Enabled = btnXoaVT.Enabled = true;
            btnHoanTacVT.Enabled = false;


            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled =  btnLamMoi.Enabled = true;

            cTPXDataGridView.Enabled = true;

            cmbTenVT.Enabled = false;
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_EditValueChanged(object sender, EventArgs e)
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = ((DataRowView)bdPX[bdPX.Position])["MANV"].ToString();
            if (manv != Program.userName)
            {
                MessageBox.Show("Không chỉnh sửa trên phiếu xuất của người khác!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int viTriLoiQuyen = bdPX.Find("MAPX", txtMaPX.Text);
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
                bdPX.Position = viTriLoiQuyen;
                return;
            }

            String maPhieuXuat = ((DataRowView)bdPX[bdPX.Position])["MaPX"].ToString();
            if (bdCTTPX.Count > 0)
            {
                MessageBox.Show("Phiếu xuất đã có chi tiết phiếu xuất", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu xuất ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdPX.Position;
                    bdPX.RemoveCurrent(); //Xóa trên mà hình 

                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.qLVTDataSet.PhieuXuat);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập. Hãy thử lại\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdPX.Position = viTri;
                    bdPX.Position = bdPX.Find("MANV", int.Parse(maPhieuXuat));
                    return;
                }
            }
        }
    }
}