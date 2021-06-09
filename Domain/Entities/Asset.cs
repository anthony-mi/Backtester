namespace Backtester.Domain.Entities
{
    public class Asset
    {
        public int Id { get; set; }

        public Exchange Exchange { get; set; }

        public string Name { get; set; }
    }
}
