<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DogsList.aspx.cs" Inherits="PetStore.DogsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DogsList</title>
</head>
<body>
    <h3>Dogs List</h3>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                </Columns>

            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PetStoreDBConnectionString %>" SelectCommand="SELECT * FROM [Dogs]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
