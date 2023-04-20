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
        //Create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //Get the data from the session object
        aStaff = (clsStaff)Session["aStaff"];
        //Display the name on the page
        /**
        Response.Write(aStaff.name);
        Response.Write(aStaff.availableToWork);
        Response.Write(aStaff.dateStarted);
        Response.Write(aStaff.hourlyWage);
        Response.Write(aStaff.hoursWorked);
        Response.Write(aStaff.phoneNumber);
        */
    }
}