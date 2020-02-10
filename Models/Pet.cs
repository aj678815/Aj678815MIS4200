using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aj678815MIS4200.Models
{
    public class Pet
    {
        public int petId { get; set; }
        public string description { get; set; }
        public  decimal  vetExpense { get; set; }
        public int supplierID { get; set; }

        public ICollection<AppointmentDetails> AppointmentDetails { get; set; }


    }
}