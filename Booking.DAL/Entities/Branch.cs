using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class Branch
    {
        /// <summary>
        /// the PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the displayed name for each branch
        /// </summary>
        public string Name { get; set; }
       
        /// <summary>
        /// the creational date
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// number of rooms for each branches
        /// </summary>
        public ICollection<BranchRooms> BranchRooms { get; set; }
        /// <summary>
        /// list of reservations
        /// </summary>
        public ICollection<Reservations> Reservations { get; set; }


    }
}
