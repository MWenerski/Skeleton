<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 73px; top: 340px; position: absolute" Text="Edit" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 340px; position: absolute" Text="Add" />
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 288px; width: 267px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 384px; position: absolute"></asp:Label>
    </form>
</body>
</html>
