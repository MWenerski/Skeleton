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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier InSupplier = new clsSupplier();
        //capture the supplier name
        InSupplier.ID = Convert.ToInt32(txtSupplierID.Text);
        InSupplier.SupplierName = txtSupplierName.Text;
        InSupplier.Email = txtEmail.Text;
        InSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        InSupplier.ContactNumber = txtContactNumber.Text;
        InSupplier.Address = txtAddress.Text;
        InSupplier.OngoingContract = chkOngoingContract.Checked;

        //store the address in the session object
        Session["InSupplier"] = InSupplier;
        //navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the Supplier class
        clsSupplier InSupplier = new clsSupplier();
        //variable to store the primary key
        int SupplierID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        //find the record
        Found = InSupplier.Find(SupplierID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplierName.Text = InSupplier.SupplierName;
            txtEmail.Text = InSupplier.Email;
            txtDateAdded.Text = InSupplier.DateAdded.ToString();
            txtContactNumber.Text = InSupplier.ContactNumber;
            txtAddress.Text = InSupplier.Address;
            chkOngoingContract.Checked = InSupplier.OngoingContract;

        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}