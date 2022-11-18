using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.BL.ViewModels
{
    public class ClientVM
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
    }
}
