using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using project_qlvt.report;

namespace project_qlvt
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmDangNhap form = new frmDangNhap();
            //form.ShowDialog();

            Form f = this.CheckExists(typeof(frmDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formDangNhap = new frmDangNhap();
                //form.MdiParent = this;
                Program.formDangNhap.ShowDialog();
            }
        }

        private void toolTipMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formNhanVien = new frmNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formVatTu = new frmVatTu();
                Program.formVatTu.MdiParent = this;
                Program.formVatTu.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmKho));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formKho = new frmKho();
                Program.formKho.MdiParent = this;
                Program.formKho.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rbNhapXuat.Visible = false;
            rbBaoCao.Visible = false;
            btnTaoTaiKhoan.Enabled = false;
        }

        public void enableButtons()
        {

            btnDangNhap.Enabled = false;
            btnDangSuat.Enabled = true;

            rbNhapXuat.Visible = true;
            rbBaoCao.Visible = true;
            //pageBaoCao.Visible = true;
            //btnLapTaiKhoan.Enabled = true;

            //if (Program.role == "USER")
            //{
            //    btnLapTaiKhoan.Enabled = false;
            //}

            //pageTaiKhoan.Visible = true;


        }

        private void btnPhieuDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmPhieuDat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formPhieuDat = new frmPhieuDat();
                Program.formPhieuDat.MdiParent = this;
                Program.formPhieuDat.Show();
            }
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formPhieuNhap = new frmPhieuNhap();
                Program.formPhieuNhap.MdiParent = this;
                Program.formPhieuNhap.Show();
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmPhieuXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formPhieuXuat = new frmPhieuXuat();
                Program.formPhieuXuat.MdiParent = this;
                Program.formPhieuXuat.Show();
            }
        }

        private void btnDangSuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
                f1.Dispose();

            btnDangNhap.Enabled = true;
            btnDangSuat.Enabled = false;

            rbNhapXuat.Visible = false;
            rbBaoCao.Visible = false;   

            btnTaoTaiKhoan.Enabled = false;

            Form f = this.CheckExists(typeof(frmDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formDangNhap = new frmDangNhap();
                Program.formDangNhap.txtTenDangNhap.Text = "";
                Program.formDangNhap.txtMatKhau.Text = "";
                Program.formDangNhap.ShowDialog();
            }
        }

        private void btnDsNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoCaoDanhSachNhanVien frmBaoCao = new frmBaoCaoDanhSachNhanVien();
            frmBaoCao.ShowDialog();
        }

        private void btnBaoCaoDSVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoCaoDanhSachVatTu frmBaoCao = new frmBaoCaoDanhSachVatTu();
            frmBaoCao.ShowDialog();
        }

        private void btnBaoCaoDSVTTheoGiaTri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChiTietSoLuongTriGiaHangHoaNhapXuat frmBaoCao = new frmChiTietSoLuongTriGiaHangHoaNhapXuat();
            frmBaoCao.ShowDialog();
        }

        private void btnDonDatHangKhongCoPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoCaoDonHangKhongCoPhieuNhap frmBaoCao = new frmBaoCaoDonHangKhongCoPhieuNhap();
            frmBaoCao.ShowDialog();
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.formToTaiKhoan = new frmTaoTaiKhoan();
                //Program.formToTaiKhoan.MdiParent = this;
                Program.formToTaiKhoan.ShowDialog();
            }
        }
    }
}
