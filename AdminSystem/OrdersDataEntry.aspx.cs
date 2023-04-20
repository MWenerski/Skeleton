﻿using System;
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //for some reason, btnCancel onClick redirects to the method at the bottom of this page
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
        Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
        if (Error == "")
        {
            try { 
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            AnOrder.OrderDate = Convert.ToDateTime(DateAdded);
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            AnOrder.GamePrice = Convert.ToDouble(GamePrice);
            AnOrder.OrderPrice = Convert.ToDouble(OrderPrice);
            AnOrder.TotalPayable = Convert.ToDouble(TotalPayable);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.GameName = GameName;
            AnOrder.InStock = chkInStock.Checked;
            AnOrder.OrderlineId = Convert.ToInt32(OrderID);
            clsOrderCollection OrdersList = new clsOrderCollection();
            {
                OrdersList.ThisOrder = AnOrder;
                OrdersList.Add();
            }
            Response.Redirect("OrdersList.aspx");
            }
            catch
            {
                lblError.Text = "Your order ID already exists in the database.";
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
            string Quantity = txtGameQuantity.Text;
            string GamePrice = txtGamePrice.Text;
            string OrderPrice = txtOrderPrice.Text;
            string TotalPayable = txtTotalPaid.Text;
            string OrderID = txtOrderID.Text;
            string CustomerID = txtCustomerID.Text;
            string GameName = txtGameName.Text;
            string Error = "";
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            if (Error == "")
            {
                try
                {
                    AnOrder.OrderID = Convert.ToInt32(OrderID);
                    AnOrder.OrderDate = Convert.ToDateTime(DateAdded);
                    AnOrder.Quantity = Convert.ToInt32(Quantity);
                    AnOrder.GamePrice = Convert.ToDouble(GamePrice);
                    AnOrder.OrderPrice = Convert.ToDouble(OrderPrice);
                    AnOrder.TotalPayable = Convert.ToDouble(TotalPayable);
                    AnOrder.CustomerID = Convert.ToInt32(CustomerID);
                    AnOrder.GameName = GameName;
                    AnOrder.InStock = chkInStock.Checked;
                    AnOrder.OrderlineId = Convert.ToInt32(OrderID);
                    clsOrderCollection OrdersList = new clsOrderCollection();
                    if (OrdersList.ThisOrder.Find(Convert.ToInt32(OrderID)))
                    {
                        OrdersList.ThisOrder = AnOrder;
                        OrdersList.Update();
                        Response.Redirect("OrdersList.aspx");
                    }
                    else
                        lblError.Text = "Your order ID doesn't exist in the database.";
                } catch
                {
                    lblError.Text = "Your order ID doesn't exist in the database.";
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
            lblError.Text = "Non-numeric value input, so order ID cannot be found.";
        }

        if (Found == true)
        {
            txtCustomerID.Text = AnOrder.OrderID.ToString();
            txtGameName.Text = AnOrder.GameName.ToString();
            txtGameQuantity.Text = AnOrder.Quantity.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtOrderID.Text = AnOrder.OrderID.ToString();
            txtOrderPrice.Text = AnOrder.OrderPrice.ToString();
            txtTotalPaid.Text = AnOrder.TotalPayable.ToString();
            txtGamePrice.Text = AnOrder.GamePrice.ToString();
        }
        else
        {
            txtCustomerID.Text = "";
            txtGameName.Text = "";
            txtGamePrice.Text = "";
            txtGameQuantity.Text = "";
            txtOrderDate.Text = "";
            txtOrderID.Text = "";
            txtOrderPrice.Text = "";
            txtTotalPaid.Text = "";
            lblError.Text = "Note: if the orderID only exists in one table, these boxes may not be autofilled.";
        }
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        txtCustomerID.Text = "";
        txtGameName.Text = "";
        txtGamePrice.Text = "";
        txtGameQuantity.Text = "";
        txtOrderDate.Text = "";
        txtOrderID.Text = "";
        txtOrderPrice.Text = "";
        txtTotalPaid.Text = "";
    }
}