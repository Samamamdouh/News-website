<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="settings.aspx.cs" Inherits="WCM.settings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:LinkButton ID="link_register" runat="server" OnClick="link_register_Click">Add User</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="link_article" runat="server" OnClick="link_article_Click">Add Articles</asp:LinkButton>
&nbsp;&nbsp;
        <asp:LinkButton ID="link_edit" runat="server" OnClick="link_edit_Click">Edit Articles</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
