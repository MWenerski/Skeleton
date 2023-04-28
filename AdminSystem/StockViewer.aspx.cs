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
        clsStock AStock = new clsStock(); // create new instance of clsStock
        AStock = (clsStock)Session["AStock"]; // Get the data from the session object


        Response.Write("<table>"); // create a table with all the responses so that i can see it clearly
        Response.Write("<tr><td>Game ID:</td><td>" + AStock.GameID + "</td></tr>"); // row for game id
        Response.Write("<tr><td>Game Name:</td><td>" + AStock.GameName + "</td></tr>"); // row for game name
        Response.Write("<tr><td>Game Price:</td><td>" + AStock.GamePrice + "</td></tr>"); // row for game price
        Response.Write("<tr><td>Amount in Stock:</td><td>" + AStock.AmountInStock + "</td></tr>"); // row for amount in stock
        Response.Write("<tr><td>Genre:</td><td>" + AStock.Genre + "</td></tr>"); // row for genre
        Response.Write("<tr><td>Release Date:</td><td>" + AStock.ReleaseDate + "</td></tr>"); // row for release date
        Response.Write("<tr><td>Supplier:</td><td>" + AStock.Supplier + "</td></tr>"); // row for supplier
        Response.Write("<tr><td>In Stock:</td><td>" + AStock.InStock + "</td></tr>"); // row for in stock
        Response.Write("</table>"); // close table

    }
}