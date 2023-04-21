using System.ComponentModel.DataAnnotations;
namespace baithuchanh2003.Models
{
    public class Customer
    {
        [Key]
        public string CustomerCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}