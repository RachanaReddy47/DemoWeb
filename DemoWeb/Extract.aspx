<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Extract.aspx.cs" Inherits="DemoWeb.Extract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<h2>
    Enter the Deptno:<asp:DropDownList ID="ddlDeptno" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="ddlDeptno_SelectedIndexChanged" >
        <asp:ListItem Value="-1">Select</asp:ListItem>
    </asp:DropDownList>
    <asp:GridView ID="gvData" runat="server"></asp:GridView>
    <asp:Button runat="server" Text="Button" OnClick="Button1_Click" />
</h2>

</asp:Content>
