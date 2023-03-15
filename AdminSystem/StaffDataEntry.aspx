<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 421px">
    <form id="form1" runat="server">
        <div style="height: 586px">
            <asp:TextBox ID="txtStaffPhoneNumber" runat="server" style="z-index: 1; left: 146px; top: 49px; position: absolute">Enter text here</asp:TextBox>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 147px; top: 19px; position: absolute">Enter text here</asp:TextBox>
            <asp:Label ID="lblHoursWorked" runat="server" style="z-index: 1; left: 16px; top: 83px; position: absolute; height: 19px; width: 121px; right: 733px;" Text="Hour Worked"></asp:Label>
            <asp:TextBox ID="txtHoursWorked" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 81px; position: absolute; left: 149px">Enter text here</asp:TextBox>
            <asp:Label ID="lblHourlyWage" runat="server" style="z-index: 1; left: 19px; top: 115px; position: absolute" Text="Hourly Wage" width="121px"></asp:Label>
            <asp:TextBox ID="txtHourlyWage" runat="server" style="z-index: 1; left: 148px; top: 114px; position: absolute">Enter text here</asp:TextBox>
            <asp:CheckBox ID="chckAvailableToWork" runat="server" Checked="True" style="z-index: 1; left: 16px; top: 145px; position: absolute" Text="Available To work?" width="121px" />
            <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 19px; top: 190px; position: absolute" Text="Date Joined" width="72px"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 377px; position: absolute" Text=""></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 24px; top: 401px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 103px; top: 402px; position: absolute" Text="Cancel" />
        </div>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 12px; top: 17px; position: absolute; width: 121px;" Text="Full Name:"></asp:Label>
        <asp:Label ID="lblStaffPhoneNumber" runat="server" style="z-index: 1; left: 15px; top: 50px; position: absolute; height: 15px" Text="Phone Number" width="121px"></asp:Label>
        <asp:Calendar ID="cldrDateJoined" runat="server" style="z-index: 1; left: 150px; top: 186px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
