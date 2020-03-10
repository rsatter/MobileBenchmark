using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinFormsBenchmark.Models;

[assembly:Dependency(typeof(XamarinFormsBenchmark.Services.OrderRouterService))]
namespace XamarinFormsBenchmark.Services
{
    /// <summary>
    /// This class routes the method to the correct implementation of the
    /// IOrderService based on the datasource set.
    /// </summary>
    public class OrderRouterService : BaseOrderService
    {
        protected IOrderService sqliteOrderService = new SqliteOrderService();
        protected IOrderService jsonOrderService = new JsonFileOrderService();

        protected IOrderService OrderService { set; get;  }

        public override bool AddOrder(Order order)
        {
            return OrderService.AddOrder(order);
        }

        public override bool AddOrders(IList<Order> orders)
        {
            return OrderService.AddOrders(orders);
        }

        public override bool DeleteOrder(Order order)
        {
            return OrderService.DeleteOrder(order);
        }

        public override IList<Order> GetOrders()
        {
            return OrderService.GetOrders();
        }

        public override void SetDataSource(DataSource dataSource)
        {
            base.SetDataSource(dataSource);
            OrderService = dataSource == DataSource.Database ? sqliteOrderService : jsonOrderService;
        }

        public override bool Update(Order order)
        {
            return OrderService.Update(order);
        }
    }
}
