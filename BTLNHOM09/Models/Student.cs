using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace BTLNHOM09.Models
{
    public class Student 
    {
        [Key]
        public string StudentID{get;set;}
        public string FullName{get;set;}
    }
}