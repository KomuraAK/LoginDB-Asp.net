<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listar.aspx.cs" Inherits="AvaliacaoProfLedon.listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="styleList.css" rel="stylesheet" />
    <title>Lista geral de produtos</title>
</head>
<body>
    <div>
        <div class="wrapper fadeInDown">
            <form id="formContent" runat="server">
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Lista geral de produtos"></asp:Label>
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="523px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Retornar" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
