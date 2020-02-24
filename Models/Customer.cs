using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Aj678815MIS4200.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        [Display (Name="First Name")]
        [Required(ErrorMessage = "Customer first name is required")]
        [StringLength(20)]
        public string customerFirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Customer last name is required")]
        [StringLength(20)]
        public string customerLastName { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [StringLength(20)]

        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\)|\d{3}-)\d{3}-\d{4}$",
           ErrorMessage = "Phone number must be in the format (xxx)-xxx-xxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Customer Since")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = " {0:d}", ApplyFormatInEditMode = true)]
        public DateTime customerSince { get; set; }
        

        public ICollection<Appointment> Appointment { get; set; } 


    }
    
}