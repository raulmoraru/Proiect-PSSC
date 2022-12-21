using System;
using ProiectPSSC.Domain.Models;
using static ProiectPSSC.Domain.Models.UnvalidatedOrder;

namespace ProiectPSSC
{
    public class OrderWorkflow
    {
        /*public void PlaceOrder(Order order)
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
    */

        class Program
        {
            static void Main(string[] args)
            {
                // Create an instance of the OrderWorkflow class
                var workflow = new OrderWorkflow();
                var OrdersList = ReadOrder().ToArray();
                List<UnvalidatedOrder> OrderList_ = new List<UnvalidatedOrder>(OrdersList);
                PrintOrders(OrderList_);
               // PlaceOrderCommand command = new OrdersList();
               /* var check = workflow.Execute(command, (checkExistence) => true);
                check.Match(
                     whenPlacingOrderEventFailedEvent: @event =>
                     {
                         Console.WriteLine($"The order could not be placed: {@event.Reason}");
                         return @event;
                     },
                     whenPlacingOrderEventSucceededEvent: @event =>
                     {
                         Console.WriteLine($"The order was successfully placed");
                         return @event;
                     });
                //workflow.PlaceOrder(order);*/
            }

            private static List<UnvalidatedOrder> ReadOrder()
            {
                List<UnvalidatedOrder> OrdersList = new();
                do
                {
                    var orderId = ReadSomething("ID of the order: ");
                    if (string.IsNullOrEmpty(orderId))
                    {
                        break;
                    }
                    var CustomerName = ReadSomething("Name of the customer: ");
                    if (string.IsNullOrEmpty(CustomerName))
                    {
                        break;
                    }
                    var ItemName = ReadSomething("Name of the item: ");
                    if (string.IsNullOrEmpty(ItemName))
                    {
                        break;
                    }
                    var Quantity = ReadSomething("Item quantity: ");
                    if (string.IsNullOrEmpty(Quantity))
                    {
                        break;
                    }
                    var Price = ReadSomething("Price of the item: ");
                    if (string.IsNullOrEmpty(Price))
                    {
                        break;
                    }
                    OrdersList.Add(new(orderId, CustomerName, ItemName, Quantity, Price));
                    var GoOn = ReadSomething("Another order? yes/no\n");
                    if (!GoOn.Equals("yes"))
                    {
                        break;
                    }

                } while (true);
                return OrdersList;
            }
            private static string? ReadSomething(string strg)
            {
                Console.Write(strg);
                return Console.ReadLine();
            }
            private static void PrintOrders(List<UnvalidatedOrder> OrdersList)
            {
                foreach (var order in OrdersList)
                {
                    Console.WriteLine(order.Order_toString());
                    Console.WriteLine();
                }
            }

            private static string checkExistence(List<UnvalidatedOrder> OrdersList, string orderID)
            {
                foreach (var order in OrdersList)
                {
                    if (order.orderId.Equals(orderID))
                    {
                        return $"Order Id: {order.orderId}";
                    }
                }
                return $"Unregistrated order";
            }
        }
    }
    }
