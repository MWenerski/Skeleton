<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; right: 725px" Text="ID"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 41px; top: 12px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 20px" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 53px; top: 36px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 12px; top: 65px; position: absolute" Text="Label"></asp:Label>
    </form>
</body>
</html>
