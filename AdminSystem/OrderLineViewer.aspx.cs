using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrderLine AnOrderLine = new clsOrderLine();
        //get the data from the session object
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        //display the orderdetails for this entry
        Response.Write(AnOrderLine.ProductDetails);
    }
}