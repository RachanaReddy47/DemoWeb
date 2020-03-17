<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DemoWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/LoginValidations.js"></script>
    
    <style type="text/css">
        .auto-style6 {
            width: 157px;
        }
    </style>
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
            <td class="auto-style6"> <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" OnClientClick="return Validate();"/></td>
        </tr>
    </table>
</asp:Content>
