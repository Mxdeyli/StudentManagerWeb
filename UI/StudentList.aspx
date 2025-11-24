<%@ Page Title="" Language="C#" MasterPageFile="~/DaoHang.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="UI.StudentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <br/>



    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" BackColor="#669999" Caption="学生信息表" CaptionAlign="Top" DataKeyNames="ID" OnRowDeleting="GridView1_RowDeleting"> 
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="编号" />
            <asp:BoundField DataField="Num" HeaderText="学号" />
            <asp:BoundField DataField="Name" HeaderText="姓名" />
            <asp:BoundField DataField="Sex" HeaderText="性别" />
            <asp:BoundField DataField="Age" HeaderText="年龄" />
            <asp:BoundField DataField="Class" HeaderText="班级" />
            <asp:BoundField DataField="Speciality" HeaderText="专业" />
            <asp:BoundField DataField="Phone" HeaderText="电话" />
            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="UpdateStudent.aspx?ID={0}" HeaderText="修改" Text="修改" />
        </Columns>

    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="添加学生" Height="21px" OnClick="Button1_Click" />
</asp:Content>
