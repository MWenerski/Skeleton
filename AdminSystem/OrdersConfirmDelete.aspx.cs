using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 orderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        orderID = Convert.ToInt32(Session["orderID"]);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //btnYes
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ThisOrder.Find(orderID);
        Orders.Delete();
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}