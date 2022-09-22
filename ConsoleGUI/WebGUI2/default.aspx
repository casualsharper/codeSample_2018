<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebGUI2.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="fetchData" runat="server" Text="Refresh Headlines" OnClick="FetchNews" />
            <asp:Button ID="mailer" runat="server" Text="Mail Form" OnClick="SendNews" />
            <asp:GridView ID="articleView" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowPaging="True" PageSize="5"
                OnPageIndexChanging="articleView_PageIndexChanging" AutoGenerateColumns="False" DataSourceID="ArticleSource" OnSelectedIndexChanged="articleView_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    <asp:BoundField DataField="Authors" HeaderText="Authors" SortExpression="Authors" />
                    <asp:BoundField DataField="PublishDate" HeaderText="PublishDate" SortExpression="PublishDate" />
                    <asp:BoundField DataField="Summary" HeaderText="Summary" SortExpression="Summary" />
                    <asp:BoundField DataField="Url" HeaderText="Url" SortExpression="Url" Visible="False" />
                    <asp:HyperLinkField DataNavigateUrlFields="Url" HeaderText="Full Article" Target="_blank" Text="Link" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ArticleSource" runat="server" SelectMethod="GetArticles" TypeName="Domain.ArticleContext"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>