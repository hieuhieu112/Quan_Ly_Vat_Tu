namespace project_qlvt
{
    partial class frmPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.qLVTDataSet = new project_qlvt.QLVTDataSet();
            this.bdPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new project_qlvt.QLVTDataSetTableAdapters.TableAdapterManager();
            this.dSNhanVienTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.DSNhanVienTableAdapter();
            this.khoTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.phieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxCTGridveiw = new System.Windows.Forms.GroupBox();
            this.CTTPNDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdVT = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxThongTinCT = new System.Windows.Forms.GroupBox();
            this.cmbTenVT = new System.Windows.Forms.ComboBox();
            this.btnChonVatTu = new System.Windows.Forms.Button();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhieuNhapCT = new DevExpress.XtraEditors.TextEdit();
            this.groupBoxPhieuNhap = new System.Windows.Forms.GroupBox();
            this.btnChonDDH = new System.Windows.Forms.Button();
            this.cmbTenKho = new System.Windows.Forms.ComboBox();
            this.bdKho = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenNhanVien = new System.Windows.Forms.ComboBox();
            this.bdDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSoDDH = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoanTacVT = new System.Windows.Forms.ToolStripMenuItem();
            this.cTPNTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.CTPNTableAdapter();
            this.vattuTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.VattuTableAdapter();
            this.bdCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.CTDDHTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBoxCTGridveiw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTTPNDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCTPN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxThongTinCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhapCT.Properties)).BeginInit();
            this.groupBoxPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(29, 36);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(45, 16);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(33, 69);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(43, 16);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(227, 184);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(54, 16);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(235, 152);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(46, 16);
            mANVLabel.TabIndex = 9;
            mANVLabel.Text = "MANV:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(22, 147);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(52, 16);
            hOTENLabel.TabIndex = 10;
            hOTENLabel.Text = "HOTEN:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(15, 187);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(59, 16);
            tENKHOLabel.TabIndex = 12;
            tENKHOLabel.Text = "TENKHO:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(6, 109);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(70, 16);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(29, 25);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(45, 16);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "MAPN:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(30, 53);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(46, 16);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(8, 81);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 16);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(228, 82);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(57, 16);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnHoanTac,
            this.btnLamMoi,
            this.btnChuyenChiNhanh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn Tác";
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoanTac.ImageOptions.SvgImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTac_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 4;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1222, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 783);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1222, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 753);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1222, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 753);
            // 
            // btnChuyenChiNhanh
            // 
            this.btnChuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btnChuyenChiNhanh.Id = 5;
            this.btnChuyenChiNhanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenChiNhanh.ImageOptions.SvgImage")));
            this.btnChuyenChiNhanh.Name = "btnChuyenChiNhanh";
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.cmbChiNhanh);
            this.panelControlMain.Controls.Add(this.labelControl1);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlMain.Location = new System.Drawing.Point(0, 30);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1222, 42);
            this.panelControlMain.TabIndex = 5;
            this.panelControlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControlMain_Paint);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(85, 5);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(205, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chi Nhánh";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdPhieuNhap
            // 
            this.bdPhieuNhap.DataMember = "PhieuNhap";
            this.bdPhieuNhap.DataSource = this.qLVTDataSet;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.DSNhanVienTableAdapter = this.dSNhanVienTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project_qlvt.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // dSNhanVienTableAdapter
            // 
            this.dSNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapGridControl
            // 
            this.phieuNhapGridControl.DataSource = this.bdPhieuNhap;
            this.phieuNhapGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.phieuNhapGridControl.Location = new System.Drawing.Point(0, 72);
            this.phieuNhapGridControl.MainView = this.gridView1;
            this.phieuNhapGridControl.MenuManager = this.barManager1;
            this.phieuNhapGridControl.Name = "phieuNhapGridControl";
            this.phieuNhapGridControl.Size = new System.Drawing.Size(1222, 302);
            this.phieuNhapGridControl.TabIndex = 6;
            this.phieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.phieuNhapGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBoxCTGridveiw);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 374);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1222, 409);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin phiếu nhập";
            // 
            // groupBoxCTGridveiw
            // 
            this.groupBoxCTGridveiw.Controls.Add(this.CTTPNDataGridView);
            this.groupBoxCTGridveiw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCTGridveiw.Location = new System.Drawing.Point(574, 28);
            this.groupBoxCTGridveiw.Name = "groupBoxCTGridveiw";
            this.groupBoxCTGridveiw.Size = new System.Drawing.Size(646, 379);
            this.groupBoxCTGridveiw.TabIndex = 1;
            this.groupBoxCTGridveiw.TabStop = false;
            this.groupBoxCTGridveiw.Text = "Chi tiết đơn nhập";
            // 
            // CTTPNDataGridView
            // 
            this.CTTPNDataGridView.AllowUserToAddRows = false;
            this.CTTPNDataGridView.AutoGenerateColumns = false;
            this.CTTPNDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CTTPNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTTPNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.CTTPNDataGridView.DataSource = this.bdCTPN;
            this.CTTPNDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTTPNDataGridView.Location = new System.Drawing.Point(3, 19);
            this.CTTPNDataGridView.Name = "CTTPNDataGridView";
            this.CTTPNDataGridView.RowHeadersWidth = 51;
            this.CTTPNDataGridView.RowTemplate.Height = 24;
            this.CTTPNDataGridView.Size = new System.Drawing.Size(640, 357);
            this.CTTPNDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.DataSource = this.bdVT;
            this.dataGridViewTextBoxColumn2.DisplayMember = "TENVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "MAVT";
            // 
            // bdVT
            // 
            this.bdVT.DataMember = "Vattu";
            this.bdVT.DataSource = this.qLVTDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bdCTPN
            // 
            this.bdCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdCTPN.DataSource = this.bdPhieuNhap;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxThongTinCT);
            this.groupBox1.Controls.Add(this.groupBoxPhieuNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(2, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxThongTinCT
            // 
            this.groupBoxThongTinCT.Controls.Add(this.cmbTenVT);
            this.groupBoxThongTinCT.Controls.Add(this.btnChonVatTu);
            this.groupBoxThongTinCT.Controls.Add(dONGIALabel);
            this.groupBoxThongTinCT.Controls.Add(this.txtDonGia);
            this.groupBoxThongTinCT.Controls.Add(sOLUONGLabel);
            this.groupBoxThongTinCT.Controls.Add(this.txtSoLuong);
            this.groupBoxThongTinCT.Controls.Add(mAVTLabel);
            this.groupBoxThongTinCT.Controls.Add(this.txtMaVT);
            this.groupBoxThongTinCT.Controls.Add(mAPNLabel1);
            this.groupBoxThongTinCT.Controls.Add(this.txtMaPhieuNhapCT);
            this.groupBoxThongTinCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThongTinCT.Location = new System.Drawing.Point(3, 247);
            this.groupBoxThongTinCT.Name = "groupBoxThongTinCT";
            this.groupBoxThongTinCT.Size = new System.Drawing.Size(566, 129);
            this.groupBoxThongTinCT.TabIndex = 1;
            this.groupBoxThongTinCT.TabStop = false;
            this.groupBoxThongTinCT.Text = "Thông tin chi tiết đơn nhập";
            // 
            // cmbTenVT
            // 
            this.cmbTenVT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdCTPN, "MAVT", true));
            this.cmbTenVT.DataSource = this.bdVT;
            this.cmbTenVT.DisplayMember = "TENVT";
            this.cmbTenVT.Enabled = false;
            this.cmbTenVT.FormattingEnabled = true;
            this.cmbTenVT.Location = new System.Drawing.Point(287, 42);
            this.cmbTenVT.Name = "cmbTenVT";
            this.cmbTenVT.Size = new System.Drawing.Size(121, 24);
            this.cmbTenVT.TabIndex = 9;
            this.cmbTenVT.ValueMember = "MAVT";
            // 
            // btnChonVatTu
            // 
            this.btnChonVatTu.Enabled = false;
            this.btnChonVatTu.Location = new System.Drawing.Point(438, 45);
            this.btnChonVatTu.Name = "btnChonVatTu";
            this.btnChonVatTu.Size = new System.Drawing.Size(105, 27);
            this.btnChonVatTu.TabIndex = 8;
            this.btnChonVatTu.Text = "Chọn vật tư";
            this.btnChonVatTu.UseVisualStyleBackColor = true;
            this.btnChonVatTu.Click += new System.EventHandler(this.btnChonVatTu_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdCTPN, "DONGIA", true));
            this.txtDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGia.Location = new System.Drawing.Point(287, 78);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Size = new System.Drawing.Size(125, 24);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdCTPN, "SOLUONG", true));
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(82, 78);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Size = new System.Drawing.Size(125, 24);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdCTPN, "MAVT", true));
            this.txtMaVT.Enabled = false;
            this.txtMaVT.Location = new System.Drawing.Point(82, 50);
            this.txtMaVT.MenuManager = this.barManager1;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(125, 22);
            this.txtMaVT.TabIndex = 3;
            // 
            // txtMaPhieuNhapCT
            // 
            this.txtMaPhieuNhapCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdCTPN, "MAPN", true));
            this.txtMaPhieuNhapCT.Enabled = false;
            this.txtMaPhieuNhapCT.Location = new System.Drawing.Point(80, 22);
            this.txtMaPhieuNhapCT.MenuManager = this.barManager1;
            this.txtMaPhieuNhapCT.Name = "txtMaPhieuNhapCT";
            this.txtMaPhieuNhapCT.Size = new System.Drawing.Size(125, 22);
            this.txtMaPhieuNhapCT.TabIndex = 1;
            // 
            // groupBoxPhieuNhap
            // 
            this.groupBoxPhieuNhap.Controls.Add(this.btnChonDDH);
            this.groupBoxPhieuNhap.Controls.Add(tENKHOLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.cmbTenKho);
            this.groupBoxPhieuNhap.Controls.Add(hOTENLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.cmbTenNhanVien);
            this.groupBoxPhieuNhap.Controls.Add(mANVLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaNV);
            this.groupBoxPhieuNhap.Controls.Add(mAKHOLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaKho);
            this.groupBoxPhieuNhap.Controls.Add(masoDDHLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaSoDDH);
            this.groupBoxPhieuNhap.Controls.Add(nGAYLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtNgayNhap);
            this.groupBoxPhieuNhap.Controls.Add(mAPNLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaPN);
            this.groupBoxPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPhieuNhap.Location = new System.Drawing.Point(3, 19);
            this.groupBoxPhieuNhap.Name = "groupBoxPhieuNhap";
            this.groupBoxPhieuNhap.Size = new System.Drawing.Size(566, 228);
            this.groupBoxPhieuNhap.TabIndex = 0;
            this.groupBoxPhieuNhap.TabStop = false;
            this.groupBoxPhieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // btnChonDDH
            // 
            this.btnChonDDH.Location = new System.Drawing.Point(238, 100);
            this.btnChonDDH.Name = "btnChonDDH";
            this.btnChonDDH.Size = new System.Drawing.Size(136, 35);
            this.btnChonDDH.TabIndex = 14;
            this.btnChonDDH.Text = "Chọn đơn đặt hàng";
            this.btnChonDDH.UseVisualStyleBackColor = true;
            this.btnChonDDH.Click += new System.EventHandler(this.btnChonDDH_Click);
            // 
            // cmbTenKho
            // 
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdKho, "TENKHO", true));
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdPhieuNhap, "MAKHO", true));
            this.cmbTenKho.DataSource = this.bdKho;
            this.cmbTenKho.DisplayMember = "TENKHO";
            this.cmbTenKho.FormattingEnabled = true;
            this.cmbTenKho.Location = new System.Drawing.Point(80, 184);
            this.cmbTenKho.Name = "cmbTenKho";
            this.cmbTenKho.Size = new System.Drawing.Size(127, 24);
            this.cmbTenKho.TabIndex = 13;
            this.cmbTenKho.ValueMember = "MAKHO";
            this.cmbTenKho.SelectedIndexChanged += new System.EventHandler(this.cmbTenKho_SelectedIndexChanged);
            // 
            // bdKho
            // 
            this.bdKho.DataMember = "Kho";
            this.bdKho.DataSource = this.qLVTDataSet;
            // 
            // cmbTenNhanVien
            // 
            this.cmbTenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdDSNV, "HOTEN", true));
            this.cmbTenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdPhieuNhap, "MANV", true));
            this.cmbTenNhanVien.DataSource = this.bdDSNV;
            this.cmbTenNhanVien.DisplayMember = "HOTEN";
            this.cmbTenNhanVien.Enabled = false;
            this.cmbTenNhanVien.FormattingEnabled = true;
            this.cmbTenNhanVien.Location = new System.Drawing.Point(80, 144);
            this.cmbTenNhanVien.Name = "cmbTenNhanVien";
            this.cmbTenNhanVien.Size = new System.Drawing.Size(127, 24);
            this.cmbTenNhanVien.TabIndex = 11;
            this.cmbTenNhanVien.ValueMember = "MANV";
            this.cmbTenNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbTenNhanVien_SelectedIndexChanged);
            // 
            // bdDSNV
            // 
            this.bdDSNV.DataMember = "DSNhanVien";
            this.bdDSNV.DataSource = this.qLVTDataSet;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuNhap, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(287, 149);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(125, 22);
            this.txtMaNV.TabIndex = 10;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuNhap, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(287, 181);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(125, 22);
            this.txtMaKho.TabIndex = 9;
            // 
            // txtMaSoDDH
            // 
            this.txtMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuNhap, "MasoDDH", true));
            this.txtMaSoDDH.Location = new System.Drawing.Point(82, 106);
            this.txtMaSoDDH.MenuManager = this.barManager1;
            this.txtMaSoDDH.Name = "txtMaSoDDH";
            this.txtMaSoDDH.Size = new System.Drawing.Size(125, 22);
            this.txtMaSoDDH.TabIndex = 5;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuNhap, "NGAY", true));
            this.txtNgayNhap.EditValue = null;
            this.txtNgayNhap.Location = new System.Drawing.Point(82, 66);
            this.txtNgayNhap.MenuManager = this.barManager1;
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayNhap.Size = new System.Drawing.Size(125, 22);
            this.txtNgayNhap.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuNhap, "MAPN", true));
            this.txtMaPN.Location = new System.Drawing.Point(80, 33);
            this.txtMaPN.MenuManager = this.barManager1;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(125, 22);
            this.txtMaPN.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemVT,
            this.btnXoaVT,
            this.btnGhiVT,
            this.btnHoanTacVT});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 100);
            // 
            // btnThemVT
            // 
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(226, 24);
            this.btnThemVT.Text = "Thêm vật tư vào phiếu";
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(226, 24);
            this.btnXoaVT.Text = "Xóa vật tư khỏi phiếu";
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.Size = new System.Drawing.Size(226, 24);
            this.btnGhiVT.Text = "Ghi";
            this.btnGhiVT.Click += new System.EventHandler(this.btnGhiVT_Click);
            // 
            // btnHoanTacVT
            // 
            this.btnHoanTacVT.Name = "btnHoanTacVT";
            this.btnHoanTacVT.Size = new System.Drawing.Size(226, 24);
            this.btnHoanTacVT.Text = "Hoàn tác";
            this.btnHoanTacVT.Click += new System.EventHandler(this.btnHoanTacVT_Click);
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // bdCTDDH
            // 
            this.bdCTDDH.DataMember = "CTDDH";
            this.bdCTDDH.DataSource = this.qLVTDataSet;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 783);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.phieuNhapGridControl);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuNhap";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            this.panelControlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBoxCTGridveiw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTTPNDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCTPN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxThongTinCT.ResumeLayout(false);
            this.groupBoxThongTinCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhapCT.Properties)).EndInit();
            this.groupBoxPhieuNhap.ResumeLayout(false);
            this.groupBoxPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private System.Windows.Forms.BindingSource bdPhieuNhap;
        private QLVTDataSet qLVTDataSet;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QLVTDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl phieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPhieuNhap;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.DateEdit txtNgayNhap;
        private DevExpress.XtraEditors.TextEdit txtMaPN;
        private QLVTDataSetTableAdapters.DSNhanVienTableAdapter dSNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource bdDSNV;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource bdKho;
        private System.Windows.Forms.ComboBox cmbTenKho;
        private System.Windows.Forms.ComboBox cmbTenNhanVien;
        private System.Windows.Forms.Button btnChonDDH;
        private DevExpress.XtraEditors.TextEdit txtMaSoDDH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiVT;
        private System.Windows.Forms.ToolStripMenuItem btnHoanTacVT;
        private System.Windows.Forms.GroupBox groupBoxThongTinCT;
        private System.Windows.Forms.GroupBox groupBoxCTGridveiw;
        private System.Windows.Forms.BindingSource bdCTPN;
        private QLVTDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.DataGridView CTTPNDataGridView;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private DevExpress.XtraEditors.TextEdit txtMaPhieuNhapCT;
        private System.Windows.Forms.Button btnChonVatTu;
        private System.Windows.Forms.ComboBox cmbTenVT;
        private System.Windows.Forms.BindingSource bdVT;
        private QLVTDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource bdCTDDH;
        private QLVTDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}