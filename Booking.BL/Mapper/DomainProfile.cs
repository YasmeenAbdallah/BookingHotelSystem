using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Booking.BL.ViewModels;
using Booking.DAL.Entities;

namespace Booking.BL.Mapper
{
    class DomainProfile: Profile
    {
        public DomainProfile()
        {
            CreateMap<Client, ClientVM>();
            CreateMap<ClientVM, Client>();
           
        }
    }
}
