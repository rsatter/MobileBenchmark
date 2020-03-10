using System;
using System.Collections.Generic;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Services
{
    public class SqliteOrderService : BaseOrderService  
    {
        public SqliteOrderService()
        {
        }

        public override bool AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public override bool AddOrders(IList<Order> order)
        {
            throw new NotImplementedException();
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
