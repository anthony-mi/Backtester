namespace Backtester.Domain.Entities.Orders
{
    public class Limit : Order
    {
        public decimal TimeInForce { get; set; }

        public decimal Price { get; set; }
    }
}
