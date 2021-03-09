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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the address no to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDetails = Convert.ToString(DB.DataTable.Rows[0]["OrderDetails"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["Date Ordered"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                // return that everything worked ok
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