using System;
using OrderApp.Models;
using OrderApp.Processors;
using OrderApp.Services;

namespace OrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Order Processor
            OrderProcessor processor = new OrderProcessor();

            // Create Services
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            LoggerService loggerService = new LoggerService();

            // Subscribe Methods to Event
            processor.OnOrderPlaced += emailService.SendEmail;
            processor.OnOrderPlaced += smsService.SendSMS;
            processor.OnOrderPlaced += loggerService.LogOrder;

            // Create Order
            Order order = new Order
            {
                OrderId = 101,
                CustomerName = "Rahul",
                Amount = 5000
            };

            // Process Order
            processor.ProcessOrder(order);

            // Optional Unsubscribe Example
            processor.OnOrderPlaced -= smsService.SendSMS;

            Console.WriteLine("\nAfter Unsubscribing SMS Service:\n");

            processor.ProcessOrder(order);
        }
    }
}
