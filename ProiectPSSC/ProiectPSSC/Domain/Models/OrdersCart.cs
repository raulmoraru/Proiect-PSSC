using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Choices;

namespace ProiectPSSC.Domain.Models
{
    [AsChoice]
    public static partial class OrdersCart
    {
        public interface IOrdersCart { }

        public record UnvalidatedOrder : IOrdersCart
        {
            public UnvalidatedOrders(IReadOnlyCollection<UnvalidatedOrder> orderList)
            {
                OrderList= orderList;
            }
            public IReadOnlyCollection<UnvalidatedOrder> OrderList { get; }
        }

        public record InvalidatedOrder : IOrdersCart
        {
            internal InvalidatedOrder(IReadOnlyCollection<UnvalidatedOrder> orderList,string reason)
            {
                OrderList= orderList;
                Reason= reason;
            }
            public IReadOnlyCollection<UnvalidatedOrder> OrderList { get; }
            public string Reason { get; }
        }

        public record ValidatedOrder : IOrdersCart
        {
            internal ValidatedOrder(IReadOnlyCollection<ValidatedOrder> ordersList)
            {
                OrdersList= ordersList;
            }
            public IReadOnlyCollection<ValidatedOrder> OrdersList { get; }
        }

        public record CalculateOrder : IOrdersCart
        {
            internal CalculateOrder(IReadOnlyCollection<CalculateOrder> ordersList)
            {
                OrdersList= ordersList;
            }
            public IReadOnlyCollection<CalculateOrder> OrdersList { get; }
        }
        public record PlaceOrder : IOrdersCart
        {
            internal PlaceOrder(IReadOnlyCollection<CalculateOrder> calculateCustomerOrders,int orderId)
            {
                CalculateCustomerOrders= calculateCustomerOrders;
                NumberOfOrder= orderId;
            }
            public IReadOnlyCollection<CalculateOrder> CalculateOrders { get; }
            public int orderId { get; }

        }


    }
}
