<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirm" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Yes" />
        <asp:Button ID="Button2" runat="server" Text="No" />
    </form>
</body>
</html>
