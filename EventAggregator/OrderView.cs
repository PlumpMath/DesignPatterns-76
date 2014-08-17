using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventAggregator.EventClasses;

namespace EventAggregator
{
    public class OrderView : ISubscriber<OrderCreated>, ISubscriber<OrderSaved>
    {
        public string Name { get; set; }
        
        public OrderView(IEventAggregator ea)
        {
            ea.Subscribe(this);
        }

        public void OnEvent(OrderCreated e)
        {
            Console.WriteLine(Name + ", Order created: " + e.Order.OrderNumber);
        }

        public void OnEvent(OrderSaved e)
        {
            Console.WriteLine(Name + ", Order saved: " + e.Order.OrderNumber);
        }
    }
}
