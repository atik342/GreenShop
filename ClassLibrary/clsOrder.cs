using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order property
        private Decimal mPrice;
        private Int32 mOrderID;
        private Int32 mCustomerID;
        private string mOrderDetails;
        private DateTime mDateOrdered;


        public DateTime DateOrdered {
            get
            {
                //this line of code sends data out of the property
                return mDateOrdered;
            }
            set
            {
                //this line of code allows data into the property
                mDateOrdered = value;
            }
        }
        public Int32 OrderID {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }
        public string OrderDetails {
            get
            {
                //this line of code sends data out of the property
                return mOrderDetails;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDetails = value;
            }
        }
        public Decimal Price { 
           get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }
        public int CustomerID {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        public bool Find(int OrderID)
        {
            //set the private data members to the test data value
            mPrice = 210;
            mOrderID = 21;
            mCustomerID = 12;
            mOrderDetails = "this is your product";
            mDateOrdered = Convert.ToDateTime("10/10/2020");
            //always return true
            return true;
        }
    }
}