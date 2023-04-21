using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baithuchanh1303.Models
{
    [Table ("Student")]
    public class Student
    {
        [Key]
        public string StudentCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
