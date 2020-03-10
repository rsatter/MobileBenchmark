using System;
using System.Collections.Generic;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonFileOrderService : BaseOrderService
    {
        public override bool AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method writes a list of orders to a file as JSON.
        /// </summary>
        /// <param name="orders">Collect of orders</param>
        /// <returns>true if file successfully written</returns>
        public override bool AddOrders(IList<Order> order)
        {
            return true;
        }

        public override bool DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public override IList<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
