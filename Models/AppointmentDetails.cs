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
        [Required(ErrorMessage ="Number of visits Required")]
        //[Length(2, MinimumLength =2, ErrorMessage = "Number of visits Required")]
        public int qtyVisits { get; set; }
        [Display(Name = "Price ")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price of Visit is Required")]


        public decimal price { get; set; }
        [Display(Name = "Appointment Identification Number")]
       // [StringLength(50)]

        public int appiontmentId { get; set; }
        public virtual Appointment Appointment{ get; set; }

        [Display(Name = "Visit Description")]
        [Required(ErrorMessage = "Visit Description is Required")]
        //[StringLength(500)]

        public int petId { get; set; }
        [Display(Name = "Visit Description")]
        public virtual Pet pet { get; set; }


    }
}