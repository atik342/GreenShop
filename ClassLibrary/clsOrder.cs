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

        public object Active { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
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

        public string Valid(string customerID, string orderDetails, string price, string dateOrdered)
        {
            //create a string variable to store the error
            String Error = "";
            //create temporary variable to store data values
            DateTime DateTemp;
            //if the customerid is blank
            if (customerID.Length == 0 )
            {
                //record the error
                Error = Error + "The Customer ID may not be blank : ";
            }
            //if the customerid is greater than 6 characters
            if(customerID.Length>6)
            {
                //record the error
                Error = Error + "The Customer ID must me less than six characters : ";
            }
            try
            {
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(dateOrdered);
            if(DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + " The date can not be in the past : ";
            }
            //check to see if the date is greater than todays date
            if ( DateTemp> DateTime.Now.Date)
            {
                //record the error
                Error = Error + " The date can not be in the future";
            }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the OrderDetails blank
            if(orderDetails.Length == 0)
            {
                //record the error
                Error = Error + "The OrderDetails may not be blank : ";
            }
            //if the orderDetails is too long
            if(orderDetails.Length >50)
            {
                //record the error
                Error = Error + "The orderdetails must be less than 50 characters : ";
            }
            //if the price blank
            if(price.Length == 0 )
            {
                //record the error
                Error = Error + "the price can not be blank : ";
            }
            //if the price is too long
            if(price.Length >50)
            {
                //record the error
                Error = Error + "The price must be less than 50 characters";
            }
            //return any error message
            return Error;
        }
    }

    public class chkActive
    {
        public static object Checked { get; set; }
    }
}