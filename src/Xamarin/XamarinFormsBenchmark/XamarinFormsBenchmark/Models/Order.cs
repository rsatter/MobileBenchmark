using System;
using SQLite;

namespace XamarinFormsBenchmark.Models
{
    public class Order
    {
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public double Freight { get; set; }
        [PrimaryKey]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipRegion { get; set; }
        public int ShipVia { get; set; }
    }
}
