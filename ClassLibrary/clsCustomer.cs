using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool ActiveOrders { get; set; }
        public DateTime dateAccCreated { get; set; }
        public string FullName { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public int CustID { get; set; }
        public string MobileNo { get; set; }
    }
}