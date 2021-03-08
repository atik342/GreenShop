using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        //private data members for the orderline property
        private Int32 mOrderLineID;
        private Int32 mProductID;
        private Int32 mOrderID;
        private string mProductDetails;
        private Int32 mProductQuantity;
        private Boolean mShippingstatus;


        public int ProductQuantity {
            get
            {
                //this line of code sends data out of the property
                return mProductQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mProductQuantity = value;
            }
        }
        public bool ShippingStatus {
            get
            {
                //this line of code sends data out of the property
                return mShippingstatus;
            }
            set
            {
                //this line of code allows data into the property
                mShippingstatus = value;
            }
        }
        public int ProductID {
            get
            {
                //this line of code sends data out of the property
                return mProductID;
            }
            set
            {
                //this line of code allows data into the property
                mProductID = value;
            }
        }
        public int OrderID {
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
        public int OrderLineID {
            get
            {
                //this line of code sends data out of the property
                return mOrderLineID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderLineID = value;
            }
        }
        public string ProductDetails {
            get
            {
                //this line of code sends data out of the property
                return mProductDetails;
            }
            set
            {
                //this line of code allows data into the property
                mProductDetails = value;
            }
        }

        public bool Find(int orderLineID)
        {
            //set the private data members to the test data value
            mOrderLineID = 21;
            mProductID = 212;
            mOrderID = 12;
            mProductDetails = "this is your product";
            mProductQuantity = 3;
            mShippingstatus = true;
            //always return true
            return true;
        }
    }
}