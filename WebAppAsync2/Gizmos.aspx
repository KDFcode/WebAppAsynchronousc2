<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gizmos.aspx.cs" Inherits="WebAppAsync2.Gizmos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section>
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sync Gizmos</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <asp:GridView ID="GizmoGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync2.Models.Gizmo"></asp:GridView>
 
    </div>
        <br />
        <a id="A1" runat="server" href="~/">Home</a>
    </form>
    <a href="PWGasync.aspx.cs">PWGasync.aspx.cs</a>
</body>
</html>
        </section>
</asp:Content>
