using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member fot thisOrder
        clsOrder mThisOrder = new clsOrder();
        //public property for the orderlist
        public List<clsOrder> OrderList {
            get
            {
                //return the private data
                return mOrderList;
            }
             set
            {
                //set the private data
                mOrderList = value;
            }
          }
        public int Count {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }    
        }
        //public property for ThisOrder
        public clsOrder ThisOrder {
            get
            {
                //return the private data
                return mThisOrder;
            }
                set
            {
                //set the private data
                mThisOrder = value;
            }
        }
        //constructor for the class
        public clsOrderCollection()
        {
            /*   //var for the index
               Int32 Index = 0;
               //var to store the record count
               Int32 RecordCount = 0;
               //object for the data connection
               clsDataConnection DB = new clsDataConnection();
               //execute the stored procedure
               DB.Execute("sproc_tblOrder_SELECTALL");
               //get the count of records
               RecordCount = DB.Count;
               //while there are records to process
               while (Index <RecordCount)
               {
                   //create a blank order
                   clsOrder AnOrder = new clsOrder();
                   //read in the fields from the current record
                   AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                   AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                   AnOrder.OrderDetails = Convert.ToString(DB.DataTable.Rows[Index]["OrderDetails"]);
                   AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                   AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date Ordered"]);
                   //add the record to the private data member
                   mOrderList.Add(AnOrder);
                   //point at the next record
                   Index++;

               }*/


            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SELECTALL");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new record to the database based on the value of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDetails", mThisOrder.OrderDetails);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
            
             /*//set the primary key value of the new record
            mThisOrder.OrderID = 12;
            //return the primary key of the new record
            return mThisOrder.OrderID;*/
        }

        public void Update()
        {
            //upddate an existing record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDetails", mThisOrder.OrderDetails);
            DB.AddParameter("@Price",mThisOrder.Price);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.OrderDetails = Convert.ToString(DB.DataTable.Rows[Index]["OrderDetails"]);
                AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date Ordered"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;

            }
        }

        

        public void ReportByCustomerID(int CustomerID)
        {
            //filters the records based on a CustomerID
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerID parameter to the database
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerID");
            //populate the array list with the data table
            PopulateArray(DB);
        }

       
    }
}