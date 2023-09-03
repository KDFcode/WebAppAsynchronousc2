<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GizmosCancelAsync.aspx.cs" Inherits="WebAppAsync2.GizmosCancelAsync" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:GridView ID="GizmosGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync2.Models.Gizmos"></asp:GridView>
        <br />
          </div>
                <br />
        <a id="A1" runat="server" href="~/">Home</a>
    </form>
</body>
</html>

</asp:Content>
