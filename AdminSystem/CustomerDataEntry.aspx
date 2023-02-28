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
            height: 271px;
        }
    </style>
</head>
<body style="height: 332px">
    This is the customer entry page
    <form id="default" runat="server">
        <div style="height: 2px">
        </div>
        <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number"></asp:Label>
        <br />
        <asp:TextBox ID="TxtAddressNo" runat="server" Width="343px"></asp:TextBox>
        <br />
        <asp:Label ID="lblUsername" runat="server" Text="Username" width="113px"></asp:Label>
&nbsp;<asp:TextBox ID="TxtUsername" runat="server" Width="389px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password" width="113px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" Width="407px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="113px"></asp:Label>
        <br />
        <asp:TextBox ID="txtEmail" runat="server" Width="429px"></asp:TextBox>
        <asp:Label ID="lblDateCreated" runat="server" Text="DateCreated" width="113px"></asp:Label>
        <asp:TextBox ID="txtDateCreated" runat="server" Width="387px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkVerified" runat="server" Text="Verifed" />
        <br />
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
