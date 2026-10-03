using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLiSinhVien
{
    public class SinhVien : IValidatableObject
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống.")]
        public string MaSV { get; set; } = "";

        [Required(ErrorMessage = "Họ tên không được để trống.")]
        public string HoTen { get; set; } = "";

        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn giới tính.")]
        public string GioiTinh { get; set; } = "";

        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Điện thoại không được để trống.")]
        [RegularExpression(@"^\+?[0-9]{9,15}$",
            ErrorMessage = "Điện thoại cần 9–15 chữ số, có thể bắt đầu bằng +.")]
        public string DienThoai { get; set; } = "";

        [Range(typeof(decimal), "0", "10",
            ErrorMessage = "Điểm phải từ 0 đến 10.")]
        public decimal Diem { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn lớp học.")]
        public string MaLop { get; set; } = "";

        [Required(ErrorMessage = "Vui lòng chọn trạng thái.")]
        public string TrangThai { get; set; } = "";

        public bool KiemTraHopLe(out List<ValidationResult> loi)
        {
            loi = new List<ValidationResult>();

            return Validator.TryValidateObject(
                this,
                new ValidationContext(this),
                loi,
                true);
        }

        public IEnumerable<ValidationResult> Validate(
            ValidationContext validationContext)
        {
            if (NgaySinh == DateTime.MinValue ||
                NgaySinh.Date > DateTime.Today)
            {
                yield return new ValidationResult(
                    "Ngày sinh phải được nhập và không ở tương lai.",
                    new[] { nameof(NgaySinh) });
            }
        }
    }
}