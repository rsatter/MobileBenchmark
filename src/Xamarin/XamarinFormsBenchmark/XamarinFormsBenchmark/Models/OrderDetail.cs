using System;
using SQLite;

namespace XamarinFormsBenchmark.Models
{
    public class OrderDetail
    {
        public double Discount { get; set; }
        [PrimaryKey]
        public int Id { get; set; }
        [Indexed]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int  Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
