<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 23px">
            <asp:Label ID="lblGameID" runat="server" height="19px" style="z-index: 1; left: 10px; top: 15px; position: absolute; width: 94px" Text="GameID"></asp:Label>
&nbsp;<asp:TextBox ID="txtGameID" runat="server" height="22px" style="z-index: 1; top: 16px; position: absolute; width: 128px; left: 125px; bottom: 633px;" OnTextChanged="txtGameID_TextChanged" TextMode="Number"></asp:TextBox>
        </div>
        <p style="margin-left: 40px">
            <asp:Label ID="lblGameName" runat="server" height="19px" style="z-index: 1; left: 10px; top: 57px; position: absolute" Text="Game Name" width="94px"></asp:Label>
            <asp:TextBox ID="txtGameName" runat="server" height="22px" style="z-index: 1; left: 125px; top: 56px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblGamePrice" runat="server" height="19px" style="z-index: 1; left: 10px; top: 95px; position: absolute" Text="Game Price" width="94px"></asp:Label>
            <asp:TextBox ID="txtGamePrice" runat="server" height="22px" style="z-index: 1; left: 125px; top: 93px; position: absolute" width="128px" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAmountInStock" runat="server" height="19px" style="z-index: 1; left: 10px; top: 133px; position: absolute" Text="Amount In Stock" width="94px"></asp:Label>
            <asp:TextBox ID="txtAmountInStock" runat="server" height="22px" style="z-index: 1; left: 125px; top: 130px; position: absolute" width="128px" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblGenre" runat="server" height="19px" style="z-index: 1; left: 10px; top: 171px; position: absolute; bottom: 487px" Text="Genre" width="94px"></asp:Label>
            <asp:TextBox ID="txtGenre" runat="server" height="22px" style="z-index: 1; left: 125px; top: 170px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblReleaseDate" runat="server" height="19px" style="z-index: 1; left: 10px; top: 209px; position: absolute" Text="Release Date" width="94px"></asp:Label>
            <asp:TextBox ID="txtReleaseDate" runat="server" height="22px" style="z-index: 1; left: 125px; top: 208px; position: absolute" width="128px" TextMode="Date"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSupplier" runat="server" height="19px" style="z-index: 1; left: 10px; top: 247px; position: absolute" Text="Supplier" width="94px"></asp:Label>
            <asp:TextBox ID="txtSupplier" runat="server" height="22px" style="z-index: 1; left: 125px; top: 247px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 323px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 361px; position: absolute; right: 1172px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 50px; top: 361px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
