using DomainEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvent.Infrastructure.Contracts
{
    public interface IOrderRepo
    {
        List<Order> GetAll();
        Task<Order> Add(Order order);


    }
}
