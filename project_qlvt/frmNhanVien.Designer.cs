namespace project_qlvt
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.bdNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new project_qlvt.QLVTDataSet();
            this.txtLuongNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.dateNgaySinhNhanVien = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChiNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCNNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtHoNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.nhanVienTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new project_qlvt.QLVTDataSetTableAdapters.TableAdapterManager();
            this.bdDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.bdPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            this.bdPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new project_qlvt.QLVTDataSetTableAdapters.PhieuXuatTableAdapter();
            this.dataSet = new project_qlvt.QLVTDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhNhanVien.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(17, 28);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(46, 16);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(270, 25);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(29, 16);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(583, 20);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(35, 16);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(810, 20);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(46, 16);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MACN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(17, 94);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(52, 16);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(272, 90);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(71, 16);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(583, 86);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(51, 16);
            lUONGLabel.TabIndex = 12;
            lUONGLabel.Text = "LUONG:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(810, 86);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(101, 16);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemNhanVien,
            this.btnXoaNhanVien,
            this.btnGhiNhanVien,
            this.btnHoanTac,
            this.btnLamMoi,
            this.btnChuyenChiNhanh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemNhanVien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaNhanVien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiNhanVien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChuyenChiNhanh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Caption = "Thêm";
            this.btnThemNhanVien.Id = 0;
            this.btnThemNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemNhanVien.ImageOptions.SvgImage")));
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNhanVien_ItemClick);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Caption = "Xóa";
            this.btnXoaNhanVien.Id = 1;
            this.btnXoaNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaNhanVien.ImageOptions.SvgImage")));
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaNhanVien_ItemClick);
            // 
            // btnGhiNhanVien
            // 
            this.btnGhiNhanVien.Caption = "Ghi";
            this.btnGhiNhanVien.Id = 2;
            this.btnGhiNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiNhanVien.ImageOptions.SvgImage")));
            this.btnGhiNhanVien.Name = "btnGhiNhanVien";
            this.btnGhiNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiNhanVien_ItemClick);
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
            // btnChuyenChiNhanh
            // 
            this.btnChuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btnChuyenChiNhanh.Id = 5;
            this.btnChuyenChiNhanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenChiNhanh.ImageOptions.SvgImage")));
            this.btnChuyenChiNhanh.Name = "btnChuyenChiNhanh";
            this.btnChuyenChiNhanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenChiNhanh_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1438, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 982);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1438, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 952);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1438, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 952);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1438, 952);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelNhapLieu);
            this.panelControl1.Controls.Add(this.nhanVienGridControl);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1414, 928);
            this.panelControl1.TabIndex = 4;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(trangThaiXoaLabel);
            this.panelNhapLieu.Controls.Add(this.trangThaiXoaCheckBox);
            this.panelNhapLieu.Controls.Add(lUONGLabel);
            this.panelNhapLieu.Controls.Add(this.txtLuongNhanVien);
            this.panelNhapLieu.Controls.Add(nGAYSINHLabel);
            this.panelNhapLieu.Controls.Add(this.dateNgaySinhNhanVien);
            this.panelNhapLieu.Controls.Add(dIACHILabel);
            this.panelNhapLieu.Controls.Add(this.txtDiaChiNhanVien);
            this.panelNhapLieu.Controls.Add(mACNLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaCNNhanVien);
            this.panelNhapLieu.Controls.Add(tENLabel);
            this.panelNhapLieu.Controls.Add(this.txtTenNhanVien);
            this.panelNhapLieu.Controls.Add(hOLabel);
            this.panelNhapLieu.Controls.Add(this.txtHoNhanVien);
            this.panelNhapLieu.Controls.Add(mANVLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaNhanVien);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(2, 404);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1410, 522);
            this.panelNhapLieu.TabIndex = 2;
            // 
            // trangThaiXoaCheckBox
            // 
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdNhanVien, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(951, 87);
            this.trangThaiXoaCheckBox.Name = "trangThaiXoaCheckBox";
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.trangThaiXoaCheckBox.TabIndex = 15;
            this.trangThaiXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // bdNhanVien
            // 
            this.bdNhanVien.DataMember = "NhanVien";
            this.bdNhanVien.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLuongNhanVien
            // 
            this.txtLuongNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdNhanVien, "LUONG", true));
            this.txtLuongNhanVien.Location = new System.Drawing.Point(656, 83);
            this.txtLuongNhanVien.MenuManager = this.barManager1;
            this.txtLuongNhanVien.Name = "txtLuongNhanVien";
            this.txtLuongNhanVien.Properties.DisplayFormat.FormatString = "n0";
            this.txtLuongNhanVien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLuongNhanVien.Properties.EditFormat.FormatString = "n0";
            this.txtLuongNhanVien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLuongNhanVien.Size = new System.Drawing.Size(115, 22);
            this.txtLuongNhanVien.TabIndex = 13;
            // 
            // dateNgaySinhNhanVien
            // 
            this.dateNgaySinhNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdNhanVien, "NGAYSINH", true));
            this.dateNgaySinhNhanVien.EditValue = null;
            this.dateNgaySinhNhanVien.Location = new System.Drawing.Point(366, 87);
            this.dateNgaySinhNhanVien.MenuManager = this.barManager1;
            this.dateNgaySinhNhanVien.Name = "dateNgaySinhNhanVien";
            this.dateNgaySinhNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinhNhanVien.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinhNhanVien.Size = new System.Drawing.Size(168, 22);
            this.dateNgaySinhNhanVien.TabIndex = 11;
            // 
            // txtDiaChiNhanVien
            // 
            this.txtDiaChiNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdNhanVien, "DIACHI", true));
            this.txtDiaChiNhanVien.Location = new System.Drawing.Point(101, 87);
            this.txtDiaChiNhanVien.MenuManager = this.barManager1;
            this.txtDiaChiNhanVien.Name = "txtDiaChiNhanVien";
            this.txtDiaChiNhanVien.Size = new System.Drawing.Size(125, 22);
            this.txtDiaChiNhanVien.TabIndex = 9;
            // 
            // txtMaCNNhanVien
            // 
            this.txtMaCNNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdNhanVien, "MACN", true));
            this.txtMaCNNhanVien.Enabled = false;
            this.txtMaCNNhanVien.Location = new System.Drawing.Point(951, 17);
            this.txtMaCNNhanVien.MenuManager = this.barManager1;
            this.txtMaCNNhanVien.Name = "txtMaCNNhanVien";
            this.txtMaCNNhanVien.Size = new System.Drawing.Size(125, 22);
            this.txtMaCNNhanVien.TabIndex = 7;
            this.txtMaCNNhanVien.EditValueChanged += new System.EventHandler(this.txtMaCNNhanVien_EditValueChanged);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdNhanVien, "TEN", true));
            this.txtTenNhanVien.Location = new System.Drawing.Point(656, 18);
            this.txtTenNhanVien.MenuManager = this.barManager1;
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(115, 22);
            this.txtTenNhanVien.TabIndex = 5;
            // 
            // txtHoNhanVien
            // 
            this.txtHoNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdNhanVien, "HO", true));
            this.txtHoNhanVien.Location = new System.Drawing.Point(366, 22);
            this.txtHoNhanVien.MenuManager = this.barManager1;
            this.txtHoNhanVien.Name = "txtHoNhanVien";
            this.txtHoNhanVien.Size = new System.Drawing.Size(168, 22);
            this.txtHoNhanVien.TabIndex = 3;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdNhanVien, "MANV", true));
            this.txtMaNhanVien.Location = new System.Drawing.Point(95, 21);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(131, 23);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bdNhanVien;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.Location = new System.Drawing.Point(2, 51);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1410, 353);
            this.nhanVienGridControl.TabIndex = 1;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.nhanVienGridControl.Click += new System.EventHandler(this.nhanVienGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            this.colNGAYSINH.Width = 94;
            // 
            // colLUONG
            // 
            this.colLUONG.DisplayFormat.FormatString = "n0";
            this.colLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 25;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            this.colLUONG.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            this.colMACN.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            this.colTrangThaiXoa.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbChiNhanh);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1410, 49);
            this.panelControl2.TabIndex = 0;
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
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1438, 952);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1418, 932);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.DSNhanVienTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project_qlvt.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // bdDatHang
            // 
            this.bdDatHang.DataMember = "FK_DatHang_NhanVien";
            this.bdDatHang.DataSource = this.bdNhanVien;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // bdPhieuNhap
            // 
            this.bdPhieuNhap.DataMember = "FK_PhieuNhap_NhanVien";
            this.bdPhieuNhap.DataSource = this.bdNhanVien;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // bdPhieuXuat
            // 
            this.bdPhieuXuat.DataMember = "FK_PX_NhanVien";
            this.bdPhieuXuat.DataSource = this.bdNhanVien;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "QLVTDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dataSet;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 1002);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhanVien";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhNhanVien.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnXoaNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnGhiNhanVien;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bdNhanVien;
        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private DevExpress.XtraEditors.TextEdit txtLuongNhanVien;
        private DevExpress.XtraEditors.DateEdit dateNgaySinhNhanVien;
        private DevExpress.XtraEditors.TextEdit txtDiaChiNhanVien;
        private DevExpress.XtraEditors.TextEdit txtMaCNNhanVien;
        private DevExpress.XtraEditors.TextEdit txtTenNhanVien;
        private DevExpress.XtraEditors.TextEdit txtHoNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.BindingSource bdDatHang;
        private QLVTDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource bdPhieuNhap;
        private QLVTDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdPhieuXuat;
        private QLVTDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private QLVTDataSet dataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.CheckBox trangThaiXoaCheckBox;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
    }
}