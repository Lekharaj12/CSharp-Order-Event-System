using System;
using OrderApp.Models;

namespace OrderApp.Services
{
    public class SMSService
    {
        public void SendSMS(Order order)
        {
            Console.WriteLine($"SMS sent to {order.CustomerName}");
        }
    }
}