<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 262px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID" width="102px"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" width="102px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="102px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="102px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number"></asp:Label>
        <asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address" width="102px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        
       
        <asp:CheckBox ID="chkOngoingContract" runat="server" style="z-index: 1; left: 10px; top: 192px; position: absolute" Text="Ongoing Contract" />
       
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 224px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 6px; top: 247px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 51px; top: 247px; position: absolute" Text="Cancel" />
       
    </form>
</body>
</html>
