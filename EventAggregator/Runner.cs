using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using EventAggregator.EventClasses;
using System.Timers;

namespace EventAggregator
{
    public class Runner
    {
        private IEventAggregator _ea;
        private ObservableCollection<Order> _orders;

        OrderView view1;
        OrderView view2;

        public Runner()
        {
            _ea = new SimpleEventAggregator();
            _orders = new ObservableCollection<Order>();

            CreateView();
            CreateOrder();

            //view2.Name = null;
            //view2 = null;

            //GC.Collect();

            SaveOrder();
        }

        public void CreateView()
        {
            // create view
            view1 = new OrderView(this._ea);
            view1.Name = "View1";
            view2 = new OrderView(this._ea);
            view2.Name = "View2";
        }
        
        public void CreateOrder()
        {
            var order = new Order { OrderNumber = 100, Description = "Ammunition" };
            _orders.Add(order);
            _ea.Publish(new OrderCreated { Order = order });
        }

        private void SaveOrder()
        {
            var order = _orders.First();
            _ea.Publish(new OrderSaved { Order = order });
        }
    }
}
