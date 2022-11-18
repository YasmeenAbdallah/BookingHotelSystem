using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Entities
{
    public class Roles
    {
        /// <summary>
        /// the PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the role name 
        /// </summary>
        public string Name { get; set; }
        public ICollection<User> User { get; set; }
    }
}
