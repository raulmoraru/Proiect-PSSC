using Newtonsoft.Json;


namespace ProiectPSSC.Domain.Models
{
    internal class OrderProcessor
    {
        public string Status { get; set; }
        public void ProcessOrder(string orderJson)
        {
            OrderValidator.OrderDetails order = JsonConvert.DeserializeObject<OrderValidator.OrderDetails>(orderJson);
            OrderValidator validator = new OrderValidator();
            if (validator.ValidateString(order.CustomerName) && validator.ValidateInt(order.Price) && validator.ValidateInt(order.Quantity) && validator.ValidateString(order.ItemName))
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
