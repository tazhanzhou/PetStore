<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BrowserInfo.aspx.cs" Inherits="PetStore.BrowserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="This form inside" ForeColor="Green" Font-Bold="true"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>

        <div>
            <asp:Label ID="Label4" runat="server" Text="This form outside" ForeColor="Green" Font-Bold="true"></asp:Label>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
