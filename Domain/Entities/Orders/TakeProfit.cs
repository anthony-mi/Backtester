namespace Backtester.Domain.Entities.Orders
{
    class TakeProfit : Order
    {
        public decimal StopPrice { get; set; }
    }
}
