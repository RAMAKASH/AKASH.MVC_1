using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace AKASH.MVC_1.Models
{
    public class Employee
    {
        
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage ="Employee Name can't Empty!")]
        [MinLength(3,ErrorMessage ="Name must be min 3 char!")]
        [MaxLength(30,ErrorMessage ="Name must be max 30 char!")]
        public string Name { get; set; }

        [Display(Name = "Employee Email Address")]
        [Required(ErrorMessage ="Employee Email can't Empty!")]
        [EmailAddress(ErrorMessage="Email address is not valid!")]
        public string Email { get; set; }

        [Display(Name = "Employee Mobile")]
        [Required(ErrorMessage ="Employee Mobile can't Empty!")]
        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$",
            ErrorMessage="Invalid mobile number !")]
        public string Mobile { get; set; }
        [Display(Name = "Employee Address")]
        [Required]
        [MaxLength(100,ErrorMessage="max 200 Char !")]
        public string Address { get; set; }
       
    }
}
