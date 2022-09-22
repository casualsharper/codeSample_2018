<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mailer.aspx.cs" Inherits="WebGUI2.Mailer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:Button ID="mailData" runat="server" Text="Mail Xml" OnClick="MailNews" />
            <asp:Button ID="back" runat="server" Text="Return" OnClick="BackToList" />
            <asp:GridView ID="loggerView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="Logs">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="RawXML" HeaderText="RawXML" SortExpression="RawXML" />
                    <asp:BoundField DataField="SendDate" HeaderText="SendDate" SortExpression="SendDate" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:ObjectDataSource ID="Logs" runat="server" SelectMethod="GetLogs" TypeName="Domain.ArticleContext"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
