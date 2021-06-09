using Backtester.Domain.Common;
using System.Collections.Generic;

namespace Backtester.Domain.Entities
{
    public class Exchange
    {
        public int Id { get; set; }

        public IEnumerable<Asset> Assets { get; set; }

        public string Name { get; set; }

        public ExchangeComissions DefaultComissions { get; set; }


        public class ExchangeComissions : ValueObject
        {
            public decimal Maker { get; set; }

            public decimal Taker { get; set; }

            public decimal Buyer { get; set; }

            public decimal Seller { get; set; }

            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return Maker;
                yield return Taker;
                yield return Buyer;
                yield return Seller;
            }
        }
    }
}
