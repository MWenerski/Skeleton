<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 637px">
            <asp:ListBox ID="lstCustomerList" runat="server" Height="620px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" Width="547px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
