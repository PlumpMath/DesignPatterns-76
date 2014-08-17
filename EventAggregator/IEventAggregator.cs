using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregator
{
    public interface IEventAggregator
    {
        void Subscribe(object subscriber);
        void Publish<TEvent>(TEvent eventToPublish);
    }
}
