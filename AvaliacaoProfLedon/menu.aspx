<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="AvaliacaoProfLedon.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="styles.css" rel="stylesheet" />
    <title>Banco de dados</title>
</head>
<body>
    <div>
        <div class="wrapper fadeInDown">
            <form id="formContent" runat="server">
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Bem vindo: "></asp:Label>
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="167px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="323px">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                    <br />
                    <asp:Button ID="btnListar" runat="server" OnClick="btnListar_Click" Text="Lista geral de produtos" />

                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sair" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
