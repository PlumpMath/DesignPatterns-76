using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ServiceLocator
{
    public class ServiceLocator
    {
        private static readonly Hashtable services = new Hashtable();

        public static void AddService<T>(T t)
        {
            services.Add(typeof(T).Name, t);
        }

        public static void AddService<T>(string name, T t)
        {
            services.Add(name, t);
        }

        public static T GetService<T>()
        {
            return (T)services[typeof(T).Name];
        }

        public static T GetService<T>(string serviceName)
        {
            return (T)services[serviceName];
        }
    }
}
