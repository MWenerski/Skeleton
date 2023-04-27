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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySuppliers();
        }

    }

    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //set the data source to list of suppliers in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "ID";
        //set the data field to display 
        lstSupplierList.DataTextField = "Address";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ID"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;
        //if a record has been selected from trhe list
        if (lstSupplierList.SelectedIndex != 1)
        {
            //get the primary key value of the record to edit
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["ID"] = SupplierID;
        }
        else //if no record were selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}