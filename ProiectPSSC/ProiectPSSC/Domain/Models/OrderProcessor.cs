using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC.Domain.Models
{
    internal class OrderProcessor
    {
        public string Status { get; set; }
        public void ProcessOrder(string orderJson)
        {
            OrderDetails order = JsonConvert.DeserializeObject<OrderDetails>(orderJson);
            OrderValidator validator = new OrderValidator();
            if (validator.Validate(order))
            {
                Status = "Processing";
                 
                Console.WriteLine("Order is valid and being processed");
            }
            else
            {
                Console.WriteLine("Order is not valid, please check the errors");
            }
        }
    }
}
