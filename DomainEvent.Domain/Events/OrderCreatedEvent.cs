using DomainEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEvent.Domain.Events
{
    public class OrderCreatedEvent : BaseDomainEvent
    {
        public Order order { get; set; }
        public OrderCreatedEvent(Order order)
        {
            this.order = order;
        }
    }
}
