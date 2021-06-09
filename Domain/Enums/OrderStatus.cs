using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Backtester.Domain.Enums
{
    public enum OrderStatus
    {
        [Description("The order has been accepted by the engine.")]
        [Display(Name="New")]
        New,
        [Description("A part of the order has been filled.")]
        [Display(Name = "Partially filled")]
        PartiallyFilled,
        [Description("The order has been completed.")]
        [Display(Name = "Filled")]
        Filled,
        [Description("The order has been canceled by the user.")]
        [Display(Name = "Canceled")]
        Canceled,
        [Description("Currently unused.")]
        [Display(Name = "Pending cancel")]
        PendingCancel,
        [Description("The order was not accepted by the engine and not processed.")]
        [Display(Name = "Rejected")]
        Rejected,
        [Description("The order was canceled according to the order type's rules (e.g. LIMIT FOK orders with no fill, LIMIT IOC or MARKET orders that partially fill)" +
            "or by the exchange, (e.g.orders canceled during liquidation, orders canceled during maintenance)")]
        [Display(Name = "Expired")]
        Expired
    }
}
