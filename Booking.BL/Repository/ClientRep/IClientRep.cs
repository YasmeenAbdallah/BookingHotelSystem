using System;
using System.Collections.Generic;
using System.Text;
using Booking.DAL.Entities;

namespace Booking.BL.Repository.ClientRep
{
    interface IClientRep
    {
        /// <summary>
        /// get lis of Clients
        /// </summary>
        /// <returns></returns>
        IEnumerable<Client> Get();
        /// <summary>
        /// Search By Name
        /// </summary>
        /// <returns></returns>
        IEnumerable<Client> SearchByName(string name);
        /// <summary>
        /// Search By phone
        /// </summary>
        /// <returns></returns>
        IEnumerable<Client> SearchByPhone(string phone);
        /// <summary>
        /// get departmant obj by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Client GetById(int id);
        /// <summary>
        /// create new Client
        /// </summary>
        /// <param name="obj"></param>
        void Create(Client obj);
        /// <summary>
        /// delete a Client
        /// </summary>
        /// <param name="id"></param>
        void Delete(Client obj);
        /// <summary>
        /// edit on existance Client
        /// </summary>
        /// <param name="obj"></param>
        void Edit(Client obj);
    }
}
