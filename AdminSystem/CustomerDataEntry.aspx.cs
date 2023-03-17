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

        //capture the data
        AnCustomer.CustomerID = Convert.ToInt32(TxtCustomerID.Text);
        AnCustomer.Username = TxtUsername.Text;
        AnCustomer.Password = txtPassword.Text;
        AnCustomer.Email = txtEmail.Text;
        //AnCustomer.DateAdded = txtDateAdded.Text;
        AnCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AnCustomer.Verified = chkVerified.Checked;

        //store the username in the session object
        Session["AnCustomer"] = AnCustomer;

        //store the username in the session object
        //Session["AnCustomer"] = AnCustomer;


        //nav to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        //System.FormatException: 'Input string was not in a correct format.'
        CustomerID = Convert.ToInt32(TxtCustomerID.Text);
        Found = AnCustomer.Find(CustomerID);
        if (Found == true) {
            TxtCustomerID.Text = AnCustomer.CustomerID.ToString();
            TxtUsername.Text = AnCustomer.Username;
            txtPassword.Text = AnCustomer.Password;
            txtEmail.Text = AnCustomer.Email;
            chkVerified.Text = AnCustomer.Verified.ToString();
            txtDateAdded.Text = AnCustomer.DateAdded.ToString();
        }
    }
}