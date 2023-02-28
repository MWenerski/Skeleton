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

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the username
        AnCustomer.Username = TxtUsername.Text;
        AnCustomer.Password = txtPassword.Text;
        AnCustomer.Email = txtEmail.Text;
        //AnCustomer.DateAdded = txtDateCreated.Text;
        AnCustomer.Verified = chkVerified.Checked;
        //store the username in the session object
        Session["AnCustomer"] = AnCustomer;

        //capture the username
        //AnCustomer.Password = txtPassword.Text;
        //store the username in the session object
        //Session["AnCustomer"] = AnCustomer;


        //nav to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}