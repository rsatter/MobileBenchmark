using System;
using System.Collections.Generic;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Services
{
    public interface IOrderService
    {
        bool AddOrder(Order order);
        bool AddOrders(IList<Order> orders);
        bool DeleteOrder(Order order);
        IList<Order> GetOrders();
        void SetDataSource(DataSource dataSource);
        bool Update(Order order);
    }
}
