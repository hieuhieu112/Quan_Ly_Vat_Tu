namespace project_qlvt
{
    partial class frmPhieuDat
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuDat));
            this.label2 = new System.Windows.Forms.Label();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
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
            this.bdPhieuDat = new System.Windows.Forms.BindingSource(this.components);
            this.datHangAdapter = new project_qlvt.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new project_qlvt.QLVTDataSetTableAdapters.TableAdapterManager();
            this.datHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            this.bdCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.CTDDHTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.CTDDHTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupCTDDH = new System.Windows.Forms.GroupBox();
            this.CTDDHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdVT = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCTTDH = new System.Windows.Forms.GroupBox();
            this.cmbTenVT = new System.Windows.Forms.ComboBox();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoLuongVT = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaSoDDHCT = new DevExpress.XtraEditors.TextEdit();
            this.groupThongTinDonHang = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTenKho = new System.Windows.Forms.ComboBox();
            this.bdKho = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenNhanVien = new System.Windows.Forms.ComboBox();
            this.bdDSNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.txtNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.dateNgayDat = new DevExpress.XtraEditors.DateEdit();
            this.txtMaSoDDH = new DevExpress.XtraEditors.TextEdit();
            this.dSNhanVienTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.DSNhanVienTableAdapter();
            this.khoTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoanTacVT = new System.Windows.Forms.ToolStripMenuItem();
            this.vattuTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.VattuTableAdapter();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTDDHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxCTTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDHCT.Properties)).BeginInit();
            this.groupThongTinDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(11, 35);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(70, 16);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(14, 64);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(43, 16);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(232, 124);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(46, 16);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(231, 154);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(54, 16);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(14, 92);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(54, 16);
            nhaCCLabel.TabIndex = 8;
            nhaCCLabel.Text = "Nha CC:";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Location = new System.Drawing.Point(14, 34);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(70, 16);
            masoDDHLabel1.TabIndex = 0;
            masoDDHLabel1.Text = "Maso DDH:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(19, 91);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 16);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(19, 126);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(57, 16);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(241, 68);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(46, 16);
            mAVTLabel.TabIndex = 7;
            mAVTLabel.Text = "MAVT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 68);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 16);
            label4.TabIndex = 9;
            label4.Text = "Ten VT:";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ Tên NV";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.bar3});
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
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 6;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1179, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1179, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 706);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1179, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 706);
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
            this.panelControlMain.Size = new System.Drawing.Size(1179, 42);
            this.panelControlMain.TabIndex = 4;
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
            // bdPhieuDat
            // 
            this.bdPhieuDat.DataMember = "DatHang";
            this.bdPhieuDat.DataSource = this.qLVTDataSet;
            // 
            // datHangAdapter
            // 
            this.datHangAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangAdapter;
            this.tableAdapterManager.DSNhanVienTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project_qlvt.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangGridControl
            // 
            this.datHangGridControl.DataSource = this.bdPhieuDat;
            this.datHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.datHangGridControl.Location = new System.Drawing.Point(0, 72);
            this.datHangGridControl.MainView = this.gridView1;
            this.datHangGridControl.MenuManager = this.barManager1;
            this.datHangGridControl.Name = "datHangGridControl";
            this.datHangGridControl.Size = new System.Drawing.Size(1179, 255);
            this.datHangGridControl.TabIndex = 6;
            this.datHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.datHangGridControl.Click += new System.EventHandler(this.datHangGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.datHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
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
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
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
            // bdPhieuNhap
            // 
            this.bdPhieuNhap.DataMember = "FK_PhieuNhap_DatHang";
            this.bdPhieuNhap.DataSource = this.bdPhieuDat;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // bdCTDDH
            // 
            this.bdCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdCTDDH.DataSource = this.bdPhieuDat;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupCTDDH);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 327);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1179, 409);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Thông tin";
            // 
            // groupCTDDH
            // 
            this.groupCTDDH.Controls.Add(this.CTDDHDataGridView);
            this.groupCTDDH.Controls.Add(this.label1);
            this.groupCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCTDDH.Location = new System.Drawing.Point(677, 28);
            this.groupCTDDH.Name = "groupCTDDH";
            this.groupCTDDH.Size = new System.Drawing.Size(500, 379);
            this.groupCTDDH.TabIndex = 1;
            this.groupCTDDH.TabStop = false;
            // 
            // CTDDHDataGridView
            // 
            this.CTDDHDataGridView.AllowUserToAddRows = false;
            this.CTDDHDataGridView.AutoGenerateColumns = false;
            this.CTDDHDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CTDDHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTDDHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.CTDDHDataGridView.DataSource = this.bdCTDDH;
            this.CTDDHDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTDDHDataGridView.Location = new System.Drawing.Point(3, 43);
            this.CTDDHDataGridView.Name = "CTDDHDataGridView";
            this.CTDDHDataGridView.RowHeadersWidth = 51;
            this.CTDDHDataGridView.RowTemplate.Height = 24;
            this.CTDDHDataGridView.Size = new System.Drawing.Size(494, 333);
            this.CTDDHDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MasoDDH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.DataSource = this.bdVT;
            this.dataGridViewTextBoxColumn2.DisplayMember = "TENVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi tiết đơn đặt hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxCTTDH);
            this.groupBox1.Controls.Add(this.groupThongTinDonHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(2, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxCTTDH
            // 
            this.groupBoxCTTDH.Controls.Add(this.cmbTenVT);
            this.groupBoxCTTDH.Controls.Add(label4);
            this.groupBoxCTTDH.Controls.Add(mAVTLabel);
            this.groupBoxCTTDH.Controls.Add(this.txtMaVT);
            this.groupBoxCTTDH.Controls.Add(dONGIALabel);
            this.groupBoxCTTDH.Controls.Add(this.txtDonGia);
            this.groupBoxCTTDH.Controls.Add(sOLUONGLabel);
            this.groupBoxCTTDH.Controls.Add(this.txtSoLuongVT);
            this.groupBoxCTTDH.Controls.Add(masoDDHLabel1);
            this.groupBoxCTTDH.Controls.Add(this.txtMaSoDDHCT);
            this.groupBoxCTTDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCTTDH.Location = new System.Drawing.Point(3, 223);
            this.groupBoxCTTDH.Name = "groupBoxCTTDH";
            this.groupBoxCTTDH.Size = new System.Drawing.Size(669, 153);
            this.groupBoxCTTDH.TabIndex = 1;
            this.groupBoxCTTDH.TabStop = false;
            this.groupBoxCTTDH.Text = "Thông tin chi tiết đơn hàng";
            // 
            // cmbTenVT
            // 
            this.cmbTenVT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdCTDDH, "MAVT", true));
            this.cmbTenVT.DataSource = this.bdVT;
            this.cmbTenVT.DisplayMember = "TENVT";
            this.cmbTenVT.FormattingEnabled = true;
            this.cmbTenVT.Location = new System.Drawing.Point(96, 59);
            this.cmbTenVT.Name = "cmbTenVT";
            this.cmbTenVT.Size = new System.Drawing.Size(121, 24);
            this.cmbTenVT.TabIndex = 10;
            this.cmbTenVT.ValueMember = "MAVT";
            this.cmbTenVT.SelectedIndexChanged += new System.EventHandler(this.cmbTenVT_SelectedIndexChanged);
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdCTDDH, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(293, 65);
            this.txtMaVT.MenuManager = this.barManager1;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(125, 22);
            this.txtMaVT.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdCTDDH, "DONGIA", true));
            this.txtDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGia.Location = new System.Drawing.Point(96, 122);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Size = new System.Drawing.Size(125, 24);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtSoLuongVT
            // 
            this.txtSoLuongVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdCTDDH, "SOLUONG", true));
            this.txtSoLuongVT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuongVT.Location = new System.Drawing.Point(96, 87);
            this.txtSoLuongVT.MenuManager = this.barManager1;
            this.txtSoLuongVT.Name = "txtSoLuongVT";
            this.txtSoLuongVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuongVT.Size = new System.Drawing.Size(125, 24);
            this.txtSoLuongVT.TabIndex = 5;
            // 
            // txtMaSoDDHCT
            // 
            this.txtMaSoDDHCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdCTDDH, "MasoDDH", true));
            this.txtMaSoDDHCT.Location = new System.Drawing.Point(96, 31);
            this.txtMaSoDDHCT.MenuManager = this.barManager1;
            this.txtMaSoDDHCT.Name = "txtMaSoDDHCT";
            this.txtMaSoDDHCT.Size = new System.Drawing.Size(125, 22);
            this.txtMaSoDDHCT.TabIndex = 1;
            // 
            // groupThongTinDonHang
            // 
            this.groupThongTinDonHang.Controls.Add(this.label3);
            this.groupThongTinDonHang.Controls.Add(this.cmbTenKho);
            this.groupThongTinDonHang.Controls.Add(this.label2);
            this.groupThongTinDonHang.Controls.Add(this.cmbTenNhanVien);
            this.groupThongTinDonHang.Controls.Add(nhaCCLabel);
            this.groupThongTinDonHang.Controls.Add(this.txtNhaCungCap);
            this.groupThongTinDonHang.Controls.Add(mAKHOLabel);
            this.groupThongTinDonHang.Controls.Add(this.txtMaKho);
            this.groupThongTinDonHang.Controls.Add(mANVLabel);
            this.groupThongTinDonHang.Controls.Add(this.txtMaNhanVien);
            this.groupThongTinDonHang.Controls.Add(nGAYLabel);
            this.groupThongTinDonHang.Controls.Add(this.dateNgayDat);
            this.groupThongTinDonHang.Controls.Add(masoDDHLabel);
            this.groupThongTinDonHang.Controls.Add(this.txtMaSoDDH);
            this.groupThongTinDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTinDonHang.Location = new System.Drawing.Point(3, 19);
            this.groupThongTinDonHang.Name = "groupThongTinDonHang";
            this.groupThongTinDonHang.Size = new System.Drawing.Size(669, 204);
            this.groupThongTinDonHang.TabIndex = 0;
            this.groupThongTinDonHang.TabStop = false;
            this.groupThongTinDonHang.Text = "Thông tin đơn hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên Kho";
            // 
            // cmbTenKho
            // 
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdPhieuDat, "MAKHO", true));
            this.cmbTenKho.DataSource = this.bdKho;
            this.cmbTenKho.DisplayMember = "TENKHO";
            this.cmbTenKho.FormattingEnabled = true;
            this.cmbTenKho.Location = new System.Drawing.Point(96, 154);
            this.cmbTenKho.Name = "cmbTenKho";
            this.cmbTenKho.Size = new System.Drawing.Size(121, 24);
            this.cmbTenKho.TabIndex = 12;
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
            this.cmbTenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdPhieuDat, "MANV", true));
            this.cmbTenNhanVien.DataSource = this.bdDSNhanVien;
            this.cmbTenNhanVien.DisplayMember = "HOTEN";
            this.cmbTenNhanVien.Enabled = false;
            this.cmbTenNhanVien.FormattingEnabled = true;
            this.cmbTenNhanVien.Location = new System.Drawing.Point(96, 118);
            this.cmbTenNhanVien.Name = "cmbTenNhanVien";
            this.cmbTenNhanVien.Size = new System.Drawing.Size(121, 24);
            this.cmbTenNhanVien.TabIndex = 10;
            this.cmbTenNhanVien.ValueMember = "MANV";
            this.cmbTenNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbTenNhanVien_SelectedIndexChanged);
            // 
            // bdDSNhanVien
            // 
            this.bdDSNhanVien.DataMember = "DSNhanVien";
            this.bdDSNhanVien.DataSource = this.qLVTDataSet;
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuDat, "NhaCC", true));
            this.txtNhaCungCap.Location = new System.Drawing.Point(96, 89);
            this.txtNhaCungCap.MenuManager = this.barManager1;
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(125, 22);
            this.txtNhaCungCap.TabIndex = 9;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuDat, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(293, 151);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(125, 22);
            this.txtMaKho.TabIndex = 7;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuDat, "MANV", true));
            this.txtMaNhanVien.Location = new System.Drawing.Point(293, 118);
            this.txtMaNhanVien.MenuManager = this.barManager1;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(125, 22);
            this.txtMaNhanVien.TabIndex = 5;
            this.txtMaNhanVien.EditValueChanged += new System.EventHandler(this.txtMaNhanVien_EditValueChanged);
            // 
            // dateNgayDat
            // 
            this.dateNgayDat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuDat, "NGAY", true));
            this.dateNgayDat.EditValue = null;
            this.dateNgayDat.Enabled = false;
            this.dateNgayDat.Location = new System.Drawing.Point(96, 61);
            this.dateNgayDat.MenuManager = this.barManager1;
            this.dateNgayDat.Name = "dateNgayDat";
            this.dateNgayDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayDat.Size = new System.Drawing.Size(125, 22);
            this.dateNgayDat.TabIndex = 3;
            this.dateNgayDat.EditValueChanged += new System.EventHandler(this.nGAYDateEdit_EditValueChanged);
            // 
            // txtMaSoDDH
            // 
            this.txtMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdPhieuDat, "MasoDDH", true));
            this.txtMaSoDDH.Location = new System.Drawing.Point(96, 32);
            this.txtMaSoDDH.MenuManager = this.barManager1;
            this.txtMaSoDDH.Name = "txtMaSoDDH";
            this.txtMaSoDDH.Size = new System.Drawing.Size(125, 22);
            this.txtMaSoDDH.TabIndex = 1;
            // 
            // dSNhanVienTableAdapter
            // 
            this.dSNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
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
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 736);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.datHangGridControl);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuDat";
            this.Text = "Phiếu Đặt hàng";
            this.Load += new System.EventHandler(this.frmPhieuDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            this.panelControlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupCTDDH.ResumeLayout(false);
            this.groupCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTDDHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxCTTDH.ResumeLayout(false);
            this.groupBoxCTTDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDHCT.Properties)).EndInit();
            this.groupThongTinDonHang.ResumeLayout(false);
            this.groupThongTinDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
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
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdPhieuDat;
        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.DatHangTableAdapter datHangAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl datHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.BindingSource bdPhieuNhap;
        private QLVTDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdCTDDH;
        private QLVTDataSetTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupThongTinDonHang;
        private DevExpress.XtraEditors.TextEdit txtMaSoDDH;
        private DevExpress.XtraEditors.DateEdit dateNgayDat;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.TextEdit txtNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupCTDDH;
        private System.Windows.Forms.DataGridView CTDDHDataGridView;
        private System.Windows.Forms.ComboBox cmbTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdDSNhanVien;
        private QLVTDataSetTableAdapters.DSNhanVienTableAdapter dSNhanVienTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTenKho;
        private System.Windows.Forms.BindingSource bdKho;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiVT;
        private System.Windows.Forms.BindingSource bdVT;
        private QLVTDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxCTTDH;
        private DevExpress.XtraEditors.TextEdit txtMaSoDDHCT;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private DevExpress.XtraEditors.SpinEdit txtSoLuongVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cmbTenVT;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private System.Windows.Forms.ToolStripMenuItem btnHoanTacVT;
    }
}