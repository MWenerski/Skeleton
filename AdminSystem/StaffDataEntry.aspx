<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 549px">
    <form id="form1" runat="server">
        <div style="height: 586px">
            <asp:TextBox ID="txtStaffPhoneNumber" runat="server" style="z-index: 1; left: 146px; top: 104px; position: absolute">Enter text here</asp:TextBox>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 146px; top: 65px; position: absolute">Enter text here</asp:TextBox>
            <asp:Label ID="lblHoursWorked" runat="server" style="z-index: 1; left: 9px; top: 144px; position: absolute; height: 19px; width: 121px; right: 1450px;" Text="Hours Worked"></asp:Label>
            <asp:TextBox ID="txtHoursWorked" runat="server"  style="z-index: 1; top: 138px; position: absolute; left: 147px">Enter text here</asp:TextBox>
            <asp:Label ID="lblHourlyWage" runat="server" style="z-index: 1; left: 13px; top: 177px; position: absolute" Text="Hourly Wage" width="121px"></asp:Label>
            <asp:TextBox ID="txtHourlyWage" runat="server" style="z-index: 1; left: 148px; top: 177px; position: absolute">Enter text here</asp:TextBox>
            <asp:CheckBox ID="chckAvailableToWork" runat="server" Checked="True" style="z-index: 1; left: 16px; top: 208px; position: absolute" Text="Available To work?" width="121px" />
            <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 168px; top: 270px; position: absolute" Text="Date Joined" width="72px"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 460px; position: absolute" Text=""></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 28px; top: 499px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 100px; top: 497px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 344px; top: 20px; position: absolute" Text="Find" />
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 145px; top: 25px; position: absolute">Enter text here</asp:TextBox>
            <asp:Label ID="lblSttaffId" runat="server" style="z-index: 1; left: 20px; top: 25px; position: absolute; width: 66px;" Text="Staff Id"></asp:Label>
            <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 18px; top: 327px; position: absolute"></asp:Label>
        </div>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 12px; top: 75px; position: absolute; width: 121px;" Text="Full Name:"></asp:Label>
        <asp:Label ID="lblStaffPhoneNumber" runat="server" style="z-index: 1; left: 13px; top: 108px; position: absolute; height: 15px" Text="Phone Number" width="121px"></asp:Label>
        <asp:Calendar ID="cldrDateJoined" runat="server" style="z-index: 1; left: 271px; top: 267px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
