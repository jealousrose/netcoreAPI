using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models

{
    [Table ("Person")]
    public class Person
    {
        public string PersonId { get; set; } = "0";
        public string FullName { get; set; } = "";
        public string Address { get; set; } = "";
    }
}