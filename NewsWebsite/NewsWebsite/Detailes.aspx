<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detailes.aspx.cs" Inherits="NewsWebsite.Detailes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 141px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="detail" runat="server">

    </div>
    <hr/>
     <div id ="comments" runat="server">

         </div>
         <table style="width:100%;">
             <tr>
                 <td class="auto-style1">Name</td>
                 <td>
                     <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style1">Comment</td>
                 <td>
                     <asp:TextBox ID="txt_comment" runat="server" Height="73px" TextMode="MultiLine" Width="438px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td>
                     <asp:Button ID="btn_comment" runat="server" OnClick="btn_comment_Click" Text="Add comment" />
                 </td>
             </tr>
         </table>

    
</asp:Content>
