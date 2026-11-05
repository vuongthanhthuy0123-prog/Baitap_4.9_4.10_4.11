namespace Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuTep = new ToolStripMenuItem();
            mnuXuatCsv = new ToolStripMenuItem();
            mnuSep1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSoLichHen = new ToolStripStatusLabel();
            lblThongBao = new ToolStripStatusLabel();
            tlpMain = new TableLayoutPanel();
            grpThongTin = new GroupBox();
            tlpNhap = new TableLayoutPanel();
            lblMaLH = new Label();
            txtMaLH = new TextBox();
            lblBacSi = new Label();
            cboBacSi = new ComboBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgayHen = new Label();
            dtpNgayHen = new DateTimePicker();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            lblLyDo = new Label();
            txtLyDo = new TextBox();
            flpNut = new FlowLayoutPanel();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpTimKiem = new GroupBox();
            flpLoc = new FlowLayoutPanel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            lblLocNgay = new Label();
            dtpLocNgay = new DateTimePicker();
            lblLocTrangThai = new Label();
            cboLocTrangThai = new ComboBox();
            btnBoLoc = new Button();
            dgvLichHen = new DataGridView();
            colMaLH = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colNgayHen = new DataGridViewTextBoxColumn();
            colBacSi = new DataGridViewTextBoxColumn();
            colLyDo = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            bsLichHen = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tlpMain.SuspendLayout();
            grpThongTin.SuspendLayout();
            tlpNhap.SuspendLayout();
            flpNut.SuspendLayout();
            grpTimKiem.SuspendLayout();
            flpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLichHen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTep });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 0;
            //
            // mnuTep
            //
            mnuTep.DropDownItems.AddRange(new ToolStripItem[] { mnuXuatCsv, mnuSep1, mnuThoat });
            mnuTep.Name = "mnuTep";
            mnuTep.Size = new Size(39, 20);
            mnuTep.Text = "Tệp";
            //
            // mnuXuatCsv
            //
            mnuXuatCsv.Name = "mnuXuatCsv";
            mnuXuatCsv.ShortcutKeys = Keys.Control | Keys.E;
            mnuXuatCsv.Size = new Size(260, 22);
            mnuXuatCsv.Text = "Xuất CSV danh sách đang hiển thị...";
            mnuXuatCsv.Click += mnuXuatCsv_Click;
            //
            // mnuSep1
            //
            mnuSep1.Name = "mnuSep1";
            mnuSep1.Size = new Size(257, 6);
            //
            // mnuThoat
            //
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(260, 22);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            //
            // statusStrip1
            //
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoLichHen, lblThongBao });
            statusStrip1.Location = new Point(0, 598);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 2;
            //
            // lblSoLichHen
            //
            lblSoLichHen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoLichHen.Name = "lblSoLichHen";
            lblSoLichHen.Size = new Size(150, 17);
            lblSoLichHen.Text = "Số lịch hẹn: 0";
            //
            // lblThongBao
            //
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(835, 17);
            lblThongBao.Spring = true;
            lblThongBao.Text = "Sẵn sàng";
            lblThongBao.TextAlign = ContentAlignment.MiddleLeft;
            //
            // tlpMain
            //
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(grpThongTin, 0, 0);
            tlpMain.Controls.Add(flpNut, 0, 1);
            tlpMain.Controls.Add(grpTimKiem, 0, 2);
            tlpMain.Controls.Add(dgvLichHen, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 24);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(6);
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 196F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1000, 574);
            tlpMain.TabIndex = 1;
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(tlpNhap);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Name = "grpThongTin";
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin lịch hẹn";
            //
            // tlpNhap
            //
            tlpNhap.ColumnCount = 4;
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNhap.Controls.Add(lblMaLH, 0, 0);
            tlpNhap.Controls.Add(txtMaLH, 1, 0);
            tlpNhap.Controls.Add(lblBacSi, 2, 0);
            tlpNhap.Controls.Add(cboBacSi, 3, 0);
            tlpNhap.Controls.Add(lblHoTen, 0, 1);
            tlpNhap.Controls.Add(txtHoTen, 1, 1);
            tlpNhap.Controls.Add(lblNgayHen, 2, 1);
            tlpNhap.Controls.Add(dtpNgayHen, 3, 1);
            tlpNhap.Controls.Add(lblSDT, 0, 2);
            tlpNhap.Controls.Add(txtSDT, 1, 2);
            tlpNhap.Controls.Add(lblTrangThai, 2, 2);
            tlpNhap.Controls.Add(cboTrangThai, 3, 2);
            tlpNhap.Controls.Add(lblLyDo, 0, 3);
            tlpNhap.Controls.Add(txtLyDo, 1, 3);
            tlpNhap.SetColumnSpan(txtLyDo, 3);
            tlpNhap.Dock = DockStyle.Fill;
            tlpNhap.Name = "tlpNhap";
            tlpNhap.Padding = new Padding(0, 0, 24, 0);
            tlpNhap.RowCount = 4;
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpNhap.TabIndex = 0;
            //
            // lblMaLH
            //
            lblMaLH.Anchor = AnchorStyles.Left;
            lblMaLH.AutoSize = true;
            lblMaLH.Name = "lblMaLH";
            lblMaLH.Text = "Mã lịch hẹn:";
            //
            // txtMaLH
            //
            txtMaLH.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaLH.Margin = new Padding(3, 3, 24, 3);
            txtMaLH.Name = "txtMaLH";
            txtMaLH.TabIndex = 0;
            //
            // lblBacSi
            //
            lblBacSi.Anchor = AnchorStyles.Left;
            lblBacSi.AutoSize = true;
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Text = "Bác sĩ:";
            //
            // cboBacSi
            //
            cboBacSi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBacSi.Items.AddRange(new object[] { "BS. Nguyễn Văn An - Nội khoa", "BS. Trần Thị Bình - Nhi khoa", "BS. Lê Minh Cường - Răng Hàm Mặt", "BS. Phạm Thu Dung - Da liễu", "BS. Hoàng Đức Em - Tai Mũi Họng" });
            cboBacSi.Name = "cboBacSi";
            cboBacSi.TabIndex = 3;
            //
            // lblHoTen
            //
            lblHoTen.Anchor = AnchorStyles.Left;
            lblHoTen.AutoSize = true;
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ tên bệnh nhân:";
            //
            // txtHoTen
            //
            txtHoTen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Margin = new Padding(3, 3, 24, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.TabIndex = 1;
            //
            // lblNgayHen
            //
            lblNgayHen.Anchor = AnchorStyles.Left;
            lblNgayHen.AutoSize = true;
            lblNgayHen.Name = "lblNgayHen";
            lblNgayHen.Text = "Ngày giờ hẹn:";
            //
            // dtpNgayHen
            //
            dtpNgayHen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayHen.CustomFormat = "dd/MM/yyyy  HH:mm";
            dtpNgayHen.Format = DateTimePickerFormat.Custom;
            dtpNgayHen.Name = "dtpNgayHen";
            dtpNgayHen.TabIndex = 4;
            //
            // lblSDT
            //
            lblSDT.Anchor = AnchorStyles.Left;
            lblSDT.AutoSize = true;
            lblSDT.Name = "lblSDT";
            lblSDT.Text = "Số điện thoại:";
            //
            // txtSDT
            //
            txtSDT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSDT.Margin = new Padding(3, 3, 24, 3);
            txtSDT.MaxLength = 15;
            txtSDT.Name = "txtSDT";
            txtSDT.TabIndex = 2;
            //
            // lblTrangThai
            //
            lblTrangThai.Anchor = AnchorStyles.Left;
            lblTrangThai.AutoSize = true;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Text = "Trạng thái:";
            //
            // cboTrangThai
            //
            cboTrangThai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.TabIndex = 5;
            //
            // lblLyDo
            //
            lblLyDo.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lblLyDo.AutoSize = true;
            lblLyDo.Margin = new Padding(3, 8, 3, 0);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Text = "Lý do khám:";
            //
            // txtLyDo
            //
            txtLyDo.Dock = DockStyle.Fill;
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.ScrollBars = ScrollBars.Vertical;
            txtLyDo.TabIndex = 6;
            //
            // flpNut
            //
            flpNut.Controls.Add(btnThem);
            flpNut.Controls.Add(btnCapNhat);
            flpNut.Controls.Add(btnXoa);
            flpNut.Controls.Add(btnLamMoi);
            flpNut.Dock = DockStyle.Fill;
            flpNut.Name = "flpNut";
            flpNut.TabIndex = 1;
            //
            // btnThem
            //
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 32);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            //
            // btnCapNhat
            //
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(110, 32);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            //
            // btnXoa
            //
            btnXoa.ForeColor = Color.Firebrick;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 32);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            //
            // btnLamMoi
            //
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 32);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới ô nhập";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            //
            // grpTimKiem
            //
            grpTimKiem.Controls.Add(flpLoc);
            grpTimKiem.Dock = DockStyle.Fill;
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.TabIndex = 2;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm và lọc";
            //
            // flpLoc
            //
            flpLoc.Controls.Add(lblTimKiem);
            flpLoc.Controls.Add(txtTimKiem);
            flpLoc.Controls.Add(lblLocNgay);
            flpLoc.Controls.Add(dtpLocNgay);
            flpLoc.Controls.Add(lblLocTrangThai);
            flpLoc.Controls.Add(cboLocTrangThai);
            flpLoc.Controls.Add(btnBoLoc);
            flpLoc.Dock = DockStyle.Fill;
            flpLoc.Name = "flpLoc";
            flpLoc.TabIndex = 0;
            flpLoc.WrapContents = false;
            //
            // lblTimKiem
            //
            lblTimKiem.AutoSize = true;
            lblTimKiem.Margin = new Padding(3, 7, 3, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Text = "Tên / SĐT:";
            //
            // txtTimKiem
            //
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 23);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += BoLoc_Changed;
            //
            // lblLocNgay
            //
            lblLocNgay.AutoSize = true;
            lblLocNgay.Margin = new Padding(18, 7, 3, 0);
            lblLocNgay.Name = "lblLocNgay";
            lblLocNgay.Text = "Ngày hẹn:";
            //
            // dtpLocNgay
            //
            dtpLocNgay.Checked = false;
            dtpLocNgay.CustomFormat = "dd/MM/yyyy";
            dtpLocNgay.Format = DateTimePickerFormat.Custom;
            dtpLocNgay.Name = "dtpLocNgay";
            dtpLocNgay.ShowCheckBox = true;
            dtpLocNgay.Size = new Size(130, 23);
            dtpLocNgay.TabIndex = 1;
            dtpLocNgay.ValueChanged += BoLoc_Changed;
            //
            // lblLocTrangThai
            //
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.Margin = new Padding(18, 7, 3, 0);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.Text = "Trạng thái:";
            //
            // cboLocTrangThai
            //
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(130, 23);
            cboLocTrangThai.TabIndex = 2;
            cboLocTrangThai.SelectedIndexChanged += BoLoc_Changed;
            //
            // btnBoLoc
            //
            btnBoLoc.Margin = new Padding(18, 2, 3, 3);
            btnBoLoc.Name = "btnBoLoc";
            btnBoLoc.Size = new Size(90, 27);
            btnBoLoc.TabIndex = 3;
            btnBoLoc.Text = "Bỏ lọc";
            btnBoLoc.UseVisualStyleBackColor = true;
            btnBoLoc.Click += btnBoLoc_Click;
            //
            // dgvLichHen
            //
            dgvLichHen.AllowUserToAddRows = false;
            dgvLichHen.AllowUserToDeleteRows = false;
            dgvLichHen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichHen.BackgroundColor = Color.White;
            dgvLichHen.Columns.AddRange(new DataGridViewColumn[] { colMaLH, colHoTen, colSDT, colNgayHen, colBacSi, colLyDo, colTrangThai });
            dgvLichHen.Dock = DockStyle.Fill;
            dgvLichHen.MultiSelect = false;
            dgvLichHen.Name = "dgvLichHen";
            dgvLichHen.ReadOnly = true;
            dgvLichHen.RowHeadersVisible = false;
            dgvLichHen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichHen.TabIndex = 3;
            dgvLichHen.SelectionChanged += dgvLichHen_SelectionChanged;
            //
            // colMaLH
            //
            colMaLH.DataPropertyName = "MaLH";
            colMaLH.FillWeight = 10F;
            colMaLH.HeaderText = "Mã LH";
            colMaLH.Name = "colMaLH";
            colMaLH.ReadOnly = true;
            //
            // colHoTen
            //
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 18F;
            colHoTen.HeaderText = "Họ tên bệnh nhân";
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            //
            // colSDT
            //
            colSDT.DataPropertyName = "SoDienThoai";
            colSDT.FillWeight = 12F;
            colSDT.HeaderText = "Số điện thoại";
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            //
            // colNgayHen
            //
            colNgayHen.DataPropertyName = "NgayGioHen";
            colNgayHen.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            colNgayHen.FillWeight = 13F;
            colNgayHen.HeaderText = "Ngày giờ hẹn";
            colNgayHen.Name = "colNgayHen";
            colNgayHen.ReadOnly = true;
            //
            // colBacSi
            //
            colBacSi.DataPropertyName = "BacSi";
            colBacSi.FillWeight = 20F;
            colBacSi.HeaderText = "Bác sĩ";
            colBacSi.Name = "colBacSi";
            colBacSi.ReadOnly = true;
            //
            // colLyDo
            //
            colLyDo.DataPropertyName = "LyDo";
            colLyDo.FillWeight = 17F;
            colLyDo.HeaderText = "Lý do khám";
            colLyDo.Name = "colLyDo";
            colLyDo.ReadOnly = true;
            //
            // colTrangThai
            //
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 10F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            //
            // errorProvider1
            //
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            //
            // saveFileDialog1
            //
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "File CSV (*.csv)|*.csv";
            saveFileDialog1.Title = "Xuất danh sách lịch hẹn";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 620);
            Controls.Add(tlpMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(860, 520);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager - Quản lý lịch hẹn phòng khám";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tlpMain.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            tlpNhap.ResumeLayout(false);
            tlpNhap.PerformLayout();
            flpNut.ResumeLayout(false);
            grpTimKiem.ResumeLayout(false);
            flpLoc.ResumeLayout(false);
            flpLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLichHen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTep;
        private ToolStripMenuItem mnuXuatCsv;
        private ToolStripSeparator mnuSep1;
        private ToolStripMenuItem mnuThoat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoLichHen;
        private ToolStripStatusLabel lblThongBao;
        private TableLayoutPanel tlpMain;
        private GroupBox grpThongTin;
        private TableLayoutPanel tlpNhap;
        private Label lblMaLH;
        private TextBox txtMaLH;
        private Label lblBacSi;
        private ComboBox cboBacSi;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgayHen;
        private DateTimePicker dtpNgayHen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private Label lblLyDo;
        private TextBox txtLyDo;
        private FlowLayoutPanel flpNut;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox grpTimKiem;
        private FlowLayoutPanel flpLoc;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Label lblLocNgay;
        private DateTimePicker dtpLocNgay;
        private Label lblLocTrangThai;
        private ComboBox cboLocTrangThai;
        private Button btnBoLoc;
        private DataGridView dgvLichHen;
        private DataGridViewTextBoxColumn colMaLH;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colNgayHen;
        private DataGridViewTextBoxColumn colBacSi;
        private DataGridViewTextBoxColumn colLyDo;
        private DataGridViewTextBoxColumn colTrangThai;
        private BindingSource bsLichHen;
        private ErrorProvider errorProvider1;
        private SaveFileDialog saveFileDialog1;
    }
}
