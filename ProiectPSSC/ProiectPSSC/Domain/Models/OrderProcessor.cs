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
        private static int orderCounter = 0;
        public string Status { get; set; }
        public void ProcessOrder(string orderJson)
        {
            OrderDetails order = JsonConvert.DeserializeObject<OrderDetails>(orderJson);
            OrderValidator validator = new OrderValidator();
            if (validator.Validate(order))
            {
                Status = "Processing";
                 static List<UnvalidatedOrder> ReadOrder()
                {
                    OrderValidator validator = new OrderValidator();
                    OrderDetails order = new OrderDetails();
                    List<UnvalidatedOrder> OrdersList = new();
                    do
                    {
                        var orderId = (++orderCounter).ToString();
                        var CustomerName = ReadSomething("Name of the customer: ");
                        // if (validator.Validate(order.CustomerName))
                       // {
                        //    break;
                      //  }
                        var ItemName = ReadSomething("Name of the item: ");
                        if (string.IsNullOrEmpty(ItemName))
                        {
                            Console.Error.WriteLine("The name of the item is required");
                            break;
                        }
                        var Quantity = ReadSomething("Item quantity: ");
                        if (string.IsNullOrEmpty(Quantity))
                        {
                            Console.Error.WriteLine("Item quantity is required");
                            break;
                        }
                        var Price = ReadSomething("Price of the item: ");
                        if (string.IsNullOrEmpty(Price))
                        {
                            Console.Error.WriteLine("Price is required");
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
                var OrdersList = ReadOrder().ToArray();
                List<UnvalidatedOrder> OrderList_ = new List<UnvalidatedOrder>(OrdersList);
                PrintOrders(OrderList_);

                Console.WriteLine("Order is valid and being processed");
            }
            else
            {
                Console.WriteLine("Order is not valid, please check the errors");
            }
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
    }
}
