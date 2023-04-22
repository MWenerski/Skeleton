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
        if (Convert.ToBoolean(Session["editTrue"]) == true)
        {
            txtOrderID.Text = Convert.ToString(Session["orderID"]);
            Session["editTrue"] = false;
        }
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        txtCustomerID.Text = "";
        txtGameName.Text = "";
        txtOrderDate.Text = "";
        txtOrderID.Text = "";
        txtTotalPaid.Text = "";
        lblError.Text = "";
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string DateAdded = txtOrderDate.Text;
        string TotalPayable = txtTotalPaid.Text;
        string OrderID = txtOrderID.Text;
        string CustomerID = txtCustomerID.Text;
        string GameName = txtGameName.Text;
        string Error = "";
        Error = AnOrder.Valid(DateAdded, TotalPayable, OrderID, CustomerID, GameName);
        if (Error == "")
        {
            try { 
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            AnOrder.OrderDate = Convert.ToDateTime(DateAdded);
                AnOrder.GameName = GameName;
            AnOrder.TotalPayable = Convert.ToDouble(TotalPayable);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            
            clsOrderCollection OrdersList = new clsOrderCollection();
            {
                OrdersList.ThisOrder = AnOrder;
                OrdersList.Add();
            }
            Response.Redirect("OrdersList.aspx");
            }
            catch
            {
                lblError.Text = "Your order ID already exists in the database, but you could try updating it.";
            }
        }
        else
        {
            lblError.Text = Error;
        }
    }

    //BTN UPDATE BELOW
    protected void Button1_Click(object sender, EventArgs e)
    {
        {
            clsOrder AnOrder = new clsOrder();
            string DateAdded = txtOrderDate.Text;
            string TotalPayable = txtTotalPaid.Text;
            string OrderID = txtOrderID.Text;
            string CustomerID = txtCustomerID.Text;
            string GameName = txtGameName.Text;
            string Error = "";
            Error = AnOrder.Valid(DateAdded, TotalPayable, OrderID, CustomerID, GameName);
            if (Error == "")
            {
                try
                {
                    AnOrder.OrderID = Convert.ToInt32(OrderID);
                    AnOrder.OrderDate = Convert.ToDateTime(DateAdded);
                    AnOrder.GameName = GameName;
                    AnOrder.TotalPayable = Convert.ToDouble(TotalPayable);
                    AnOrder.CustomerID = Convert.ToInt32(CustomerID);

                    clsOrderCollection OrdersList = new clsOrderCollection();
                    if (OrdersList.ThisOrder.Find(Convert.ToInt32(OrderID)))
                    {
                        OrdersList.ThisOrder = AnOrder;
                        OrdersList.Update();
                        Response.Redirect("OrdersList.aspx");
                    }
                    else
                        lblError.Text = "Your order ID doesn't exist in the database, but you could try adding it.";
                } catch
                {
                    lblError.Text = "Catch exception.";
                }
            } else
            {
                lblError.Text = Error;
            }
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        try
        {
            OrderID = Convert.ToInt32(txtOrderID.Text);
            Found = AnOrder.Find(OrderID);
            lblError.Text = "";
        }
        catch
        {
            lblError.Text = "Exception cast.";
        }

        if (Found == true)
        {
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtOrderID.Text = AnOrder.OrderID.ToString();
            txtTotalPaid.Text = AnOrder.TotalPayable.ToString();
            txtGameName.Text = AnOrder.GameName;
        }
        else
        {
            txtCustomerID.Text = "";
            txtOrderDate.Text = "";
            txtOrderID.Text = "";
            txtTotalPaid.Text = "";
            txtGameName.Text = "";
            lblError.Text = "The OrderID wasn't found in tblOrder.";
        }
    }

    
}