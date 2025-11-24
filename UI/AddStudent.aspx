<%@ Page Title="" Language="C#" MasterPageFile="~/DaoHang.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="UI.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
     .td1 {
     text-align:center
     }
     table {
     
     margin-left:300px}
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br/><br/>
    <div>
    <table style="width: 70%;background-color:dimgray" border="1">
        <tr>
            <td colspan="4" style="text-align:center">添加信息</td>
        </tr>
        <tr>
            <td class="td1">学号：</td>
            <td>
                <asp:TextBox ID="txt_num" runat="server"></asp:TextBox></td>
            <td class="td1">姓名：</td>
            <td>
                <asp:TextBox ID="txt_name" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td1">班级：</td>
            <td>
                <asp:TextBox ID="txt_class" runat="server"></asp:TextBox></td>
            <td class="td1">专业：</td>
            <td>
                <asp:TextBox ID="txt_speciality" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
    <td class="td1">年龄：</td>
    <td>
        <asp:TextBox ID="txt_age" runat="server"></asp:TextBox></td>
    <td class="td1">电话：</td>
    <td>
        <asp:TextBox ID="txt_phone" runat="server"></asp:TextBox></td>
</tr>
        <tr>
    <td class="td1">性别：</td>
    <td colspan="3">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>女</asp:ListItem>
            <asp:ListItem>男</asp:ListItem>
        </asp:RadioButtonList>
    
</tr>
        <tr>
    <td colspan="4" style="text-align:center">
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" />&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="清空" OnClick="Button2_Click" style="height: 32px" /></td>
    
</tr>
    </table>
        </div>
</asp:Content>
