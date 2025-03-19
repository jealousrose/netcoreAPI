using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Daily")]
    public class Daily
    {
        [Key]
        public int MaDaily { get; set; } // Đổi sang kiểu int nếu cần

        public string? TenDaily { get; set; }
        public string? DiaChi { get; set; }
        public string? NguoiDaiDien { get; set; }
        public string? DienThoai { get; set; }

        // Khóa ngoại tham chiếu đến HeThongPhanPhoi
        [ForeignKey("HeThongPhanPhoi")]
        public int HeThongPhanPhoiId { get; set; }

        // Thuộc tính điều hướng (Navigation Property)
        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
    }
}