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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer) Session["AnCustomer"];
        //display the username, password, email for this entry
        Response.Write(AnCustomer.CustomerID);
        Response.Write("<br />");
        Response.Write(AnCustomer.Username);
        Response.Write("<br />");
        Response.Write(AnCustomer.Password);
        Response.Write("<br />");
        Response.Write(AnCustomer.Email);
        Response.Write("<br />");
        Response.Write(AnCustomer.Verified);
        Response.Write("<br />");
        Response.Write(AnCustomer.DateAdded);
        
    }
}
