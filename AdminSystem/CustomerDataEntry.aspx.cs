using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //fields
    Int32 CustomerID;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false) 
        {
            if (CustomerID != -1) 
            {
                DisplayCustomer();
            }   
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        TxtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        TxtUsername.Text = CustomerBook.ThisCustomer.Username;
        txtPassword.Text = CustomerBook.ThisCustomer.Password;
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
        chkVerified.Checked = CustomerBook.ThisCustomer.Verified;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();

        //capture the data
        string username = TxtUsername.Text;
        string password = txtPassword.Text;
        string email = txtEmail.Text;
        string dateAdded = txtDateAdded.Text;
        
        //variable to store any error messages
        string error = "";

        //validate the data
        error = AnCustomer.Valid(username, password, email, dateAdded);
        if (error == "")
        {
            //capture the data
            AnCustomer.CustomerID = CustomerID;
            AnCustomer.Username = username;
            AnCustomer.Password = password;
            AnCustomer.Email = email;
            AnCustomer.DateAdded = Convert.ToDateTime(dateAdded);
            AnCustomer.Verified = chkVerified.Checked;
            //AnCustomer.CustomerID = Convert.ToInt32(TxtCustomerID.Text);
            //AnCustomer.Username = TxtUsername.Text;
            //AnCustomer.Password = txtPassword.Text;
            //AnCustomer.Email = txtEmail.Text;
            //AnCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //AnCustomer.Verified = chkVerified.Checked;

            //instance of customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            else 
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }
            //CustomerList.ThisCustomer = AnCustomer;
            //CustomerList.Add();

            //store the username in the session object
            //Session["AnCustomer"] = AnCustomer;

            //nav to the viewer page
            //Response.Redirect("CustomerViewer.aspx");
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else 
        {
            //display the error message
            lblError.Text = error;
        }
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