using System;
using CSharp.Choices;
using System.Collections.Generic;

namespace ProiectPSSC.Domain.Models
{
    [AsChoice]
    public static partial class PlacingOrderEvent
    {
        public interface IPlacingOrderEvent { }
        public record PlacingOrderEventSucceededEvent : IPlacingOrderEvent
        {
            public decimal IdOfOrder { get; }
            public IReadOnlyCollection<CalculateOrder> CalculatedOrder { get; }
            internal PlacingOrderEventSucceededEvent(IReadOnlyCollection<CalculateOrder> calculatedOrder, decimal orderId)
            {
                CalculatedOrder= calculatedOrder;
                IdOfOrder= orderId;
            }
        }
        public record PlacingOrderEventFailedEvent : IPlacingOrderEvent
        {
            public string Reason { get; }
            internal PlacingOrderEventFailedEvent(string reason)
            {
                Reason= reason;
            }
        }
    }
}
