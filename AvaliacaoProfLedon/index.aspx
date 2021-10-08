<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AvaliacaoProfLedon.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="styles.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <div>
        <div class="wrapper fadeInDown">
            <form id="formContent" runat="server" action="autentica.aspx">
                <div style="height: 833px">
                    <h2> Entrar </h2>
                    <asp:TextBox ID="nomeusuario" name="nomeusuario" runat="server" Width="175px" placeholder="Entrar com nome"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="senhausuario" name="senhausuario" runat="server" Width="175px" placeholder="Insira sua senha"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnSubmit" runat="server" Height="26px" OnClick="Button1_Click" Text="Entrar" Width="246px" />
                </div>
            </form>
         </div>
    </div>
</body>
</html>
