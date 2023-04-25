<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 135px; top: 340px; position: absolute" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 73px; top: 340px; position: absolute" Text="Edit" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 340px; position: absolute" Text="Add" />
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 459px; position: absolute"></asp:Label>
        <asp:Label ID="lblNameFilter" runat="server" style="z-index: 1; left: 17px; top: 379px; position: absolute" Text="Ente a name:"></asp:Label>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 15px; top: 36px; position: absolute; height: 288px; width: 267px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:TextBox ID="txtFilterName" runat="server" style="z-index: 1; left: 108px; top: 380px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 16px; top: 411px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 87px; top: 411px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
