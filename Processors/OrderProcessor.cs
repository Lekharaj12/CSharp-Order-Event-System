using System;
using OrderApp.Models;

namespace OrderApp.Processors
{
    // Delegate
    public delegate void OrderPlacedHandler(Order order);

    public class OrderProcessor
    {
        // Event
        public event OrderPlacedHandler OnOrderPlaced;

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Order Placed: {order.OrderId}");

            // Null-safe event invocation
            OnOrderPlaced?.Invoke(order);
        }
    }
}