using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class ReseverationDetails
    {
        /// <summary>
        /// the PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// number of adults for this reservations room type
        /// </summary>
        public int NumOfAdults { get; set; }
        /// <summary>
        /// number of Childern for this reservations room type
        /// </summary>
        public int NumOfChildern { get; set; }
        /// <summary>
        /// the room type 
        /// </summary>
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        /// <summary>
        /// the reservationId 
        /// </summary>
        public int ReservationsId { get; set; }
        public Reservations Reservations { get; set; }





    }
}
