using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrderLine AnOrderLine = new clsOrderLine();
        //capture the price
        AnOrderLine.ProductDetails = txtProductDetails.Text;
        //store the price in the session object
        Session["AnOrderLine"] = AnOrderLine;
        //navgate to viewer page
        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void btnFind2_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrderLine AnOrderLine = new clsOrderLine();
        //variable to store the primary key
        Int32 OrderLineID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        //find the record
        Found = AnOrderLine.Find(OrderLineID);
        //if found
        if (Found == true)
        {
            txtProductID.Text = AnOrderLine.ProductID.ToString();
            txtProductDetails.Text = AnOrderLine.ProductDetails;
            txtProductQuantity.Text = AnOrderLine.ProductQuantity.ToString();
            //txtOrderID.Text = AnOrderLine.OrderID.ToString();
        }
    }
}