using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public DateTime DateOrdered { get; set; }
        public int OrderID { get; set; }
        public string OrderDetails { get; set; }
        public decimal Price { get; set; }
        public int CustomerID { get; set; }
    }
}