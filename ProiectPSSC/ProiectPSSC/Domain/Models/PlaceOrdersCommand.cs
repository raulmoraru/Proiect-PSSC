using System;

namespace  ProiectPSSC.Domain.Models
{
    public class PlaceOrdersCommand
    {
        public PlaceOrdersCommand(IReadOnlyCollection<UnvalidatedOrder> inputOrder)
        {
            InputOrder= inputOrder;
        }
        public IReadOnlyCollection<UnvalidatedOrder> InputOrder { get; }
    }
}
