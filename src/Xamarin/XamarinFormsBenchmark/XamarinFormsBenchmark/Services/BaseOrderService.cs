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
    public abstract class BaseOrderService : IOrderService
    {
        protected DataSource dataSource;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public abstract Order AddOrder(Order order);

        /// <summary>
        /// Add a <see cref="System.Collections.Generic.IList{T}"/> of
        /// <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <param name="orders">Collect of orders</param>
        /// <returns>true if file successfully written</returns>

        public abstract IList<Order> AddOrders(IList<Order> orders);

        /// <summary>
        /// Delete an <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <param name="order"></param>
        /// <returns><see cref="true"/> if successful else <see cref="false"/></returns>
        public abstract bool DeleteOrder(Order order);

        /// <summary>
        /// Get a <see cref="System.Collections.Generic.IList{T}"/> of
        /// <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <returns>
        /// <see cref="System.Collections.Generic.IList{T}"/> of
        /// <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </returns>
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

        /// <summary>
        /// Update an <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </summary>
        /// <param name="order">
        /// The <see cref="XamarinFormsBenchmark.Models.Order"/> to update.
        /// </param>
        /// <returns>
        /// The updated <see cref="XamarinFormsBenchmark.Models.Order"/>.
        /// </returns>
        public abstract Order Update(Order order);
    }
}
