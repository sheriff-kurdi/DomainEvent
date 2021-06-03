using DomainEvent.Domain.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DomainEvent.Domain.Handlers
{
    public class OrderCreatedHandler : INotificationHandler<OrderCreatedEvent>
    {
        private readonly LogService logService;

        public OrderCreatedHandler(LogService logService)
        {
            this.logService = logService;
        }
        public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
        {
            logService.Success();
            return Task.FromResult(true);
        }
    }
}
