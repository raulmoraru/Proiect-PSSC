using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC.Domain.Models
{
    class OrderDetails
    {
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class OrderValidator
    {

        public bool Validate(OrderDetails order)
        {
            if (string.IsNullOrEmpty(order.CustomerName))
            {
                Console.WriteLine("Error: Customer name is required.");
                return false;
            }

            if (order.Price <= 0)
            {
                Console.WriteLine("Error: Price must be greater than zero.");
                return false;
            }

            if (string.IsNullOrEmpty(order.ItemName))
            {
                Console.WriteLine("Error: Item name is required");
                return false;
            }

            if (order.Quantity <= 0)
            {
                Console.WriteLine("Error: Quantity must be greater than zero.");
                return false;
            }

            return true;
        }
    }
}
