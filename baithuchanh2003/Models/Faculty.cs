using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baithuchanh2003.Models
{
    [Table("Facultys")]
    public class Faculty
    {
        [Key]
        public string FacultyID { get; set; }
        public string FacultyName { get; set; }
    }
}