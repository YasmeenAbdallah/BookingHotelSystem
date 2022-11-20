using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BL.Repository.ClientRep;
using Booking.BL.ViewModels;
using Booking.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRep clientRep;
        private readonly IMapper mapper;

        public ClientController(IMapper mapper, IClientRep clientRep)
        {
            this.clientRep = clientRep;
            this.mapper = mapper;

        }
        // GET: api/<ClientsController>
        [HttpGet]
        public IActionResult Get()
        {
            var data =  clientRep.Get();
            var model = mapper.Map<IEnumerable<ClientVM>>(data);
            return Ok(model);
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = clientRep.GetById(id);
            var model = mapper.Map<IEnumerable<ClientVM>>(data);
            return Ok(model);
        }

        // POST api/<ClientsController>
        [HttpPost]
        public IActionResult Post([FromBody] ClientVM client)
        {
            if (ModelState.IsValid)
            {

                var data = mapper.Map<Client>(client);
                clientRep.Create(data);
                return NoContent();
            }
            return NotFound();
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ClientVM client)
        {
            if (ModelState.IsValid)
            {
                var data = mapper.Map<Client>(client);
                clientRep.Edit(data);
                return Ok();
            }
            return NotFound();
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] ClientVM client)
        {
            var data = mapper.Map<Client>(client);
            clientRep.Delete(data);
            return Ok();

        }
    }
}
