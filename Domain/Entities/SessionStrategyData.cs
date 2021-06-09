using Backtester.Domain.Common;
using Backtester.Domain.Entities.Orders;
using System.Collections.Generic;

namespace Backtester.Domain.Entities
{
    public class SessionStrategyData : ValueObject
    {
        public Strategy Strategy { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public Balance Balance { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Strategy.Id;
        }
    }
}
