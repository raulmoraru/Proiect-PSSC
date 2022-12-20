using System;

namespace ProiectPSSC
{
    public class OrderWorkflow
    {
        public void PlaceOrder(Order order)
        {
            ValidateOrder(order);
            CalculateTotal(order);
            ProcessPayment(order);
            SaveOrder(order);
            SendConfirmationEmail(order);
        }

        private void ValidateOrder(Order order)
        {
            // Validate the order details
            // Throw an exception if the order is invalid
            if (order.Quantity <= 0)
            {
                throw new Exception("Invalid quantity");
            }
        }

        private void CalculateTotal(Order order)
        {
            // Calculate the total cost of the order
            order.Total = order.Quantity * order.Price;
        }

        private void ProcessPayment(Order order)
        {
            // Process the payment for the order
        }

        private void SaveOrder(Order order)
        {
            // Save the order to the database
        }

        private void SendConfirmationEmail(Order order)
        {
            // Send a confirmation email to the customer
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the OrderWorkflow class
            var workflow = new OrderWorkflow();

            // Create a new order object
            var order = new Order();
            // Set the properties of the order object
            order.Id = 1;
            order.CustomerName = "John Smith";
            order.ItemName = "Table";
            order.Quantity = 1;
            order.Price = 100;

            // Place the order
            workflow.PlaceOrder(order);
        }
    }
}