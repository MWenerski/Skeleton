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
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder) Session["AnOrder"];
        Response.Write(AnOrder.CustomerID);
        Response.Write("<br />");
        Response.Write(AnOrder.OrderID);
        Response.Write("<br />");
        Response.Write(AnOrder.OrderDate);
        Response.Write("<br />");
        Response.Write(AnOrder.TotalPayable);
        Response.Write("<br />");
        Response.Write(AnOrder.Quantity);
        Response.Write("<br />");
        Response.Write(AnOrder.TotalPrice);
        Response.Write("<br />");
        Response.Write(AnOrder.GamePrice);
        Response.Write("<br />");
    }
}