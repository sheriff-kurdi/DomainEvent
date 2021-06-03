using DomainEvent.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEvent.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustId { get; set; }

        public void Completed()
        {
            Events.Add(new OrderCreatedEvent(this));
        }

    }
}
