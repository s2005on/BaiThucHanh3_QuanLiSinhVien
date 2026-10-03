namespace QuanLiSinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTieuDe = new Label();
            grpThongTin = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            nudDiem = new NumericUpDown();
            cboTrangThai = new ComboBox();
            cboLop = new ComboBox();
            lblTrangThai = new Label();
            lblDiem = new Label();
            lblLop = new Label();
            pnlGioiTinh = new Panel();
            radNu = new RadioButton();
            radNam = new RadioButton();
            txtDienThoai = new TextBox();
            txtHoTen = new TextBox();
            lblDienThoai = new Label();
            lblGioiTinh = new Label();
            lblHoTen = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtEmail = new TextBox();
            txtMaSV = new TextBox();
            lblEmail = new Label();
            lblNgaySinh = new Label();
            lblMaSV = new Label();
            pnlTimKiem = new Panel();
            btnHienThiTatCa = new Button();
            btnTimKiem = new Button();
            nudDiemTu = new NumericUpDown();
            cboLocLop = new ComboBox();
            txtTuKhoa = new TextBox();
            lblDiemTu = new Label();
            lblLocLop = new Label();
            lblTuKhoa = new Label();
            grpDanhSach = new GroupBox();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiem = new DataGridViewTextBoxColumn();
            colLop = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            lblHuongDan = new Label();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            pnlGioiTinh.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiemTu).BeginInit();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(42, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(354, 40);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(nudDiem);
            grpThongTin.Controls.Add(cboTrangThai);
            grpThongTin.Controls.Add(cboLop);
            grpThongTin.Controls.Add(lblTrangThai);
            grpThongTin.Controls.Add(lblDiem);
            grpThongTin.Controls.Add(lblLop);
            grpThongTin.Controls.Add(pnlGioiTinh);
            grpThongTin.Controls.Add(txtDienThoai);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblDienThoai);
            grpThongTin.Controls.Add(lblGioiTinh);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(txtEmail);
            grpThongTin.Controls.Add(txtMaSV);
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(lblMaSV);
            grpThongTin.Location = new Point(20, 65);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1160, 236);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin sinh viên";
            grpThongTin.Enter += grpThongTin_Enter;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Gray;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1010, 180);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(115, 35);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Leave += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.Enabled = false;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(890, 180);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 35);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Leave += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SteelBlue;
            btnSua.Enabled = false;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(770, 180);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 35);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Leave += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(650, 180);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 35);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Leave += btnThem_Click;
            // 
            // nudDiem
            // 
            nudDiem.DecimalPlaces = 1;
            nudDiem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDiem.Location = new Point(850, 81);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(150, 30);
            nudDiem.TabIndex = 7;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp", "Thôi học" });
            cboTrangThai.Location = new Point(850, 126);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(275, 31);
            cboTrangThai.TabIndex = 8;
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "Kỹ thuật phần mềm 01", "Trí tuệ nhân tạo 01", "Khoa học dữ liệu 01" });
            cboLop.Location = new Point(850, 36);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(275, 31);
            cboLop.TabIndex = 6;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(750, 130);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(87, 23);
            lblTrangThai.TabIndex = 14;
            lblTrangThai.Text = "Trạng thái";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(750, 85);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(62, 23);
            lblDiem.TabIndex = 13;
            lblDiem.Text = "Điểm *";
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(750, 40);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(83, 23);
            lblLop.TabIndex = 12;
            lblLop.Text = "Lớp học *";
            // 
            // pnlGioiTinh
            // 
            pnlGioiTinh.Controls.Add(radNu);
            pnlGioiTinh.Controls.Add(radNam);
            pnlGioiTinh.Location = new Point(490, 78);
            pnlGioiTinh.Name = "pnlGioiTinh";
            pnlGioiTinh.Size = new Size(220, 32);
            pnlGioiTinh.TabIndex = 4;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(95, 4);
            radNu.Name = "radNu";
            radNu.Size = new Size(54, 27);
            radNu.TabIndex = 1;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Location = new Point(3, 4);
            radNam.Name = "radNam";
            radNam.Size = new Size(68, 27);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            radNam.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(490, 126);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(220, 30);
            txtDienThoai.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(490, 36);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(220, 30);
            txtHoTen.TabIndex = 3;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(390, 130);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(101, 23);
            lblDienThoai.TabIndex = 8;
            lblDienThoai.Text = "Điện thoại *";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(390, 85);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(75, 23);
            lblGioiTinh.TabIndex = 7;
            lblGioiTinh.Text = "Giới tính";
            lblGioiTinh.Click += label2_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(390, 40);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(96, 23);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ và tên *";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(125, 81);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(220, 30);
            dtpNgaySinh.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 30);
            txtEmail.TabIndex = 2;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(125, 36);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(220, 30);
            txtMaSV.TabIndex = 0;
            txtMaSV.TextChanged += txtMaSV_TextChanged;
            txtMaSV.Leave += txtMaSV_Leave;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email *";
            lblEmail.Click += label3_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(15, 85);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(86, 23);
            lblNgaySinh.TabIndex = 1;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(15, 40);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(118, 23);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sinh viên *";
            lblMaSV.Click += label1_Click;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTimKiem.BackColor = Color.White;
            pnlTimKiem.Controls.Add(btnHienThiTatCa);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(nudDiemTu);
            pnlTimKiem.Controls.Add(cboLocLop);
            pnlTimKiem.Controls.Add(txtTuKhoa);
            pnlTimKiem.Controls.Add(lblDiemTu);
            pnlTimKiem.Controls.Add(lblLocLop);
            pnlTimKiem.Controls.Add(lblTuKhoa);
            pnlTimKiem.Location = new Point(20, 305);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1160, 60);
            pnlTimKiem.TabIndex = 1;
            // 
            // btnHienThiTatCa
            // 
            btnHienThiTatCa.Location = new Point(950, 12);
            btnHienThiTatCa.Name = "btnHienThiTatCa";
            btnHienThiTatCa.Size = new Size(190, 35);
            btnHienThiTatCa.TabIndex = 7;
            btnHienThiTatCa.Text = "Hiển thị tất cả";
            btnHienThiTatCa.UseVisualStyleBackColor = true;
            btnHienThiTatCa.Leave += btnHienThiTatCa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SteelBlue;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(800, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(135, 35);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Leave += btnTimKiem_Click;
            // 
            // nudDiemTu
            // 
            nudDiemTu.DecimalPlaces = 1;
            nudDiemTu.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDiemTu.Location = new Point(705, 17);
            nudDiemTu.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiemTu.Name = "nudDiemTu";
            nudDiemTu.Size = new Size(75, 30);
            nudDiemTu.TabIndex = 5;
            // 
            // cboLocLop
            // 
            cboLocLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLop.FormattingEnabled = true;
            cboLocLop.Items.AddRange(new object[] { "Tất cả lớp", "Kỹ thuật phần mềm 01", "Trí tuệ nhân tạo 01", "Khoa học dữ liệu 01" });
            cboLocLop.Location = new Point(395, 17);
            cboLocLop.Name = "cboLocLop";
            cboLocLop.Size = new Size(220, 31);
            cboLocLop.TabIndex = 4;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(80, 17);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(250, 30);
            txtTuKhoa.TabIndex = 3;
            // 
            // lblDiemTu
            // 
            lblDiemTu.AutoSize = true;
            lblDiemTu.Location = new Point(635, 21);
            lblDiemTu.Name = "lblDiemTu";
            lblDiemTu.Size = new Size(71, 23);
            lblDiemTu.TabIndex = 2;
            lblDiemTu.Text = "Điểm từ";
            // 
            // lblLocLop
            // 
            lblLocLop.AutoSize = true;
            lblLocLop.Location = new Point(350, 21);
            lblLocLop.Name = "lblLocLop";
            lblLocLop.Size = new Size(38, 23);
            lblLocLop.TabIndex = 1;
            lblLocLop.Text = "Lớp";
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Location = new Point(12, 21);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(71, 23);
            lblTuKhoa.TabIndex = 0;
            lblTuKhoa.Text = "Từ khóa";
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.BackColor = Color.White;
            grpDanhSach.Controls.Add(dgvSinhVien);
            grpDanhSach.Location = new Point(20, 375);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1160, 280);
            grpDanhSach.TabIndex = 2;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách sinh viên";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colNgaySinh, colGioiTinh, colEmail, colDienThoai, colDiem, colLop, colTrangThai });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.Location = new Point(10, 30);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1140, 235);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // colMaSV
            // 
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "CEmail";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colDienThoai
            // 
            colDienThoai.HeaderText = "Điện thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            colDienThoai.ReadOnly = true;
            // 
            // colDiem
            // 
            colDiem.HeaderText = "Điểm";
            colDiem.MinimumWidth = 6;
            colDiem.Name = "colDiem";
            colDiem.ReadOnly = true;
            // 
            // colLop
            // 
            colLop.HeaderText = "Lớp";
            colLop.MinimumWidth = 6;
            colLop.Name = "colLop";
            colLop.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // lblHuongDan
            // 
            lblHuongDan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHuongDan.AutoSize = true;
            lblHuongDan.ForeColor = Color.DimGray;
            lblHuongDan.Location = new Point(20, 670);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(454, 23);
            lblHuongDan.TabIndex = 1;
            lblHuongDan.Text = "Chọn một dòng để xem, sửa hoặc xóa thông tin sinh viên.";
            lblHuongDan.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1198, 692);
            Controls.Add(lblHuongDan);
            Controls.Add(grpDanhSach);
            Controls.Add(pnlTimKiem);
            Controls.Add(grpThongTin);
            Controls.Add(lblTieuDe);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.MidnightBlue;
            Location = new Point(390, 130);
            MinimumSize = new Size(1216, 739);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng quản lý sinh viên";
            Load += Form1_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            pnlGioiTinh.ResumeLayout(false);
            pnlGioiTinh.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiemTu).EndInit();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private GroupBox grpThongTin;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtEmail;
        private TextBox txtMaSV;
        private Label lblEmail;
        private Label lblNgaySinh;
        private Label lblMaSV;
        private Panel pnlGioiTinh;
        private TextBox txtDienThoai;
        private TextBox txtHoTen;
        private Label lblDienThoai;
        private Label lblGioiTinh;
        private Label lblHoTen;
        private RadioButton radNam;
        private RadioButton radNu;
        private NumericUpDown nudDiem;
        private ComboBox cboTrangThai;
        private ComboBox cboLop;
        private Label lblTrangThai;
        private Label lblDiem;
        private Label lblLop;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel pnlTimKiem;
        private Button btnHienThiTatCa;
        private Button btnTimKiem;
        private NumericUpDown nudDiemTu;
        private ComboBox cboLocLop;
        private TextBox txtTuKhoa;
        private Label lblDiemTu;
        private Label lblLocLop;
        private Label lblTuKhoa;
        private GroupBox grpDanhSach;
        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiem;
        private DataGridViewTextBoxColumn colLop;
        private DataGridViewTextBoxColumn colTrangThai;
        private Label lblHuongDan;
    }
}
