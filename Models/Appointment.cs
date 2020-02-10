using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Aj678815MIS4200.Models
{
    public class Appointment
    {
       [Key]
        public int AppointmentId { get; set; }
        public string description { get; set; }
        public DateTime AppiontmentDate { get; set; }
        public int supplierID { get; set; }

        //ask why datetime wont work for appointment date instead of using string//nvm

        
        public ICollection<AppointmentDetails> AppointmentDetail { get; set; }

        public int customerId { get; set; }
        public virtual Customer customer { get; set; }

    }
}