<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-bottom: 0px">
        </div>
        <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are your sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 11px; top: 66px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; top: 66px; position: absolute; left: 71px; margin-bottom: 0px" Text="No" />
    </form>
</body>
</html>
