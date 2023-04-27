using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        SupplierID = Convert.ToInt32(Session["ID"]);
        if (IsPostBack == false)
        {
            if (SupplierID != -1)
            {
                //display the current data for the record
                DisplaySupplier();
            }
        }

    }
    void DisplaySupplier()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ThisSupplier.Find(SupplierID);
        //display the datafor this record
        txtSupplierID.Text = Suppliers.ThisSupplier.ID.ToString();
        txtSupplierName.Text = Suppliers.ThisSupplier.SupplierName;
        txtEmail.Text = Suppliers.ThisSupplier.Email;
        txtDateAdded.Text = Suppliers.ThisSupplier.DateAdded.ToString();
        txtContactNumber.Text = Suppliers.ThisSupplier.ContactNumber;
        txtAddress.Text = Suppliers.ThisSupplier.Address;
        chkOngoingContract.Checked = Suppliers.ThisSupplier.OngoingContract;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier InSupplier = new clsSupplier();
        //capture the supplier name
        String SupplierName = txtSupplierName.Text;
        String Email = txtEmail.Text;
        String DateAdded = txtDateAdded.Text;
        String ContactNumber = txtContactNumber.Text;
        String Address = txtAddress.Text;
        String Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
        if (Error == "")
        {
            InSupplier.ID = SupplierID;
            InSupplier.SupplierName = SupplierName ;
            InSupplier.Email = Email;
            InSupplier.DateAdded = Convert.ToDateTime(DateAdded);
            InSupplier.ContactNumber = ContactNumber;
            InSupplier.Address = Address;
            InSupplier.OngoingContract = chkOngoingContract.Checked;
            //create a new instance of the supplier collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            //if this is a new record then add to the data
            if (SupplierID == -1)
            {
                //set thisSupplier property
                SupplierList.ThisSupplier = InSupplier;
                //add the new record
                SupplierList.Add();
                
            }
            else
            {
                //find the record to update
                SupplierList.ThisSupplier.Find(SupplierID);
                //set the This Supplier property
                SupplierList.ThisSupplier = InSupplier;
                //update the record
                SupplierList.Update();
            }
            //navigate to the viewer page
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }


       
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