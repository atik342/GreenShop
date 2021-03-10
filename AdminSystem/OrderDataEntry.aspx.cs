using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the price
        AnOrder.OrderDetails = txtOrderDetails.Text;
        //store the price in the session object
        Session["AnOrder"] = AnOrder;
        //navgate to viewer page
        Response.Redirect("OrderViewer.aspx");
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
}