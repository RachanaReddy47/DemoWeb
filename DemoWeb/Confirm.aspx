<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="DemoWeb.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Empno</td>
            <td>
                <asp:Label ID="lblEmpno" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>Ename</td>
            <td>
                <asp:Label ID="lblEname" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

         <tr>
            <td>Job</td>
            <td>
                <asp:Label ID="lblJob" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

         <tr>
            <td>MGR</td>
            <td>
                <asp:Label ID="lblMGR" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

         <tr>
            <td>Hiredate</td>
            <td>
                <asp:Label ID="lblHiredate" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

         <tr>
            <td>Salary</td>
            <td>
                <asp:Label ID="lblSalary" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

         <tr>
            <td>Commision</td>
            <td>
                <asp:Label ID="lblCommision" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

         <tr>
            <td>Deptno</td>
            <td>
                <asp:Label ID="lblDeptno" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" />
            </td>
        </tr>
        
    </table>
</asp:Content>
