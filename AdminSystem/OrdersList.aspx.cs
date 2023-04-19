using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 orderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            if (orderID != -1)
            {
                DisplayOrders();
            }

        }
        
    }

    private void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "orderID";
        lstOrderList.DataTextField = "customerID";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["orderID"] = -1;
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 orderID;
        if (lstOrderList.SelectedIndex != -1)
        {
            orderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["orderID"] = orderID;
            Response.Redirect("OrdersDataEntry.aspx");
        } else
        {
            lblError.Text = "Please select a record from the list to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 orderID;
        if (lstOrderList.SelectedIndex != -1){
            orderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["orderID"] = orderID;
            Response.Redirect("OrdersConfirmDelete.aspx");
        } else
        {
            lblError.Text = "Please select a record to delete from the list.";
        }
    }
}