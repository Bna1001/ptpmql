using System.ComponentModel.DataAnnotations;
namespace BTLNHOM09.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }
}