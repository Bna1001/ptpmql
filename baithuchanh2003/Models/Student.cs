using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace baithuchanh2003.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string StudentCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }
    }
}