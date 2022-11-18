using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class Client
    {
        /// <summary>
        /// the PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the client name 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// the client email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// the client email
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// the creational date
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// if client deleted
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// list of reservations
        /// </summary>
        public ICollection<Reservations> Reservations { get; set; }
    }
}
