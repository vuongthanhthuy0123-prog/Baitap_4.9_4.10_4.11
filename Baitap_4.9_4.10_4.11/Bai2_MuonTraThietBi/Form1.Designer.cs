namespace Bai2
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
            lblTongPhieu = new ToolStripStatusLabel();
            lblQuaHan = new ToolStripStatusLabel();
            lblDangHienThi = new ToolStripStatusLabel();
            lblThongBao = new ToolStripStatusLabel();
            grpThongTin = new GroupBox();
            tlpNhap = new TableLayoutPanel();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblNgayMuon = new Label();
            dtpNgayMuon = new DateTimePicker();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHanTra = new Label();
            dtpHanTra = new DateTimePicker();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgayTra = new Label();
            dtpNgayTra = new DateTimePicker();
            lblThietBi = new Label();
            cboThietBi = new ComboBox();
            lblTinhTrang = new Label();
            txtTinhTrang = new TextBox();
            lblSoLuong = new Label();
            numSoLuong = new NumericUpDown();
            lblGhiChu = new Label();
            flpNut = new FlowLayoutPanel();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnDaTra = new Button();
            btnLamMoi = new Button();
            grpTimKiem = new GroupBox();
            flpLoc = new FlowLayoutPanel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            lblLocTinhTrang = new Label();
            cboLocTinhTrang = new ComboBox();
            btnBoLoc = new Button();
            dgvPhieu = new DataGridView();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colThietBi = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colNgayMuon = new DataGridViewTextBoxColumn();
            colHanTra = new DataGridViewTextBoxColumn();
            colNgayTra = new DataGridViewTextBoxColumn();
            colTinhTrang = new DataGridViewTextBoxColumn();
            bsPhieu = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            grpThongTin.SuspendLayout();
            tlpNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            flpNut.SuspendLayout();
            grpTimKiem.SuspendLayout();
            flpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPhieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTep });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1040, 24);
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
            mnuXuatCsv.Text = "Xuất CSV các phiếu đang lọc...";
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
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTongPhieu, lblQuaHan, lblDangHienThi, lblThongBao });
            statusStrip1.Location = new Point(0, 618);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1040, 22);
            statusStrip1.TabIndex = 5;
            //
            // lblTongPhieu
            //
            lblTongPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongPhieu.Name = "lblTongPhieu";
            lblTongPhieu.Size = new Size(110, 17);
            lblTongPhieu.Text = "Tổng số phiếu: 0";
            //
            // lblQuaHan
            //
            lblQuaHan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQuaHan.ForeColor = Color.Firebrick;
            lblQuaHan.Name = "lblQuaHan";
            lblQuaHan.Size = new Size(80, 17);
            lblQuaHan.Text = "Quá hạn: 0";
            //
            // lblDangHienThi
            //
            lblDangHienThi.Name = "lblDangHienThi";
            lblDangHienThi.Size = new Size(100, 17);
            lblDangHienThi.Text = "Đang hiển thị: 0";
            //
            // lblThongBao
            //
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(735, 17);
            lblThongBao.Spring = true;
            lblThongBao.Text = "Sẵn sàng";
            lblThongBao.TextAlign = ContentAlignment.MiddleLeft;
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(tlpNhap);
            grpThongTin.Dock = DockStyle.Top;
            grpThongTin.Location = new Point(0, 24);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(8, 4, 8, 4);
            grpThongTin.Size = new Size(1040, 196);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Phiếu mượn thiết bị";
            //
            // tlpNhap
            //
            tlpNhap.ColumnCount = 4;
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNhap.Controls.Add(lblMaPhieu, 0, 0);
            tlpNhap.Controls.Add(txtMaPhieu, 1, 0);
            tlpNhap.Controls.Add(lblNgayMuon, 2, 0);
            tlpNhap.Controls.Add(dtpNgayMuon, 3, 0);
            tlpNhap.Controls.Add(lblMaSV, 0, 1);
            tlpNhap.Controls.Add(txtMaSV, 1, 1);
            tlpNhap.Controls.Add(lblHanTra, 2, 1);
            tlpNhap.Controls.Add(dtpHanTra, 3, 1);
            tlpNhap.Controls.Add(lblHoTen, 0, 2);
            tlpNhap.Controls.Add(txtHoTen, 1, 2);
            tlpNhap.Controls.Add(lblNgayTra, 2, 2);
            tlpNhap.Controls.Add(dtpNgayTra, 3, 2);
            tlpNhap.Controls.Add(lblThietBi, 0, 3);
            tlpNhap.Controls.Add(cboThietBi, 1, 3);
            tlpNhap.Controls.Add(lblTinhTrang, 2, 3);
            tlpNhap.Controls.Add(txtTinhTrang, 3, 3);
            tlpNhap.Controls.Add(lblSoLuong, 0, 4);
            tlpNhap.Controls.Add(numSoLuong, 1, 4);
            tlpNhap.Controls.Add(lblGhiChu, 2, 4);
            tlpNhap.SetColumnSpan(lblGhiChu, 2);
            tlpNhap.Dock = DockStyle.Fill;
            tlpNhap.Name = "tlpNhap";
            tlpNhap.Padding = new Padding(0, 0, 24, 0);
            tlpNhap.RowCount = 5;
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpNhap.TabIndex = 0;
            //
            // lblMaPhieu
            //
            lblMaPhieu.Anchor = AnchorStyles.Left;
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Text = "Mã phiếu:";
            //
            // txtMaPhieu
            //
            txtMaPhieu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaPhieu.Margin = new Padding(3, 3, 24, 3);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.TabIndex = 0;
            //
            // lblNgayMuon
            //
            lblNgayMuon.Anchor = AnchorStyles.Left;
            lblNgayMuon.AutoSize = true;
            lblNgayMuon.Name = "lblNgayMuon";
            lblNgayMuon.Text = "Ngày mượn:";
            //
            // dtpNgayMuon
            //
            dtpNgayMuon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.TabIndex = 5;
            dtpNgayMuon.ValueChanged += NgayThayDoi;
            //
            // lblMaSV
            //
            lblMaSV.Anchor = AnchorStyles.Left;
            lblMaSV.AutoSize = true;
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Text = "Mã sinh viên:";
            //
            // txtMaSV
            //
            txtMaSV.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaSV.Margin = new Padding(3, 3, 24, 3);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.TabIndex = 1;
            //
            // lblHanTra
            //
            lblHanTra.Anchor = AnchorStyles.Left;
            lblHanTra.AutoSize = true;
            lblHanTra.Name = "lblHanTra";
            lblHanTra.Text = "Hạn trả:";
            //
            // dtpHanTra
            //
            dtpHanTra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpHanTra.CustomFormat = "dd/MM/yyyy";
            dtpHanTra.Format = DateTimePickerFormat.Custom;
            dtpHanTra.Name = "dtpHanTra";
            dtpHanTra.TabIndex = 6;
            dtpHanTra.ValueChanged += NgayThayDoi;
            //
            // lblHoTen
            //
            lblHoTen.Anchor = AnchorStyles.Left;
            lblHoTen.AutoSize = true;
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ tên sinh viên:";
            //
            // txtHoTen
            //
            txtHoTen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Margin = new Padding(3, 3, 24, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.TabIndex = 2;
            //
            // lblNgayTra
            //
            lblNgayTra.Anchor = AnchorStyles.Left;
            lblNgayTra.AutoSize = true;
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Text = "Ngày trả thực tế:";
            //
            // dtpNgayTra
            //
            dtpNgayTra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayTra.Checked = false;
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.ShowCheckBox = true;
            dtpNgayTra.TabIndex = 7;
            dtpNgayTra.ValueChanged += NgayThayDoi;
            //
            // lblThietBi
            //
            lblThietBi.Anchor = AnchorStyles.Left;
            lblThietBi.AutoSize = true;
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Text = "Thiết bị:";
            //
            // cboThietBi
            //
            cboThietBi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboThietBi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThietBi.Items.AddRange(new object[] { "Laptop", "Máy chiếu", "Arduino Uno", "Raspberry Pi 4", "Đồng hồ vạn năng", "Bộ kit điện tử", "Webcam", "Tai nghe" });
            cboThietBi.Margin = new Padding(3, 3, 24, 3);
            cboThietBi.Name = "cboThietBi";
            cboThietBi.TabIndex = 3;
            //
            // lblTinhTrang
            //
            lblTinhTrang.Anchor = AnchorStyles.Left;
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Text = "Tình trạng:";
            //
            // txtTinhTrang
            //
            txtTinhTrang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTinhTrang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.ReadOnly = true;
            txtTinhTrang.TabStop = false;
            //
            // lblSoLuong
            //
            lblSoLuong.Anchor = AnchorStyles.Left;
            lblSoLuong.AutoSize = true;
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Text = "Số lượng:";
            //
            // numSoLuong
            //
            numSoLuong.Anchor = AnchorStyles.Left;
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(100, 23);
            numSoLuong.TabIndex = 4;
            //
            // lblGhiChu
            //
            lblGhiChu.Anchor = AnchorStyles.Left;
            lblGhiChu.AutoSize = true;
            lblGhiChu.ForeColor = Color.DimGray;
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Text = "Tích ô \"Ngày trả thực tế\" khi sinh viên đã trả. Tình trạng được tự xác định.";
            //
            // flpNut
            //
            flpNut.Controls.Add(btnThem);
            flpNut.Controls.Add(btnCapNhat);
            flpNut.Controls.Add(btnXoa);
            flpNut.Controls.Add(btnDaTra);
            flpNut.Controls.Add(btnLamMoi);
            flpNut.Dock = DockStyle.Top;
            flpNut.Location = new Point(0, 220);
            flpNut.Name = "flpNut";
            flpNut.Padding = new Padding(6, 4, 6, 0);
            flpNut.Size = new Size(1040, 44);
            flpNut.TabIndex = 2;
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
            // btnDaTra
            //
            btnDaTra.ForeColor = Color.SeaGreen;
            btnDaTra.Name = "btnDaTra";
            btnDaTra.Size = new Size(140, 32);
            btnDaTra.TabIndex = 3;
            btnDaTra.Text = "Đánh dấu đã trả";
            btnDaTra.UseVisualStyleBackColor = true;
            btnDaTra.Click += btnDaTra_Click;
            //
            // btnLamMoi
            //
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 32);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới ô nhập";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            //
            // grpTimKiem
            //
            grpTimKiem.Controls.Add(flpLoc);
            grpTimKiem.Dock = DockStyle.Top;
            grpTimKiem.Location = new Point(0, 264);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Padding = new Padding(8, 4, 8, 4);
            grpTimKiem.Size = new Size(1040, 60);
            grpTimKiem.TabIndex = 3;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm và lọc";
            //
            // flpLoc
            //
            flpLoc.Controls.Add(lblTimKiem);
            flpLoc.Controls.Add(txtTimKiem);
            flpLoc.Controls.Add(lblLocTinhTrang);
            flpLoc.Controls.Add(cboLocTinhTrang);
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
            lblTimKiem.Text = "Mã SV / Thiết bị:";
            //
            // txtTimKiem
            //
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 23);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += BoLoc_Changed;
            //
            // lblLocTinhTrang
            //
            lblLocTinhTrang.AutoSize = true;
            lblLocTinhTrang.Margin = new Padding(18, 7, 3, 0);
            lblLocTinhTrang.Name = "lblLocTinhTrang";
            lblLocTinhTrang.Text = "Tình trạng:";
            //
            // cboLocTinhTrang
            //
            cboLocTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTinhTrang.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Quá hạn", "Đã trả" });
            cboLocTinhTrang.Name = "cboLocTinhTrang";
            cboLocTinhTrang.Size = new Size(130, 23);
            cboLocTinhTrang.TabIndex = 1;
            cboLocTinhTrang.SelectedIndexChanged += BoLoc_Changed;
            //
            // btnBoLoc
            //
            btnBoLoc.Margin = new Padding(18, 2, 3, 3);
            btnBoLoc.Name = "btnBoLoc";
            btnBoLoc.Size = new Size(90, 27);
            btnBoLoc.TabIndex = 2;
            btnBoLoc.Text = "Bỏ lọc";
            btnBoLoc.UseVisualStyleBackColor = true;
            btnBoLoc.Click += btnBoLoc_Click;
            //
            // dgvPhieu
            //
            dgvPhieu.AllowUserToAddRows = false;
            dgvPhieu.AllowUserToDeleteRows = false;
            dgvPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieu.BackgroundColor = Color.White;
            dgvPhieu.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu, colMaSV, colHoTen, colThietBi, colSoLuong, colNgayMuon, colHanTra, colNgayTra, colTinhTrang });
            dgvPhieu.Dock = DockStyle.Fill;
            dgvPhieu.Location = new Point(0, 324);
            dgvPhieu.MultiSelect = false;
            dgvPhieu.Name = "dgvPhieu";
            dgvPhieu.ReadOnly = true;
            dgvPhieu.RowHeadersVisible = false;
            dgvPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieu.Size = new Size(1040, 294);
            dgvPhieu.TabIndex = 4;
            dgvPhieu.CellFormatting += dgvPhieu_CellFormatting;
            dgvPhieu.SelectionChanged += dgvPhieu_SelectionChanged;
            //
            // colMaPhieu
            //
            colMaPhieu.DataPropertyName = "MaPhieu";
            colMaPhieu.FillWeight = 9F;
            colMaPhieu.HeaderText = "Mã phiếu";
            colMaPhieu.Name = "colMaPhieu";
            colMaPhieu.ReadOnly = true;
            //
            // colMaSV
            //
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.FillWeight = 11F;
            colMaSV.HeaderText = "Mã SV";
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            //
            // colHoTen
            //
            colHoTen.DataPropertyName = "HoTenSV";
            colHoTen.FillWeight = 16F;
            colHoTen.HeaderText = "Họ tên sinh viên";
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            //
            // colThietBi
            //
            colThietBi.DataPropertyName = "ThietBi";
            colThietBi.FillWeight = 14F;
            colThietBi.HeaderText = "Thiết bị";
            colThietBi.Name = "colThietBi";
            colThietBi.ReadOnly = true;
            //
            // colSoLuong
            //
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoLuong.FillWeight = 6F;
            colSoLuong.HeaderText = "SL";
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            //
            // colNgayMuon
            //
            colNgayMuon.DataPropertyName = "NgayMuon";
            colNgayMuon.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgayMuon.FillWeight = 10F;
            colNgayMuon.HeaderText = "Ngày mượn";
            colNgayMuon.Name = "colNgayMuon";
            colNgayMuon.ReadOnly = true;
            //
            // colHanTra
            //
            colHanTra.DataPropertyName = "HanTra";
            colHanTra.DefaultCellStyle.Format = "dd/MM/yyyy";
            colHanTra.FillWeight = 10F;
            colHanTra.HeaderText = "Hạn trả";
            colHanTra.Name = "colHanTra";
            colHanTra.ReadOnly = true;
            //
            // colNgayTra
            //
            colNgayTra.DataPropertyName = "NgayTraThucTe";
            colNgayTra.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgayTra.FillWeight = 11F;
            colNgayTra.HeaderText = "Ngày trả thực tế";
            colNgayTra.Name = "colNgayTra";
            colNgayTra.ReadOnly = true;
            //
            // colTinhTrang
            //
            colTinhTrang.DataPropertyName = "TinhTrang";
            colTinhTrang.FillWeight = 10F;
            colTinhTrang.HeaderText = "Tình trạng";
            colTinhTrang.Name = "colTinhTrang";
            colTinhTrang.ReadOnly = true;
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
            saveFileDialog1.Title = "Xuất danh sách phiếu mượn";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 640);
            Controls.Add(dgvPhieu);
            Controls.Add(grpTimKiem);
            Controls.Add(flpNut);
            Controls.Add(grpThongTin);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(900, 560);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab Equipment Checkout - Quản lý mượn trả thiết bị";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpThongTin.ResumeLayout(false);
            tlpNhap.ResumeLayout(false);
            tlpNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            flpNut.ResumeLayout(false);
            grpTimKiem.ResumeLayout(false);
            flpLoc.ResumeLayout(false);
            flpLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPhieu).EndInit();
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
        private ToolStripStatusLabel lblTongPhieu;
        private ToolStripStatusLabel lblQuaHan;
        private ToolStripStatusLabel lblDangHienThi;
        private ToolStripStatusLabel lblThongBao;
        private GroupBox grpThongTin;
        private TableLayoutPanel tlpNhap;
        private Label lblMaPhieu;
        private TextBox txtMaPhieu;
        private Label lblNgayMuon;
        private DateTimePicker dtpNgayMuon;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblHanTra;
        private DateTimePicker dtpHanTra;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgayTra;
        private DateTimePicker dtpNgayTra;
        private Label lblThietBi;
        private ComboBox cboThietBi;
        private Label lblTinhTrang;
        private TextBox txtTinhTrang;
        private Label lblSoLuong;
        private NumericUpDown numSoLuong;
        private Label lblGhiChu;
        private FlowLayoutPanel flpNut;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnDaTra;
        private Button btnLamMoi;
        private GroupBox grpTimKiem;
        private FlowLayoutPanel flpLoc;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Label lblLocTinhTrang;
        private ComboBox cboLocTinhTrang;
        private Button btnBoLoc;
        private DataGridView dgvPhieu;
        private DataGridViewTextBoxColumn colMaPhieu;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colThietBi;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colNgayMuon;
        private DataGridViewTextBoxColumn colHanTra;
        private DataGridViewTextBoxColumn colNgayTra;
        private DataGridViewTextBoxColumn colTinhTrang;
        private BindingSource bsPhieu;
        private ErrorProvider errorProvider1;
        private SaveFileDialog saveFileDialog1;
    }
}
