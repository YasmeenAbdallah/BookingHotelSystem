using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class User
    {
            /// <summary>
            /// the PK
            /// </summary>
            public int Id { get; set; }
            /// <summary>
            /// the user name 
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// the user email
            /// </summary>
            public string Email { get; set; }
            /// <summary>
            /// the creational date
            /// </summary>
            public DateTime CreationDate { get; set; }
            /// <summary>
            /// the user password
            /// </summary>
            public string Password { get; set; }
            /// <summary>
            /// if user deleted
            /// </summary>
            public bool IsActive { get; set; }
            /// <summary>
            /// the role which assign to this user
            /// </summary>
            public int RolesId { get; set; }
            public Roles Roles { get; set; }
            /// <summary>
            /// the reservations list created by this user
            /// </summary>
            public ICollection<Reservations> Reservations { get; set; }



    }
}

