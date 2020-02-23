using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Aj678815MIS4200.Models
{
    public class AppointmentDetails
    {
        public int appointmentDetailsId { get; set; }
        [Display(Name = "Number of Visits")]
        public int qtyVisits { get; set; }
        [Display(Name = "Price ")]

        public decimal price { get; set; }
        [Display(Name = "Appointment")]

        public int appiontmentId { get; set; }
        public virtual Appointment Appointment{ get; set; }

        [Display(Name = "Visit Description")] 
        public int petId { get; set; }
        public virtual Pet pet { get; set; }


    }
}