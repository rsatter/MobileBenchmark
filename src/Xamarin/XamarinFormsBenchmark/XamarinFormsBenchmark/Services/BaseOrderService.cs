using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Services
{
    /// <summary>
    /// This is an abstract base class for implementations of
    /// <see cref="XamarinFormsBenchmark.Services.IOrderService"/>. It
    /// implements a base method for setting the actual implementation of 
    /// <see cref="XamarinFormsBenchmark.Services.IOrderService"/> based on the
    /// <see cref="XamarinFormsBenchmark.Services.DataSource"/> set.
    /// </summary>
    public abstract class BaseOrderService :IOrderService
    {
        protected DataSource dataSource;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public abstract bool AddOrder(Order order);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public abstract bool AddOrders(IList<Order> orders);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public abstract bool DeleteOrder(Order order);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract IList<Order> GetOrders();

        /// <summary>
        /// Sets the implementation of
        /// <see cref="XamarinFormsBenchmark.Services.IOrderService"/> to use
        /// based on <see cref="XamarinFormsBenchmark.Services.DataSource"/>
        /// argument.
        /// </summary>
        /// <param name="dataSource">
        /// The type of datasource a
        /// <see cref="XamarinFormsBenchmark.Services.DataSource.Database"/> or
        /// <see cref="XamarinFormsBenchmark.Services.DataSource.JSON"/>.
        /// </param>
        public virtual void SetDataSource(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public abstract bool Update(Order order);
    }
}
