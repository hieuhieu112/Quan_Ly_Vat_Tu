namespace project_qlvt
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangSuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuDat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDsNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoDSVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoDSVTTheoGiaTri = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonDatHangKhongCoPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.rbNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbVatTu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbKho = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNhapXuatVT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTipMaNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipQuyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(44, 46, 44, 46);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnDangSuat,
            this.btnNhanVien,
            this.btnVatTu,
            this.btnKho,
            this.btnPhieuDat,
            this.btnPhieuNhap,
            this.btnPhieuXuat,
            this.btnDsNhanVien,
            this.btnBaoCaoDSVT,
            this.btnBaoCaoDSVTTheoGiaTri,
            this.btnDonDatHangKhongCoPhieuNhap,
            this.btnTaoTaiKhoan});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 481;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbNhapXuat,
            this.rbBaoCao,
            this.rbHeThong});
            this.ribbonControl1.Size = new System.Drawing.Size(1173, 193);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangSuat
            // 
            this.btnDangSuat.Caption = "Đăng Suất";
            this.btnDangSuat.Enabled = false;
            this.btnDangSuat.Id = 2;
            this.btnDangSuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangSuat.ImageOptions.Image")));
            this.btnDangSuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangSuat.ImageOptions.LargeImage")));
            this.btnDangSuat.Name = "btnDangSuat";
            this.btnDangSuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangSuat_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 3;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật Tư";
            this.btnVatTu.Id = 5;
            this.btnVatTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.Image")));
            this.btnVatTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.LargeImage")));
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 6;
            this.btnKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.Image")));
            this.btnKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.LargeImage")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnPhieuDat
            // 
            this.btnPhieuDat.Caption = "Phiếu đặt";
            this.btnPhieuDat.Id = 7;
            this.btnPhieuDat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuDat.ImageOptions.SvgImage")));
            this.btnPhieuDat.Name = "btnPhieuDat";
            this.btnPhieuDat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuDat_ItemClick);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Caption = "Phiếu Nhập";
            this.btnPhieuNhap.Id = 8;
            this.btnPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuNhap.ImageOptions.SvgImage")));
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuNhap_ItemClick);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Caption = "Phiết xuất";
            this.btnPhieuXuat.Id = 9;
            this.btnPhieuXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuXuat.ImageOptions.SvgImage")));
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuXuat_ItemClick);
            // 
            // btnDsNhanVien
            // 
            this.btnDsNhanVien.Caption = "Danh sách nhân viên";
            this.btnDsNhanVien.Id = 10;
            this.btnDsNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDsNhanVien.ImageOptions.SvgImage")));
            this.btnDsNhanVien.Name = "btnDsNhanVien";
            this.btnDsNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDsNhanVien_ItemClick);
            // 
            // btnBaoCaoDSVT
            // 
            this.btnBaoCaoDSVT.Caption = "Danh sách vật tư";
            this.btnBaoCaoDSVT.Id = 11;
            this.btnBaoCaoDSVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBaoCaoDSVT.ImageOptions.SvgImage")));
            this.btnBaoCaoDSVT.Name = "btnBaoCaoDSVT";
            this.btnBaoCaoDSVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoDSVT_ItemClick);
            // 
            // btnBaoCaoDSVTTheoGiaTri
            // 
            this.btnBaoCaoDSVTTheoGiaTri.Caption = "Bảng kê chi tiết số lượng – trị giá ";
            this.btnBaoCaoDSVTTheoGiaTri.Id = 12;
            this.btnBaoCaoDSVTTheoGiaTri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBaoCaoDSVTTheoGiaTri.ImageOptions.SvgImage")));
            this.btnBaoCaoDSVTTheoGiaTri.Name = "btnBaoCaoDSVTTheoGiaTri";
            this.btnBaoCaoDSVTTheoGiaTri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoDSVTTheoGiaTri_ItemClick);
            // 
            // btnDonDatHangKhongCoPhieuNhap
            // 
            this.btnDonDatHangKhongCoPhieuNhap.Caption = "Danh sách các đơn đặt hàng chưa có phiếu nhập";
            this.btnDonDatHangKhongCoPhieuNhap.Id = 13;
            this.btnDonDatHangKhongCoPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDonDatHangKhongCoPhieuNhap.ImageOptions.SvgImage")));
            this.btnDonDatHangKhongCoPhieuNhap.Name = "btnDonDatHangKhongCoPhieuNhap";
            this.btnDonDatHangKhongCoPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonDatHangKhongCoPhieuNhap_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Id = 14;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // rbNhapXuat
            // 
            this.rbNhapXuat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbNhanVien,
            this.rbVatTu,
            this.rbKho,
            this.rbNhapXuatVT});
            this.rbNhapXuat.Name = "rbNhapXuat";
            this.rbNhapXuat.Text = "Nhập Xuất";
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.ItemLinks.Add(this.btnNhanVien);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Text = "Nhân Viên";
            // 
            // rbVatTu
            // 
            this.rbVatTu.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.rbVatTu.ItemLinks.Add(this.btnVatTu);
            this.rbVatTu.Name = "rbVatTu";
            this.rbVatTu.Text = "Vật Tư";
            // 
            // rbKho
            // 
            this.rbKho.ItemLinks.Add(this.btnKho);
            this.rbKho.Name = "rbKho";
            this.rbKho.Text = "Kho";
            // 
            // rbNhapXuatVT
            // 
            this.rbNhapXuatVT.ItemLinks.Add(this.btnPhieuDat);
            this.rbNhapXuatVT.ItemLinks.Add(this.btnPhieuNhap);
            this.rbNhapXuatVT.ItemLinks.Add(this.btnPhieuXuat);
            this.rbNhapXuatVT.Name = "rbNhapXuatVT";
            this.rbNhapXuatVT.Text = "Nhập xuất";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDsNhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBaoCaoDSVT);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBaoCaoDSVTTheoGiaTri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDonDatHangKhongCoPhieuNhap);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangSuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTipMaNhanVien,
            this.toolTipHoTen,
            this.toolTipQuyen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1173, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolTipMaNhanVien
            // 
            this.toolTipMaNhanVien.Name = "toolTipMaNhanVien";
            this.toolTipMaNhanVien.Size = new System.Drawing.Size(33, 20);
            this.toolTipMaNhanVien.Text = "Mã:";
            this.toolTipMaNhanVien.Click += new System.EventHandler(this.toolTipMaNhanVien_Click);
            // 
            // toolTipHoTen
            // 
            this.toolTipHoTen.Name = "toolTipHoTen";
            this.toolTipHoTen.Size = new System.Drawing.Size(59, 20);
            this.toolTipHoTen.Text = "Họ Tên:";
            // 
            // toolTipQuyen
            // 
            this.toolTipQuyen.Name = "toolTipQuyen";
            this.toolTipQuyen.Size = new System.Drawing.Size(51, 20);
            this.toolTipQuyen.Text = "Quyền";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ VẬT TƯ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangSuat;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolTipMaNhanVien;
        public System.Windows.Forms.ToolStripStatusLabel toolTipHoTen;
        public System.Windows.Forms.ToolStripStatusLabel toolTipQuyen;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbVatTu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbKho;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnPhieuDat;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnPhieuXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbNhapXuatVT;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDsNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoDSVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoDSVTTheoGiaTri;
        private DevExpress.XtraBars.BarButtonItem btnDonDatHangKhongCoPhieuNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        public DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
    }
}

