using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonFileOrderService : BaseOrderService
    {
        IList<Order> orders = new List<Order>();

        /// <summary>
        /// Add an <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public override Order AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add a <see cref="System.Collections.Generic.IList{T}"/> of
        /// <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <param name="orders">Collect of orders</param>
        /// <returns>true if file successfully written</returns>
        public override IList<Order> AddOrders(IList<Order> order)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <param name="order"></param>
        /// <returns><see cref="true"/> if successful else <see cref="false"/></returns>
        public override bool DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a <see cref="System.Collections.Generic.IList{T}"/> of
        /// <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <returns>
        /// <see cref="System.Collections.Generic.IList{T}"/> of
        /// <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </returns>
        public override IList<Order> GetOrders()
        {
            IList<Order> orders;
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("Your_File.json"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    orders = (IList<Order>)serializer.Deserialize(reader, typeof(List<Order>));
                }
            }
            return orders;
        }

        /// <summary>
        /// Update an <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <param name="order"></param>
        /// <returns><see cref="true"/> if successful else <see cref="false"/></returns>
        public override Order Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
