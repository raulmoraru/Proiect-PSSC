using System;
using System.Runtime.CompilerServices;
using ProiectPSSC.Domain.Models;
using static ProiectPSSC.Domain.Models.UnvalidatedOrder;

namespace ProiectPSSC
{
    public class OrderWorkflow
    {

        class Program
        {
            private static int orderCounter=0;

            static void Main(string[] args)
            {
                var workflow = new OrderWorkflow();
                var OrdersList = ReadOrder().ToArray();
                List<UnvalidatedOrder> OrderList_ = new List<UnvalidatedOrder>(OrdersList);
                PrintOrders(OrderList_);
            }

            private static List<UnvalidatedOrder> ReadOrder()
            {
                List<UnvalidatedOrder> OrdersList = new();
                do
                {
                    /* var orderId = ReadSomething("ID of the order: ");
                     if (string.IsNullOrEmpty(orderId))
                     {
                         break;
                     }*/

                    var orderId = (++orderCounter).ToString();
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
