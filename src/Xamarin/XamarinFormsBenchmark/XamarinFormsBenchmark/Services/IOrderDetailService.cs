using System;
using System.Collections.Generic;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Services
{
    public interface IOrderDetailService
    {
        IList<OrderDetail> GetOrderDetails(int orderId);
        bool AddOrderDetails(IList<OrderDetail> orderDetails);
    }
}
