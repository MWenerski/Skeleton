<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 87px;
        }
        #default {
            height: 290px;
        }
    </style>
</head>
<body style="height: 373px">
    This is the customer entry page
    <form id="default" runat="server">
        <div style="height: 2px">
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
        <br />
        <asp:TextBox ID="TxtCustomerID" runat="server" Width="536px"></asp:TextBox>
        <br />
        <asp:Label ID="lblUsername" runat="server" Text="Username" width="113px"></asp:Label>
        <br />
&nbsp;<asp:TextBox ID="TxtUsername" runat="server" Width="459px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password" width="113px"></asp:Label>
        <br />
        <asp:TextBox ID="txtPassword" runat="server" Width="407px"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="113px"></asp:Label>
        <br />
        <asp:TextBox ID="txtEmail" runat="server" Width="429px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded" width="113px"></asp:Label>
        <br />
        <asp:TextBox ID="txtDateAdded" runat="server" Width="387px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkVerified" runat="server" Text="Verifed" />
        <br />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
