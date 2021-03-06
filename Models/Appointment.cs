﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Aj678815MIS4200.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Appointment Description Required")]
        [StringLength(50)]


        public string description { get; set; }
        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString =" {0:d}", ApplyFormatInEditMode = true)]
       // public Nullable<System.DateTime> AppointmentDate { get; set; }

        public DateTime AppiontmentDate { get; set; }
        [Display(Name = "Supplier")]
       [Required(ErrorMessage = "Suplier Required")]
       
        
        public int supplierID { get; set; }

        //ask why datetime wont work for appointment date instead of using string//nvm

        
        public ICollection<AppointmentDetails> AppointmentDetail { get; set; }

        public int customerId { get; set; }
        public virtual Customer customer { get; set; }

    }
}