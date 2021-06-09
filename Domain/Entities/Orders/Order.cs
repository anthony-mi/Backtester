using Backtester.Domain.Common;
using Backtester.Domain.Enums;
using Backtester.Domain.Events;
using System.Collections.Generic;

namespace Backtester.Domain.Entities.Orders
{
    public abstract class Order : AuditableEntity, IHasDomainEvent
    {
        public int Id { get; set; }

        public Side Side { get; set; }

        private OrderStatus _status;

        public OrderStatus Status
        {
            get => _status;

            set
            {
                if (value == OrderStatus.Filled && _status != OrderStatus.Filled)
                {
                    DomainEvents.Add(new OrderFilledEvent(this));
                }

                _status = value;
            }
        }

        public decimal Quantity { get; set; }

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}
