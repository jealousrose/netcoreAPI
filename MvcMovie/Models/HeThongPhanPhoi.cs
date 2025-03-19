using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("HeThongPhanPhoi")]
    public class HeThongPhanPhoi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaHTPP { get; set; }

        [Required]
        [StringLength(255)]
        public string TenHTPP { get; set; }
    }
}
