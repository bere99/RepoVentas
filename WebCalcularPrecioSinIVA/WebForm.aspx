<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm.aspx.vb" Inherits="WebCalcularPrecioSinIVA.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            margin-bottom: 69px;
            height: 219px;
        }
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" contenteditable="true">
        <div contenteditable="true" draggable="true" itemscope="itemscope" style="height: 207px">
            <span class="auto-style1"><strong>Calcular IVA:</strong></span><br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp; Precio Total: <asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-bottom: -5px" Width="138px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp; Tipo de IVA: <asp:DropDownList ID="DropDownList1" runat="server" style="margin-bottom: -5px">
                <asp:ListItem Selected="True" Value="0,21">General</asp:ListItem>
                <asp:ListItem Value="0,12">Reducido</asp:ListItem>
                <asp:ListItem Value="0,04">Superreducido</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Calcular" />
            
            <br />
            <br />
            <asp:Label ID="LabelErrors" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Precio sin IVA: "></asp:Label>
            <asp:TextBox ID="PrecioSinIVA" runat="server" Height="16px" style="margin-bottom: -5px" Width="138px" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label  runat="server" Text="IVA a pagar: "></asp:Label>
            <asp:TextBox ID="IVAPagar" runat="server" Height="16px" style="margin-bottom: -5px" Width="138px" ReadOnly="True"></asp:TextBox>

        </div>
    </form>
</body>
</html>
