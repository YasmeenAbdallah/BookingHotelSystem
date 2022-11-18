using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Booking.DAL.Database;
using Booking.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booking.BL.Repository.ClientRep
{
    class ClientRep : IClientRep
    {
        private readonly BookingDbContext db;

        public ClientRep(BookingDbContext db)
        {
            this.db = db;
        }
        public void Create(Client obj)
        {

            db.Client.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Client obj)
        {

            db.Remove(obj);
            db.SaveChanges();
        }

        public void Edit(Client obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Client> Get()
        {
            var data = db.Client.Select(a => a);
            return data;
        }

        public Client GetById(int id)
        {
            Client data = GetDepById(id);
            return data;
        }

        public IEnumerable<Client> SearchByName(string name)
        {
            var data = db.Client.Where(a => a.Name.Contains(name));
            return data;
        }
        public IEnumerable<Client> SearchByPhone(string phone)
        {
            var data = db.Client.Where(a => a.Phone == phone);
            return data;
        }


        //==================Refactory================================
        private Client GetDepById(int id)
        {
            return db.Client.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}

