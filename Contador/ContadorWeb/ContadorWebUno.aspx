<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContadorWebUno.aspx.cs" Inherits="ContadorWeb.ContadorWebUno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtAumentar" runat="server"></asp:TextBox>
            <asp:Button ID="btnAumentar" runat="server" Text="Aumentar" OnClick="btnAumentar_Click" />
        </div>
    </form>
</body>
</html>
