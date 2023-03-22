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
        InSupplier.ID = Convert.ToInt32(txtSupplierID);
        InSupplier.SupplierName = txtSupplierName.Text;
        InSupplier.Email = txtEmail.Text;
        InSupplier.DateAdded = Convert.ToDateTime(txtDateAdded);
        InSupplier.ContactNumber = txtContactNumber.Text;
        InSupplier.Address = txtAddress.Text;
        InSupplier.OngoingContract = Convert.ToBoolean(chkOngoingContract);

        //store the address in the session object
        Session["InSupplier"] = InSupplier;
        //navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }
}