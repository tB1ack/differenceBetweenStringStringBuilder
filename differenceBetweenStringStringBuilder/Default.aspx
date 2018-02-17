<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="differenceBetweenStringStringBuilder.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="stringButton" runat="server" OnClick="stringButton_Click" Text="String" />
            <br />
            <br />
            <asp:Button ID="stringBuilderButton" runat="server" OnClick="stringBuilderButton_Click" Text="String Builder" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
