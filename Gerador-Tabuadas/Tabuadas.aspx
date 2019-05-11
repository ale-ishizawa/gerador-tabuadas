<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabuadas.aspx.cs" Inherits="Gerador_Tabuadas.Tabuadas" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gerador de Tabuadas</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="container">
                <h1>Gerador de Tabuadas</h1>
                <h3 class="mt-4">Quantas tabuadas deseja gerar?</h3>
                <asp:TextBox ID="txtQtd" runat="server" TextMode="Number" CssClass=""></asp:TextBox>               
                <asp:Button ID="btnTables" runat="server" Text="Gerar Tabuadas" CssClass="btn btn-success" OnClick="btnTables_Click" />
                <br /><asp:RangeValidator ID="rvQtd" runat="server" ErrorMessage=" * O número de tabuadas deve ser entre 1 e 1000." 
                    MinimumValue="1" MaximumValue="1000" ControlToValidate="txtQtd" Type="Integer"></asp:RangeValidator>
            </div>
        </div>
        <div class="container">
            <asp:Literal ID="ltlHtml" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
