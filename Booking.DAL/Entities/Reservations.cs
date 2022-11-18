using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class Reservations
    {
        /// <summary>
        /// the PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the Arrival Date
        /// </summary> 
        public DateTime ArrivalDate { get; set; }
        /// <summary>
        /// the  CheckOut Date
        /// </summary>
        public DateTime CheckOutDate { get; set; }
        /// <summary>
        /// the creational date
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// if client deleted
        /// </summary>
        public bool MarkAsDeleted { get; set; }
        /// <summary>
        /// any notes about reservation
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// the reservation status
        /// </summary>
        public int ReservationStatusId { get; set; }
        public ReservationStatus ReservationStatus { get; set; }

        /// <summary>
        /// the client id
        /// </summary>
        public int ClientId { get; set; }
        public Client Client { get; set; }

        /// <summary>
        /// the created  User id 
        /// </summary>
        public int UserId { get; set; }
        public User User { get; set; }
        /// <summary>
        /// the Hotel Id
        /// </summary>
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        /// <summary>
        /// the list of details
        /// </summary>

        public ICollection<ReseverationDetails> ResverationDetails { get; set; }
    }
}