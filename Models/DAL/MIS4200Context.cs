using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aj678815MIS4200.Models;
using System.Data.Entity;

namespace Aj678815MIS4200.Models.DAL
{
    public class MIS4200Context : DbContext
    {

        public MIS4200Context(): base ("name=DefaultConnection")
            {

        }
        public DbSet<Appointment>Appointments { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Pet> Pets { get; set; }
        public DbSet <AppointmentDetails> AppointmentDetails { get; set; }


    }
}