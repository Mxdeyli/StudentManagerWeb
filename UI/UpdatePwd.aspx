<%@ Page Title="" Language="C#" MasterPageFile="~/DaoHang.Master" AutoEventWireup="true" CodeBehind="UpdatePwd.aspx.cs" Inherits="UI.UpdatePwd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 56px;
    }
    .td1 {
    text-align:right
    }
    tr {
    
    border:solid 2px }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br/>
    <br/>
    <table style="width: 400px;margin-left:auto;margin-right:auto;background-color:gray">
        <tr>
            <td colspan="2" style="text-align:center;font-size:larger" class="auto-style1">修改密码</td>
            
        </tr>
        <tr>
            <td class="td1">原始密码：</td>
            <td>
                <asp:TextBox ID="txt_oldpwd" runat="server"></asp:TextBox></td>

        </tr>
        <tr>
            <td class="td1">新密码：</td>
            <td>
                <asp:TextBox ID="txt_newpwd" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
    <td class="td1">重复密码：</td>
    <td>
        <asp:TextBox ID="txt_again_newpwd" runat="server"></asp:TextBox></td>
</tr>
        <tr style="text-align:center">
    <td >
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click"/></td>
    <td >
        <asp:Button ID="Button2" runat="server" Text="清空" /></td>
</tr>
    </table>
</asp:Content>
