namespace ClassLibrary
{
    public class clsOrderLine
    {
        public int ProductQuantity { get; set; }
        public bool ShippingStatus { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int OrderLineID { get; set; }
        public string ProductDetails { get; set; }
    }
}