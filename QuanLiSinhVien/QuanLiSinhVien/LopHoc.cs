using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLiSinhVien
{
    public class LopHoc
    {
        [Required(ErrorMessage = "Mã lớp không được để trống.")]
        public string MaLop { get; set; } = "";

        [Required(ErrorMessage = "Tên lớp không được để trống.")]
        public string TenLop { get; set; } = "";

        // Một lớp học có nhiều sinh viên.
        public List<SinhVien> DanhSachSinhVien { get; set; }
            = new List<SinhVien>();

        public bool KiemTraHopLe(out List<ValidationResult> loi)
        {
            loi = new List<ValidationResult>();

            return Validator.TryValidateObject(
                this,
                new ValidationContext(this),
                loi,
                true);
        }
    }
}