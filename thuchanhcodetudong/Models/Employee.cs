using System.ComponentModel.DataAnnotations;
namespace thuchanhcodetudong.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}