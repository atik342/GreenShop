using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
     
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the customer id
        string CustomerID = txtCustomerID.Text;
        //capture the orderdetails
        string OrderDetails = txtOrderDetails.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the DateOrdered
        string DateOrdered = txtDateOrdered.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
        if(Error == "")
        {
            //capture the customerid
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //capture the OrderDetails
            AnOrder.OrderDetails = OrderDetails;
            //capture the Price
            AnOrder.Price = Convert.ToInt32(Price) ;
            //capture the date order
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e. OrderID = -1 then add the data
            if(OrderID == -1)
            {
                //set the ThisOrder Property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                AnOrder.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }

            //redirect back to the list page
            Response.Redirect("OrderList.aspx");
        }
       else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
  
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if(Found == true)
        {
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtOrderDetails.Text = AnOrder.OrderDetails;
            txtDateOrdered.Text = AnOrder.DateOrdered.ToString() ;
            txtPrice.Text = AnOrder.Price.ToString();
        }
    }
    void DisplayOrder()
    {
        //create an instance of the order
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = OrderBook.ThisOrder.CustomerID.ToString();
        txtOrderDetails.Text = OrderBook.ThisOrder.OrderDetails;
        txtPrice.Text = OrderBook.ThisOrder.Price.ToString();
        txtDateOrdered.Text = OrderBook.ThisOrder.DateOrdered.ToString();
    }
}