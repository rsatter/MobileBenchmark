using System;
using System.Collections.Generic;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Services
{
    public interface IOrderService
    {
        Order AddOrder(Order order);
        IList<Order> AddOrders(IList<Order> orders);
        bool DeleteOrder(Order order);
        IList<Order> GetOrders();
        void SetDataSource(DataSource dataSource);
        Order Update(Order order);
    }
}
