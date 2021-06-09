using Backtester.Domain.Entities;
using System;

namespace Backtester.Domain.Exceptions
{
    public class UnsupportedAssetException : Exception
    {
        public UnsupportedAssetException(Asset asset)
            : base($"{asset.Exchange?.Name ?? "Unknown exchange"} doesn't support {asset.Name}.")
        {
        }
    }
}
