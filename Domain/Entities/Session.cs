using Backtester.Domain.Common;
using Backtester.Domain.Enums;
using System.Collections.Generic;

namespace Backtester.Domain.Entities
{
    public class Session : AuditableEntity
    {
        public int Id { get; set; }

        public User Owner { get; set; }

        public SessionStatus Status { get; set; }

        public Dictionary<Exchange, SessionStrategyData> SessionStrategiesData { get; set; }
    }
}
