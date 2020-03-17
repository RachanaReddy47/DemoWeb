<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="DemoWeb.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style6">Username</td>
            <td><asp:TextBox ID="txtUsername" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            <td></td>
        </tr>

        <tr>
            <td class="auto-style6">Password</td>
            <td>  <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ClientIDMode="Static"  ></asp:TextBox></td>
            <td></td>
        </tr>

        <tr>
            <td class="auto-style6"> 
                <asp:Label ID="LblMessage" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style6"> <asp:Button ID="btnLogin" runat="server" Text="Login"  Width="91px" OnClick="btnLogin_Click"/></td>
        </tr>
    </table>
</asp:Content>
