namespace project_qlvt.report
{
    partial class frmChiTietSoLuongTriGiaHangHoaNhapXuat
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXemTruoc = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateBatDau = new DevExpress.XtraEditors.DateEdit();
            this.dateKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(762, 34);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Danh sách chi tiết số lượng giá trị hàng hóa nhập xuất";
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.Location = new System.Drawing.Point(323, 228);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(133, 40);
            this.btnXemTruoc.TabIndex = 4;
            this.btnXemTruoc.Text = "Xem trước";
            this.btnXemTruoc.UseVisualStyleBackColor = true;
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(70, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Loại phiếu";
            // 
            // cmbLoaiPhieu
            // 
            this.cmbLoaiPhieu.FormattingEnabled = true;
            this.cmbLoaiPhieu.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cmbLoaiPhieu.Location = new System.Drawing.Point(149, 145);
            this.cmbLoaiPhieu.Name = "cmbLoaiPhieu";
            this.cmbLoaiPhieu.Size = new System.Drawing.Size(121, 24);
            this.cmbLoaiPhieu.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(337, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Ngày bắt đầu";
            // 
            // dateBatDau
            // 
            this.dateBatDau.EditValue = null;
            this.dateBatDau.Location = new System.Drawing.Point(432, 147);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Size = new System.Drawing.Size(125, 22);
            this.dateBatDau.TabIndex = 8;
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.EditValue = null;
            this.dateKetThuc.Location = new System.Drawing.Point(691, 147);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Size = new System.Drawing.Size(125, 22);
            this.dateKetThuc.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(596, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Ngày kết thúc";
            // 
            // frmChiTietSoLuongTriGiaHangHoaNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 327);
            this.Controls.Add(this.dateKetThuc);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dateBatDau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbLoaiPhieu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnXemTruoc);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmChiTietSoLuongTriGiaHangHoaNhapXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo chi tiết số lượng giá trị hàng hóa nhập xuất";
            this.Load += new System.EventHandler(this.frmChiTietSoLuongTriGiaHangHoaNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnXemTruoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbLoaiPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateBatDau;
        private DevExpress.XtraEditors.DateEdit dateKetThuc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}