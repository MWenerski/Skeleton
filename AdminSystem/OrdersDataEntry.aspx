<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="91px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Order ID" width="91px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Order Date" width="91px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Total Paid" width="91px"></asp:Label>
            <asp:TextBox ID="txtTotalPaid" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Game Quantity"></asp:Label>
            <asp:TextBox ID="txtGameQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Order Price" width="91px"></asp:Label>
            <asp:TextBox ID="txtOrderPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="Game Price" width="91px"></asp:Label>
            <asp:TextBox ID="txtGamePrice" runat="server"></asp:TextBox>
        </p>
            <asp:Label ID="lblGameName" runat="server" Text="Game Name" width="91px"></asp:Label>
            <asp:TextBox ID="txtGameName" runat="server"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server" Text="In Stock?" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
