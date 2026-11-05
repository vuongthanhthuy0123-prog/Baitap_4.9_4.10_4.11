namespace Bai3
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
            lblSoDon = new ToolStripStatusLabel();
            lblTongChiPhi = new ToolStripStatusLabel();
            lblThongBao = new ToolStripStatusLabel();
            tlpMain = new TableLayoutPanel();
            grpThongTin = new GroupBox();
            tlpNhap = new TableLayoutPanel();
            lblMaDon = new Label();
            txtMaDon = new TextBox();
            lblLoai = new Label();
            cboLoai = new ComboBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblNgay = new Label();
            dtpNgayTiepNhan = new DateTimePicker();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            lblChiPhi = new Label();
            txtChiPhi = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            pnlAnh = new Panel();
            picAnh = new PictureBox();
            flpAnh = new FlowLayoutPanel();
            btnChonAnh = new Button();
            btnBoAnh = new Button();
            flpNut = new FlowLayoutPanel();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpTimKiem = new GroupBox();
            flpLoc = new FlowLayoutPanel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            lblLocTrangThai = new Label();
            cboLocTrangThai = new ComboBox();
            btnBoLoc = new Button();
            dgvDon = new DataGridView();
            colMaDon = new DataGridViewTextBoxColumn();
            colTenKH = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colLoai = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            colNgay = new DataGridViewTextBoxColumn();
            colChiPhi = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            bsDon = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tlpMain.SuspendLayout();
            grpThongTin.SuspendLayout();
            tlpNhap.SuspendLayout();
            pnlAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            flpAnh.SuspendLayout();
            flpNut.SuspendLayout();
            grpTimKiem.SuspendLayout();
            flpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTep });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1060, 24);
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
            mnuXuatCsv.Size = new Size(270, 22);
            mnuXuatCsv.Text = "Xuất CSV danh sách đang hiển thị...";
            mnuXuatCsv.Click += mnuXuatCsv_Click;
            //
            // mnuSep1
            //
            mnuSep1.Name = "mnuSep1";
            mnuSep1.Size = new Size(267, 6);
            //
            // mnuThoat
            //
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(270, 22);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            //
            // statusStrip1
            //
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoDon, lblTongChiPhi, lblThongBao });
            statusStrip1.Location = new Point(0, 638);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1060, 22);
            statusStrip1.TabIndex = 2;
            //
            // lblSoDon
            //
            lblSoDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoDon.Name = "lblSoDon";
            lblSoDon.Size = new Size(70, 17);
            lblSoDon.Text = "Số đơn: 0";
            //
            // lblTongChiPhi
            //
            lblTongChiPhi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongChiPhi.ForeColor = Color.DarkGreen;
            lblTongChiPhi.Name = "lblTongChiPhi";
            lblTongChiPhi.Size = new Size(260, 17);
            lblTongChiPhi.Text = "Tổng chi phí dự kiến (chưa hoàn tất): 0 đ";
            //
            // lblThongBao
            //
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(715, 17);
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
            tlpMain.Controls.Add(dgvDon, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 24);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(6);
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 236F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1060, 614);
            tlpMain.TabIndex = 1;
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(tlpNhap);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Name = "grpThongTin";
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin đơn sửa chữa";
            //
            // tlpNhap
            //
            tlpNhap.ColumnCount = 5;
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tlpNhap.Controls.Add(lblMaDon, 0, 0);
            tlpNhap.Controls.Add(txtMaDon, 1, 0);
            tlpNhap.Controls.Add(lblLoai, 2, 0);
            tlpNhap.Controls.Add(cboLoai, 3, 0);
            tlpNhap.Controls.Add(lblTenKH, 0, 1);
            tlpNhap.Controls.Add(txtTenKH, 1, 1);
            tlpNhap.Controls.Add(lblNgay, 2, 1);
            tlpNhap.Controls.Add(dtpNgayTiepNhan, 3, 1);
            tlpNhap.Controls.Add(lblSDT, 0, 2);
            tlpNhap.Controls.Add(txtSDT, 1, 2);
            tlpNhap.Controls.Add(lblTrangThai, 2, 2);
            tlpNhap.Controls.Add(cboTrangThai, 3, 2);
            tlpNhap.Controls.Add(lblChiPhi, 0, 3);
            tlpNhap.Controls.Add(txtChiPhi, 1, 3);
            tlpNhap.Controls.Add(lblMoTa, 0, 4);
            tlpNhap.Controls.Add(txtMoTa, 1, 4);
            tlpNhap.Controls.Add(pnlAnh, 4, 0);
            tlpNhap.SetColumnSpan(txtMoTa, 3);
            tlpNhap.SetRowSpan(pnlAnh, 5);
            tlpNhap.Dock = DockStyle.Fill;
            tlpNhap.Name = "tlpNhap";
            tlpNhap.RowCount = 5;
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpNhap.TabIndex = 0;
            //
            // lblMaDon
            //
            lblMaDon.Anchor = AnchorStyles.Left;
            lblMaDon.AutoSize = true;
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Text = "Mã đơn:";
            //
            // txtMaDon
            //
            txtMaDon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaDon.Margin = new Padding(3, 3, 24, 3);
            txtMaDon.Name = "txtMaDon";
            txtMaDon.TabIndex = 0;
            //
            // lblLoai
            //
            lblLoai.Anchor = AnchorStyles.Left;
            lblLoai.AutoSize = true;
            lblLoai.Name = "lblLoai";
            lblLoai.Text = "Loại thiết bị:";
            //
            // cboLoai
            //
            cboLoai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoai.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Máy tính bàn", "Máy tính bảng", "Tivi", "Máy in", "Khác" });
            cboLoai.Margin = new Padding(3, 3, 24, 3);
            cboLoai.Name = "cboLoai";
            cboLoai.TabIndex = 4;
            //
            // lblTenKH
            //
            lblTenKH.Anchor = AnchorStyles.Left;
            lblTenKH.AutoSize = true;
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Text = "Tên khách hàng:";
            //
            // txtTenKH
            //
            txtTenKH.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenKH.Margin = new Padding(3, 3, 24, 3);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.TabIndex = 1;
            //
            // lblNgay
            //
            lblNgay.Anchor = AnchorStyles.Left;
            lblNgay.AutoSize = true;
            lblNgay.Name = "lblNgay";
            lblNgay.Text = "Ngày tiếp nhận:";
            //
            // dtpNgayTiepNhan
            //
            dtpNgayTiepNhan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayTiepNhan.CustomFormat = "dd/MM/yyyy";
            dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom;
            dtpNgayTiepNhan.Margin = new Padding(3, 3, 24, 3);
            dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            dtpNgayTiepNhan.TabIndex = 5;
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
            cboTrangThai.Items.AddRange(new object[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            cboTrangThai.Margin = new Padding(3, 3, 24, 3);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.TabIndex = 6;
            //
            // lblChiPhi
            //
            lblChiPhi.Anchor = AnchorStyles.Left;
            lblChiPhi.AutoSize = true;
            lblChiPhi.Name = "lblChiPhi";
            lblChiPhi.Text = "Chi phí dự kiến (đ):";
            //
            // txtChiPhi
            //
            txtChiPhi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtChiPhi.Margin = new Padding(3, 3, 24, 3);
            txtChiPhi.Name = "txtChiPhi";
            txtChiPhi.TabIndex = 3;
            txtChiPhi.TextAlign = HorizontalAlignment.Right;
            //
            // lblMoTa
            //
            lblMoTa.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lblMoTa.AutoSize = true;
            lblMoTa.Margin = new Padding(3, 8, 3, 0);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Text = "Mô tả lỗi:";
            //
            // txtMoTa
            //
            txtMoTa.Dock = DockStyle.Fill;
            txtMoTa.Margin = new Padding(3, 3, 24, 3);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.TabIndex = 7;
            //
            // pnlAnh
            //
            pnlAnh.Controls.Add(picAnh);
            pnlAnh.Controls.Add(flpAnh);
            pnlAnh.Dock = DockStyle.Fill;
            pnlAnh.Name = "pnlAnh";
            pnlAnh.TabIndex = 8;
            //
            // picAnh
            //
            picAnh.BackColor = Color.WhiteSmoke;
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Dock = DockStyle.Fill;
            picAnh.Name = "picAnh";
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabStop = false;
            //
            // flpAnh
            //
            flpAnh.Controls.Add(btnChonAnh);
            flpAnh.Controls.Add(btnBoAnh);
            flpAnh.Dock = DockStyle.Bottom;
            flpAnh.Name = "flpAnh";
            flpAnh.Size = new Size(214, 36);
            flpAnh.TabIndex = 0;
            //
            // btnChonAnh
            //
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(110, 28);
            btnChonAnh.TabIndex = 0;
            btnChonAnh.Text = "Chọn ảnh...";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            //
            // btnBoAnh
            //
            btnBoAnh.Name = "btnBoAnh";
            btnBoAnh.Size = new Size(90, 28);
            btnBoAnh.TabIndex = 1;
            btnBoAnh.Text = "Bỏ ảnh";
            btnBoAnh.UseVisualStyleBackColor = true;
            btnBoAnh.Click += btnBoAnh_Click;
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
            btnLamMoi.Size = new Size(120, 32);
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
            lblTimKiem.Text = "Mã đơn / Tên KH / SĐT:";
            //
            // txtTimKiem
            //
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(230, 23);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += BoLoc_Changed;
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
            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(140, 23);
            cboLocTrangThai.TabIndex = 1;
            cboLocTrangThai.SelectedIndexChanged += BoLoc_Changed;
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
            // dgvDon
            //
            dgvDon.AllowUserToAddRows = false;
            dgvDon.AllowUserToDeleteRows = false;
            dgvDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDon.BackgroundColor = Color.White;
            dgvDon.Columns.AddRange(new DataGridViewColumn[] { colMaDon, colTenKH, colSDT, colLoai, colMoTa, colNgay, colChiPhi, colTrangThai });
            dgvDon.Dock = DockStyle.Fill;
            dgvDon.MultiSelect = false;
            dgvDon.Name = "dgvDon";
            dgvDon.ReadOnly = true;
            dgvDon.RowHeadersVisible = false;
            dgvDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDon.TabIndex = 3;
            dgvDon.SelectionChanged += dgvDon_SelectionChanged;
            //
            // colMaDon
            //
            colMaDon.DataPropertyName = "MaDon";
            colMaDon.FillWeight = 9F;
            colMaDon.HeaderText = "Mã đơn";
            colMaDon.Name = "colMaDon";
            colMaDon.ReadOnly = true;
            //
            // colTenKH
            //
            colTenKH.DataPropertyName = "TenKhachHang";
            colTenKH.FillWeight = 16F;
            colTenKH.HeaderText = "Khách hàng";
            colTenKH.Name = "colTenKH";
            colTenKH.ReadOnly = true;
            //
            // colSDT
            //
            colSDT.DataPropertyName = "SoDienThoai";
            colSDT.FillWeight = 11F;
            colSDT.HeaderText = "Số điện thoại";
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            //
            // colLoai
            //
            colLoai.DataPropertyName = "LoaiThietBi";
            colLoai.FillWeight = 11F;
            colLoai.HeaderText = "Loại thiết bị";
            colLoai.Name = "colLoai";
            colLoai.ReadOnly = true;
            //
            // colMoTa
            //
            colMoTa.DataPropertyName = "MoTaLoi";
            colMoTa.FillWeight = 22F;
            colMoTa.HeaderText = "Mô tả lỗi";
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            //
            // colNgay
            //
            colNgay.DataPropertyName = "NgayTiepNhan";
            colNgay.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgay.FillWeight = 10F;
            colNgay.HeaderText = "Ngày tiếp nhận";
            colNgay.Name = "colNgay";
            colNgay.ReadOnly = true;
            //
            // colChiPhi
            //
            colChiPhi.DataPropertyName = "ChiPhiDuKien";
            colChiPhi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colChiPhi.DefaultCellStyle.Format = "N0";
            colChiPhi.FillWeight = 11F;
            colChiPhi.HeaderText = "Chi phí dự kiến";
            colChiPhi.Name = "colChiPhi";
            colChiPhi.ReadOnly = true;
            //
            // colTrangThai
            //
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 11F;
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
            saveFileDialog1.Title = "Xuất danh sách đơn sửa chữa";
            //
            // openFileDialog1
            //
            openFileDialog1.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Chọn ảnh thiết bị";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 660);
            Controls.Add(tlpMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(940, 580);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repair Service Tracker - Quản lý đơn sửa chữa";
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
            pnlAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            flpAnh.ResumeLayout(false);
            flpNut.ResumeLayout(false);
            grpTimKiem.ResumeLayout(false);
            flpLoc.ResumeLayout(false);
            flpLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDon).EndInit();
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
        private ToolStripStatusLabel lblSoDon;
        private ToolStripStatusLabel lblTongChiPhi;
        private ToolStripStatusLabel lblThongBao;
        private TableLayoutPanel tlpMain;
        private GroupBox grpThongTin;
        private TableLayoutPanel tlpNhap;
        private Label lblMaDon;
        private TextBox txtMaDon;
        private Label lblLoai;
        private ComboBox cboLoai;
        private Label lblTenKH;
        private TextBox txtTenKH;
        private Label lblNgay;
        private DateTimePicker dtpNgayTiepNhan;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private Label lblChiPhi;
        private TextBox txtChiPhi;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Panel pnlAnh;
        private PictureBox picAnh;
        private FlowLayoutPanel flpAnh;
        private Button btnChonAnh;
        private Button btnBoAnh;
        private FlowLayoutPanel flpNut;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox grpTimKiem;
        private FlowLayoutPanel flpLoc;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Label lblLocTrangThai;
        private ComboBox cboLocTrangThai;
        private Button btnBoLoc;
        private DataGridView dgvDon;
        private DataGridViewTextBoxColumn colMaDon;
        private DataGridViewTextBoxColumn colTenKH;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colLoai;
        private DataGridViewTextBoxColumn colMoTa;
        private DataGridViewTextBoxColumn colNgay;
        private DataGridViewTextBoxColumn colChiPhi;
        private DataGridViewTextBoxColumn colTrangThai;
        private BindingSource bsDon;
        private ErrorProvider errorProvider1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
