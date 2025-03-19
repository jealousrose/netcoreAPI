using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Employee")]
    public class Employee : Person
    {
        public string? Email { get; set; }
    }
}
