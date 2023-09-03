<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GizmosAsync.aspx.cs" Inherits="WebAppAsync2.GizmosAsync" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title>Gizmos Async</title>
</head>
<body>
    <form id="form1" >
        <h1>Gizmos Async</h1>
    <div>
        <asp:GridView ID="GizmosGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync2.Models.Gizmo"></asp:GridView>
        <br />
           <br />
        <a id="A1"  href="~/">Home</a>
    </div>
    </form>
</body>
</html>

</asp:Content>
