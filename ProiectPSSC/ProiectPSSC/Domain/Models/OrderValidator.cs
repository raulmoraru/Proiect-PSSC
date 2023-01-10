using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC.Domain.Models
{
    internal class OrderValidator
    {
        public class OrderDetails
        {
            public string CustomerName { get; set; }
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
        }
        public bool ValidateString(string orderString)
        {
            if (string.IsNullOrEmpty(orderString))
            {
                return false;
            }
            return true;
        }
        public bool ValidateInt(int orderInt) {
            if (orderInt <= 0)
            {
                return false;
            }
            return true;
        } 
    }
}
