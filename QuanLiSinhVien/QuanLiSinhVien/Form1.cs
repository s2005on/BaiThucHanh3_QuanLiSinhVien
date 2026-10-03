using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
namespace QuanLiSinhVien
{
    public partial class Form1 : Form
    {
        private List<LopHoc> danhSachLop = new List<LopHoc>();
        private List<SinhVien> danhSachSV = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }
        private void XoaThongTinNhap()
        {
            // Giữ nguyên ô mã sinh viên.
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();

            radNam.Checked = false;
            radNu.Checked = false;

            dtpNgaySinh.Value = DateTime.Today;
            dtpNgaySinh.Checked = false;

            cboLop.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            nudDiem.Value = 0;
        }

        private void LamMoiForm()
        {
            txtMaSV.Clear();
            maDaKiemTra = "";

            XoaThongTinNhap();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvSinhVien.ClearSelection();
            txtMaSV.Focus();
        }

        private void DienThongTin(SinhVien sv)
        {
            txtMaSV.Text = sv.MaSV;
            maDaKiemTra = sv.MaSV;

            txtHoTen.Text = sv.HoTen;
            txtEmail.Text = sv.Email;
            txtDienThoai.Text = sv.DienThoai;

            dtpNgaySinh.Value = sv.NgaySinh;
            dtpNgaySinh.Checked = true;

            radNam.Checked = sv.GioiTinh == "Nam";
            radNu.Checked = sv.GioiTinh == "Nữ";

            cboLop.SelectedValue = sv.MaLop;
            nudDiem.Value = sv.Diem;
            cboTrangThai.SelectedItem = sv.TrangThai;

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            danhSachLop = new List<LopHoc>
    {
        new LopHoc
        {
            MaLop = "KTPM01",
            TenLop = "Kỹ thuật phần mềm 01"
        },
        new LopHoc
        {
            MaLop = "TTNT01",
            TenLop = "Trí tuệ nhân tạo 01"
        },
        new LopHoc
        {
            MaLop = "KHDL01",
            TenLop = "Khoa học dữ liệu 01"
        }
    };

            // 2. Hiển thị lớp học trong ô nhập.
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = danhSachLop;
            cboLop.SelectedIndex = -1;

            // 3. Hiển thị lớp học trong khu vực tìm kiếm.
            var lopTimKiem = new List<LopHoc>
    {
        new LopHoc { MaLop = "", TenLop = "Tất cả lớp" }
    };
            lopTimKiem.AddRange(danhSachLop);

            cboLocLop.DisplayMember = "TenLop";
            cboLocLop.ValueMember = "MaLop";
            cboLocLop.DataSource = lopTimKiem;

            // 4. Thiết lập các lựa chọn trạng thái.
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[]
            {
        "Đang học",
        "Bảo lưu",
        "Đã tốt nghiệp",
        "Thôi học"
            });
            cboTrangThai.SelectedIndex = -1;

            // 5. Tạo dữ liệu sinh viên mẫu.
            danhSachSV = new List<SinhVien>
    {
        new SinhVien
        {
            MaSV = "SV000123",
            HoTen = "Nguyễn Văn An",
            NgaySinh = new DateTime(2006, 8, 15),
            GioiTinh = "Nam",
            Email = "an.nv@vju.ac.vn",
            DienThoai = "0912345678",
            Diem = 8.5m,
            MaLop = "KTPM01",
            TrangThai = "Đang học"
        },
        new SinhVien
        {
            MaSV = "SV000124",
            HoTen = "Trần Minh Anh",
            NgaySinh = new DateTime(2006, 1, 22),
            GioiTinh = "Nữ",
            Email = "anh.tm@vju.ac.vn",
            DienThoai = "0987654321",
            Diem = 9.0m,
            MaLop = "TTNT01",
            TrangThai = "Đang học"
        }
    };

            // 6. Cập nhật quan hệ lớp học – sinh viên và bảng.
            HienThiDanhSach();

            // 7. Trạng thái ban đầu của các nút.
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // 8. Đặt con trỏ vào ô mã sau khi form mở.
            BeginInvoke(new Action(() =>
            {
                dgvSinhVien.ClearSelection();
                txtMaSV.Focus();
            }));
            // Cho phép bỏ chọn ngày sinh khi làm mới.
            dtpNgaySinh.ShowCheckBox = true;
            dtpNgaySinh.MaxDate = DateTime.Today;

            LamMoiForm();
        }

        private void txtMaSV_Leave(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();

            // Mã không đổi: giữ lại thông tin người dùng đang nhập.
            if (string.Equals(ma, maDaKiemTra,
                StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var sv = danhSachSV.FirstOrDefault(x =>
                string.Equals(x.MaSV, ma,
                    StringComparison.OrdinalIgnoreCase));

            if (sv != null)
            {
                // Mã đã tồn tại.
                DienThongTin(sv);
            }
            else
            {
                // Mã mới: giữ mã, xóa các trường còn lại.
                XoaThongTinNhap();
                maDaKiemTra = ma;

                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private void HienThiDanhSach()
        {
            // Cập nhật quan hệ 1 lớp – nhiều sinh viên.
            foreach (LopHoc lop in danhSachLop)
            {
                lop.DanhSachSinhVien = danhSachSV
                    .Where(sv => sv.MaLop == lop.MaLop)
                    .ToList();
            }

            string tuKhoa = txtTuKhoa.Text.Trim();

            string maLop = Convert.ToString(
                cboLocLop.SelectedValue) ?? "";

            decimal diemTu = nudDiemTu.Value;

            var ketQua = danhSachSV.Where(sv =>
                (
                    sv.MaSV.IndexOf(tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                    ||
                    sv.HoTen.IndexOf(tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                    ||
                    sv.Email.IndexOf(tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                    ||
                    sv.DienThoai.IndexOf(tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                )
                &&
                (maLop == "" || sv.MaLop == maLop)
                &&
                sv.Diem >= diemTu
            ).ToList();

            dgvSinhVien.Rows.Clear();

            foreach (SinhVien sv in ketQua)
            {
                var lop = danhSachLop.FirstOrDefault(
                    x => x.MaLop == sv.MaLop);

                dgvSinhVien.Rows.Add(
                    sv.MaSV,
                    sv.HoTen,
                    sv.NgaySinh.ToString("dd/MM/yyyy"),
                    sv.GioiTinh,
                    sv.Email,
                    sv.DienThoai,
                    sv.Diem,
                    lop == null ? "" : lop.TenLop,
                    sv.TrangThai
                );
            }

            dgvSinhVien.ClearSelection();
        }
        // Ghi nhớ mã đã kiểm tra để không xóa thông tin đang nhập
        // khi người dùng quay lại ô mã rồi nhấn Tab lần nữa.
        private string maDaKiemTra = "";
        private SinhVien DocThongTinNhap()
        {
            return new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),

                NgaySinh = dtpNgaySinh.Checked
                    ? dtpNgaySinh.Value.Date
                    : DateTime.MinValue,

                GioiTinh = radNam.Checked
                    ? "Nam"
                    : (radNu.Checked ? "Nữ" : ""),

                Email = txtEmail.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Diem = nudDiem.Value,

                MaLop = Convert.ToString(cboLop.SelectedValue) ?? "",
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? ""
            };
        }

        private bool DuLieuHopLe(SinhVien sv)
        {
            List<ValidationResult> loi;

            if (!sv.KiemTraHopLe(out loi))
            {
                string thongBao = string.Join(
                    Environment.NewLine,
                    loi.Select(x => x.ErrorMessage));

                MessageBox.Show(
                    thongBao,
                    "Thông tin chưa hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            // Kiểm tra mã lớp thực sự có trong danh sách.
            if (!danhSachLop.Any(x => x.MaLop == sv.MaLop))
            {
                MessageBox.Show("Lớp học không tồn tại.");
                return false;
            }

            return true;
        }
        private void BoLocTimKiem()
        {
            txtTuKhoa.Clear();
            cboLocLop.SelectedIndex = 0;
            nudDiemTu.Value = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            LamMoiForm();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            BoLocTimKiem();
            HienThiDanhSach();
            LamMoiForm();
        }
        private void dgvSinhVien_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            // Bỏ qua khi nhấn vào tiêu đề cột.
            if (e.RowIndex < 0)
                return;

            string ma = Convert.ToString(
                dgvSinhVien.Rows[e.RowIndex].Cells[0].Value) ?? "";

            var sv = danhSachSV.FirstOrDefault(x => x.MaSV == ma);

            if (sv != null)
            {
                DienThongTin(sv);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = DocThongTinNhap();

            bool trungMa = danhSachSV.Any(x =>
                string.Equals(x.MaSV, sv.MaSV,
                    StringComparison.OrdinalIgnoreCase));

            if (trungMa)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.");
                return;
            }

            if (!DuLieuHopLe(sv))
                return;

            danhSachSV.Add(sv);

            BoLocTimKiem();
            HienThiDanhSach();
            LamMoiForm();

            MessageBox.Show("Thêm sinh viên thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();

            int viTri = danhSachSV.FindIndex(x =>
                string.Equals(x.MaSV, ma,
                    StringComparison.OrdinalIgnoreCase));

            if (viTri < 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần sửa.");
                return;
            }

            SinhVien svMoi = DocThongTinNhap();

            // Giữ mã gốc của sinh viên.
            svMoi.MaSV = danhSachSV[viTri].MaSV;

            if (!DuLieuHopLe(svMoi))
                return;

            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn lưu thay đổi cho sinh viên "
                    + svMoi.MaSV + " không?",
                "Xác nhận sửa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            danhSachSV[viTri] = svMoi;

            BoLocTimKiem();
            HienThiDanhSach();
            LamMoiForm();

            MessageBox.Show("Sửa sinh viên thành công.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();

            var sv = danhSachSV.FirstOrDefault(x =>
                string.Equals(x.MaSV, ma,
                    StringComparison.OrdinalIgnoreCase));

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần xóa.");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên "
                    + sv.HoTen + " (" + sv.MaSV + ") không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (ketQua != DialogResult.Yes)
                return;

            danhSachSV.Remove(sv);

            HienThiDanhSach();
            LamMoiForm();

            MessageBox.Show("Xóa sinh viên thành công.");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
