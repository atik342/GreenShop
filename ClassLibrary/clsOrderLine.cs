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

        public bool Find(int OrderLineID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the address no to search for
            DB.AddParameter("@OrderLineID", OrderLineID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductDetails = Convert.ToString(DB.DataTable.Rows[0]["ProductDetails"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                mShippingstatus = Convert.ToBoolean(DB.DataTable.Rows[0]["ShippingStatus"]);
                //return true if everything is working ok
                return true;
            }
            //if no record was found
             else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}