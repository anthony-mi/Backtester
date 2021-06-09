using Backtester.Domain.Common;
using Backtester.Domain.Entities.Orders;

namespace Backtester.Domain.Events
{
    public class OrderFilledEvent : DomainEvent
    {
        public Order Order { get; }

        public OrderFilledEvent(Order order)
        {
            Order = order;
        }
    }
}
