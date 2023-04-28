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
        clsStock AStock = new clsStock(); // ceate a new instance of clsStock
        if (txtGameID.Text == "")
        {
            lblError.Text = ("You need to input a valid game id");
        }
        else
        {

            AStock.GameID = Convert.ToInt32(txtGameID.Text); // capture the gameid
            AStock.GameName = txtGameName.Text;
            AStock.GamePrice = Convert.ToInt32(txtGamePrice.Text);
            AStock.AmountInStock = Convert.ToInt32(txtAmountInStock.Text);
            AStock.Genre = txtGenre.Text;
            AStock.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
            AStock.Supplier = txtSupplier.Text;

            if (Convert.ToInt32(txtAmountInStock.Text) < 1)
            {
                AStock.InStock = false;
            }

            Session["AStock"] = AStock; // store the gameid in the session object
            Response.Redirect("StockViewer.aspx"); // navigate to viewer page
        }

    }

    protected void chkInStock_CheckedChanged(object sender, EventArgs e)
    {

    }
}