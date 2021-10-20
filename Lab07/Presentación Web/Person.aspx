<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="Presentación_Web.WebForm1" %>
<link href="Presentación/Content/bootstrap.min.css" rel="stylesheet" />

<link href="Content/bootstrap.min.css" rel="stylesheet" />
<script src="Scripts/jquery-3.4.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Presentación Web</title>
</head>
<body>
    <div class="container">
        <nav class="navbar navbar-dark bg-info">
            <h2 class="text-center"><strong>Lista de Usuarios - ASP.NET Web</strong></h2>
        </nav>     
    <form id="form1" runat="server">
        
            <asp:GridView ID="dgDatos" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" CssClass="table">
                <AlternatingRowStyle BackColor="White" CssClass="info" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" CssClass="dark" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        
    </form>
        </div>
</body>
</html>
