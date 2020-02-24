using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Aj678815MIS4200.Models
{
    public class Pet
    {
        public int petId { get; set; }
        [Display(Name = "Description of Visit")]
        [StringLength(500)]
        [Required(ErrorMessage = "A description of your pets visit is required")]
        public string description { get; set; }
        [Display(Name = "Vet Expense")]
        
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price of Visit is Required")]

        public  decimal  vetExpense { get; set; }
        [Display(Name = "Supplier")]

        public int supplierID { get; set; }

        public ICollection<AppointmentDetails> AppointmentDetails { get; set; }


    }
}