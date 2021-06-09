using System.Collections.Generic;

namespace Backtester.Domain.Entities.Orders
{
    class StopLossLimit : Order
    {
        public decimal Price { get; set; }

        public decimal StopPrice { get; set; }

        public decimal TimeInForce { get; set; }
    }
}
