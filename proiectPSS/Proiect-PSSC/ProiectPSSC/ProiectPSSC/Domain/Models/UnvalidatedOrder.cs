using System;
namespace ProiectPSSC.Domain.Models
{
    public record UnvalidatedOrder(string orderId, string CustomerName, string ItemName, string Quantity, string Price)
    {
        public string Order_toString()
        {
            return $"Order Id: {orderId} \n Customer name: {CustomerName}\n Item: {ItemName} \n Quantity: {Quantity} \n Price: {Price}";
        }

    }
}