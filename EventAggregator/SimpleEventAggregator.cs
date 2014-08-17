using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventAggregator
{
    public class SimpleEventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, List<WeakReference>> _eventSubscriberList = 
            new Dictionary<Type, List<WeakReference>>();

        private readonly object _lock = new object();

        public void Subscribe(object subscriber)
        {
            lock (_lock)
            {
                var subscriberTypes =
                    subscriber.GetType().GetInterfaces().
                        Where(i => i.IsGenericType && 
                        i.GetGenericTypeDefinition() ==
                        typeof(ISubscriber<>));

                var weakReference = new WeakReference(subscriber);

                foreach (var subscriberType in subscriberTypes)
                {
                    var subscribers = GetSubscribers(subscriberType);
                    subscribers.Add(weakReference);
                }
            }
        }

        private List<WeakReference> GetSubscribers(Type subscriberType)
        {
            List<WeakReference> subscribers;
            lock (_lock)
            {
                var found = _eventSubscriberList.TryGetValue(subscriberType, out subscribers);
                if (!found)
                {
                    subscribers = new List<WeakReference>();
                    _eventSubscriberList.Add(subscriberType, subscribers);
                }
            }
            return subscribers;
        }

        public void Publish<TEvent>(TEvent eventToPublish)
        {
            var subscriberType = typeof(ISubscriber<>).MakeGenericType(typeof(TEvent));
            var subscribers = GetSubscribers(subscriberType);
            List<WeakReference> subscribersToRemove = new List<WeakReference>();

            foreach (var weakSubscriber in subscribers)
            {
                if (weakSubscriber.IsAlive)
                {
                    var subscriber = (ISubscriber<TEvent>)weakSubscriber.Target;
                    var syncContext = SynchronizationContext.Current;
                    if (syncContext == null)
                        syncContext = new SynchronizationContext();

                    syncContext.Post(s => subscriber.OnEvent(eventToPublish), null);
                }
                else
                {
                    subscribersToRemove.Add(weakSubscriber);
                }
            }

            if(subscribersToRemove.Any())
            {
                lock (_lock)
                {
                    foreach (var remove in subscribersToRemove)
                    {
                        subscribers.Remove(remove);
                    }
                }
            }
        }
    }
}
