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
        public string customerFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string customerLastName { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        public string phone { get; set; }
        [Display(Name = "Customer Since")]
        public DateTime customerSince { get; set; }

        public ICollection<Appointment> Appointment { get; set; } 


    }
    
}