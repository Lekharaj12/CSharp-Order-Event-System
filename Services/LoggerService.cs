using System;
using OrderApp.Models;

namespace OrderApp.Services
{
    public class LoggerService
    {
        public void LogOrder(Order order)
        {
            Console.WriteLine("Order logged successfully");
        }
    }
}