using DomainEvent.Domain.Entities;
using DomainEvent.Infrastructure.Contracts;
using DomainEvent.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvent.Infrastructure.DataAccess
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext db;

        public OrderRepo(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<Order> Add(Order order)
        {
            db.Orders.Add(order);
            order.Completed();
            db.SaveChanges();
            return order;
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }


    }
}
