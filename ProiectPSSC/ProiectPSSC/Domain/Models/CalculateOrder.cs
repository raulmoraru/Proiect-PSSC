  using System;
  
  namespace ProiectPSSC.Domain.Models
{
    public record CalculateOrder(OredrId orderId, CustomerName CustomerName, ItemName ItemName, Quantity Quantity, Price Price);
    
}