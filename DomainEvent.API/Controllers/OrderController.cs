using DomainEvent.Domain.Entities;
using DomainEvent.Infrastructure.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DomainEvent.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepo orderRepo;

        public OrdersController(IOrderRepo orderRepo)
        {
            this.orderRepo = orderRepo;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return orderRepo.GetAll();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return orderRepo.GetAll().FirstOrDefault();
        }

        // POST api/<OrderController>
        [HttpPost]
        public Order Post([FromBody] Order order)
        {
            orderRepo.Add(order);
            return order;
            //order.Completed();
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
