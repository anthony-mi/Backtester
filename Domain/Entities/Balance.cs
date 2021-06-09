using Backtester.Domain.Common;
using System.Collections.Generic;

namespace Backtester.Domain.Entities
{
    public class Balance : ValueObject
    {
        public Asset Asset { get; set; }

        public decimal Free { get; set; }

        public decimal Locked { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Asset;
            yield return Free;
            yield return Locked;
        }
    }
}
