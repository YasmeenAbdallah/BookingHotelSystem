using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class BranchRooms
    {
        /// <summary>
        /// the PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the room type 
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// the room type 
        /// </summary>
        public int RoomTypeId { get; set; }
       
        public RoomType RoomType { get; set; }
        /// <summary>
        /// the hotel Id 
        /// </summary>
        public int BranchID { get; set; }
      
        public Branch Branch { get; set; }
    }
}
