using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class RoomType
    {
        /// <summary>
        /// the PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the room type name 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// the price of person per type
        /// </summary>
        public decimal PricePerAdult { get; set; }
        /// <summary>
        /// the price of Child per type
        /// </summary>
        public decimal PricePerChild { get; set; }
        /// <summary>
        /// the list of hotel rooms
        /// </summary>
        public ICollection<BranchRooms> BranchRooms { get; set; }
        /// <summary>
        /// the list of Reseveration Details
        /// </summary>
        public ICollection<ReseverationDetails> ReseverationDetails { get; set; }
    }
}
