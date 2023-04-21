using System.ComponentModel.DataAnnotations;
namespace baithuchanh2003.Models
{
    public class Person
    {
        [Key]
        public string PersonCode{get;set;}
        public string PersonName{get;set;}
        public string PersonSex{get;set;}
        public string PhoneNumber{get;set;}
        public string Address{get;set;}
    }
}