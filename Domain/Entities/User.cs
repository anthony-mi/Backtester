using System.Collections.Generic;

namespace Backtester.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }

        public IEnumerable<Session> Sessions { get; set; }
    }
}
