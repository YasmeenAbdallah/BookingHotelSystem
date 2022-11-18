using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class ReservationStatus
    {
        /// <summary>
        /// the PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the status name 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// the list of reservations belong to this status
        /// </summary>
        public ICollection<Reservations> Reservations { get; set; }
    }
}
