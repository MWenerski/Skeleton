using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier InSupplier = new clsSupplier();
        //get the data from the session object
        InSupplier = (clsSupplier)Session["InSupplier"];
        //display the name of the supplier for this entry
        Response.Write(InSupplier.ID);
        Response.Write("<br/>");
        Response.Write(InSupplier.SupplierName);
        Response.Write("<br/>");
        Response.Write(InSupplier.Email);
        Response.Write("<br/>");
        Response.Write(InSupplier.DateAdded);
        Response.Write("<br/>");
        Response.Write(InSupplier.ContactNumber);
        Response.Write("<br/>");
        Response.Write(InSupplier.Address);
        Response.Write("<br/>");
        Response.Write(InSupplier.OngoingContract);
        Response.Write("<br/>");

    }
}