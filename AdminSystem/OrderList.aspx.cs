using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        //this function handles the load event for the page
        if(IsPostBack == false)
        {
            //update the listbox
            DisplayOrder();
        }
    }
    void DisplayOrder()
    {
        //create an instance of the county collection
        ClassLibrary.clsOrderCollection Order = new ClassLibrary.clsOrderCollection();
        //set the data source to the list of counties in the collection
        lblOrderList.DataSource = Order.OrderList;
        //set the name of the primary key
        lblOrderList.DataValueField = "OrderID";
        //set the data field to display
        lblOrderList.DataTextField = "OrderDetails";
        //bind the data to the list
        lblOrderList.DataBind();
    }

    //event handler for the button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if(lblOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lblOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");

        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lblOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lblOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");

        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerID(Convert.ToInt32(txtFilter));
        lblOrderList.DataSource = Orders.OrderList;
        //set the name of primary key
        lblOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lblOrderList.DataTextField = "CustomerID";
        //bind the test
        lblOrderList.DataBind();
    }

    protected void txtFilter_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerID(12);
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lblOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lblOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lblOrderList.DataTextField = "CustomerID";
        //bind the data to the list
        lblOrderList.DataBind();
    }
}