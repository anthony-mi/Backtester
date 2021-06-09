namespace Backtester.Domain.Entities.Orders
{
    class TakeProfitLimit : Order
    {
        public decimal Price { get; set; }

        public decimal StopPrice { get; set; }

        public decimal TimeInForce { get; set; }
    }
}
