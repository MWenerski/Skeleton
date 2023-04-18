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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string DateAdded = txtOrderDate.Text;
        string Quantity = txtGameQuantity.Text;
        string GamePrice = txtGamePrice.Text;
        string OrderPrice = txtOrderPrice.Text;
        string TotalPayable = txtTotalPaid.Text;
        string OrderID = txtOrderID.Text;
        string CustomerID = txtCustomerID.Text;
        string GameName = txtGameName.Text;
        string Error = "";
        Error = AnOrder.Valid(DateAdded, Quantity, GamePrice,  OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
        if (Error == "")
        {
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            AnOrder.GamePrice = Convert.ToDouble(GamePrice);
            AnOrder.OrderPrice = Convert.ToDouble(OrderPrice);
            AnOrder.TotalPayable = Convert.ToDouble(TotalPayable);
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.GameName = GameName;
            Response.Write("OrdersViewer.aspx");
        } else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if (Found == true)
        {
            txtCustomerID.Text = AnOrder.OrderID.ToString();
            txtGameName.Text = AnOrder.GameName.ToString();
            txtGameQuantity.Text = AnOrder.Quantity.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtOrderID.Text = AnOrder.OrderID.ToString();
            txtOrderPrice.Text = AnOrder.OrderPrice.ToString();
            txtTotalPaid.Text = AnOrder.TotalPayable.ToString();
                }
    }
}