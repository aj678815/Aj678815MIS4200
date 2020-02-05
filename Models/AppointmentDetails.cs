using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aj678815MIS4200.Models
{
    public class AppointmentDetails
    {
        public int appointmentDetailsId { get; set; }
        public int qtyVisits { get; set; }
        public decimal price { get; set; }

        public int appiontmentId { get; set; }
        public virtual Appointment Appointment{ get; set; }


        public int petId { get; set; }
        public virtual Pet pet { get; set; }


    }
}