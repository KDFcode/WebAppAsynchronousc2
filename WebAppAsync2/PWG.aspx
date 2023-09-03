<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PWG.aspx.cs" Inherits="WebAppAsync2.PWG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="WidgetGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync2.Models.Widget"></asp:GridView>
        <asp:GridView ID="ProductGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync2.Models.Product"></asp:GridView>
        <asp:GridView ID="GizmoGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync2.Models.Gizmo"></asp:GridView>
        <br />
        <asp:Label ID="ElapsedTimeLabel" runat="server" Text="Label"></asp:Label>
    </div>
                <br />
        <a id="A1" runat="server" href="~/">Home</a>
    </form>
</body>
</html>

</asp:Content>
