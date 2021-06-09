namespace Backtester.Domain.Entities
{
    public class Strategy
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public User Owner { get; set; }
    }
}
