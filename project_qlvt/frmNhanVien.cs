using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using project_qlvt.subForm;

namespace project_qlvt
{
    public partial class frmNhanVien : Form
    {
        String maChiNhanh = "";
        int viTri = 0;

        public static string maNhanVienChuyenChiNhanh = "";

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            /*Step 1*/
            /*không kiểm tra khóa ngoại nữa*/
            qLVTDataSet.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NhanVien);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);
            
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;   
            this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);

            maChiNhanh = ((DataRowView)bdNhanVien[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThemNhanVien.Enabled = false;
                this.btnXoaNhanVien.Enabled = false;
                this.btnGhiNhanVien.Enabled = false;

                this.panelNhapLieu.Enabled = false;
                this.btnChuyenChiNhanh.Enabled = false;
                this.btnHoanTac.Enabled = false;
            }

            
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnThemNhanVien.Enabled = true;
                this.btnXoaNhanVien.Enabled = true;

                this.panelNhapLieu.Enabled = true;

                this.btnChuyenChiNhanh.Enabled = true;
                this.btnHoanTac.Enabled = true;
            }
        }

        private void btnThemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdNhanVien.Position;
            bdNhanVien.AddNew();
            nhanVienGridControl.Enabled = false;

            dateNgaySinhNhanVien.EditValue = "2000-05-01";
            txtLuongNhanVien.Text = "4000000";
            //txtLuongNhanVien.Value = 4000000;// dat san muc luong toi thieu

            btnLamMoi.Enabled = btnThemNhanVien.Enabled = btnXoaNhanVien.Enabled = btnChuyenChiNhanh.Enabled = false;
            btnHoanTac.Enabled = true;

            txtMaCNNhanVien.Text = maChiNhanh;
            trangThaiXoaCheckBox.Checked = false;

            txtMaNhanVien.Enabled = true;
            
        }

        private void txtMaCNNhanVien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdNhanVien.CancelEdit();
            if (btnThemNhanVien.Enabled == false) 
            {
                bdNhanVien.Position = viTri;

            }
            btnLamMoi.Enabled = btnThemNhanVien.Enabled = btnXoaNhanVien.Enabled = btnChuyenChiNhanh.Enabled = true;
            btnHoanTac.Enabled = false;
            btnGhiNhanVien.Enabled = true;

            txtMaNhanVien.Enabled = false;
            nhanVienGridControl.Enabled = true;

        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private bool kiemTraDuLieu() 
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNhanVien.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtMaNhanVien.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã nhân viên phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNhanVien.Focus();
                return false;
            }
            else if (txtHoNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoNhanVien.Focus();
                return false;
            }
            else if (txtHoNhanVien.Text.Length > 40)
            {
                MessageBox.Show("Họ không dài quá 40 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoNhanVien.Focus();
                return false;
            }
            else if (txtTenNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhanVien.Focus();
                return false;
            }
            else if (txtTenNhanVien.Text.Length > 10)
            {
                MessageBox.Show("Tên không dài quá 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoNhanVien.Focus();
                return false;
            }
            else if (txtDiaChiNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChiNhanVien.Focus();
                return false;
            }
            else if (txtDiaChiNhanVien.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ nhân viên không dài quá 100 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChiNhanVien.Focus();
                return false;
            }
            else if (txtLuongNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Lương nhân viên không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuongNhanVien.Focus();
                return false;

            }
            else if (CalculateAge(dateNgaySinhNhanVien.DateTime) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dateNgaySinhNhanVien.Focus();
                return false;
            }

            try
            {
                double luong = Double.Parse(txtLuongNhanVien.Text);
                if (luong < 40000)
                {
                    MessageBox.Show("Lương nhân viên tối thiểu là 40000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLuongNhanVien.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lương nhân là ký tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuongNhanVien.Focus();
                return false;
            }

            return true;
        }

        private void btnGhiNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           bool resultCheckInput = kiemTraDuLieu();
            if (!resultCheckInput)
                return;

            String maNhanVien = txtMaNhanVien.Text.Trim();

            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaNhanVien] '" +
                    maNhanVien + "' " +
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

            int viTriBdNhanVien = bdNhanVien.Position;
            int vitriNhanVienMa = bdNhanVien.Find("MANV", maNhanVien);

            if (result == 1 && vitriNhanVienMa != viTriBdNhanVien)
            {
                MessageBox.Show("Mã nhân viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
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
                        btnLamMoi.Enabled = btnThemNhanVien.Enabled = btnXoaNhanVien.Enabled = btnChuyenChiNhanh.Enabled = true;
                        btnHoanTac.Enabled = false;
                        btnGhiNhanVien.Enabled = true;

                        txtMaNhanVien.Enabled = false;
                        
                        this.bdNhanVien.EndEdit();
                        this.nhanVienTableAdapter.Update(this.qLVTDataSet.NhanVien);
                        this.nhanVienGridControl.Enabled = true;

                        MessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        bdNhanVien.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NhanVien);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoaNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tenNV = ((DataRowView)bdNhanVien[bdNhanVien.Position])["MANV"].ToString();

            // khong cho xoa nguoi dang dang nhap ke ca nguoi do khong co don hang - phieu nhap - phieu xuat
            if (tenNV == Program.userName)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdDatHang.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdNhanVien.Position;
                    bdNhanVien.RemoveCurrent(); //Xóa trên mà hình 

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.qLVTDataSet.NhanVien);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NhanVien);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdNhanVien.Position = viTri;
                    bdNhanVien.Position = bdNhanVien.Find("MANV", int.Parse(tenNV));
                    return;
                }
            }
        }

        private void btnChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int viTriHienTai = bdNhanVien.Position;
            int trangThaiXoa = int.Parse(((DataRowView)(bdNhanVien[viTriHienTai]))["TrangThaiXoa"].ToString());
            string maNhanVien = ((DataRowView)bdNhanVien[viTriHienTai])["MANV"].ToString();

            if (maNhanVien == Program.userName)
            {
                MessageBox.Show("Không thể chuyển nhân viên mà tài khoản đang đăng nhập",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (trangThaiXoa == 1)
            {
                MessageBox.Show("Nhân viên không có trong chi nhanh",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            maNhanVienChuyenChiNhanh = maNhanVien;
            
            frmChonChiNhanh formChonChiNhanh = new frmChonChiNhanh();
            formChonChiNhanh.ShowDialog();

            if (frmChonChiNhanh.trangThaiKetQuanChuyenChiNhanh == true)
            {
                this.nhanVienTableAdapter.Update(qLVTDataSet.NhanVien);
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NhanVien);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qLVTDataSet.DatHang);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);
                /*Tu dong lay maChiNhanh hien tai - phuc vu cho phan btnTHEM*/
                /*Cho dong nay chay thi bi loi*/
                //maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString().Trim();
            }
        }
    }
}
