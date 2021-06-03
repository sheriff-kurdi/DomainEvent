using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEvent.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [NotMapped]
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
