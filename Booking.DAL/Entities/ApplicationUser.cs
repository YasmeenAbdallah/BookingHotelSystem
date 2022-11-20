using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Booking.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
       
        /// <summary>
        /// if user deleted
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// the creational date
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// the reservations list created by this user
        /// </summary>
        public ICollection<Reservations> Reservations { get; set; }

    }
}
