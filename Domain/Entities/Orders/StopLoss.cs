namespace Backtester.Domain.Entities.Orders
{
    class StopLoss : Order
    {
        public decimal StopPrice { get; set; }
    }
}
