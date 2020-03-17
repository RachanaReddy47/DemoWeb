<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="UpdateAdo.aspx.cs" Inherits="DemoWeb.UpdateAdo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td>EmployeeNo</td>
        <td>
            <asp:TextBox ID="txtEmployeeNo" runat="server" ClientIDMode="Static" AutoPostBack="True" OnTextChanged="txtEmployeeNo_TextChanged"></asp:TextBox> </td>
    </tr>

    <tr>
        <td>EmployeeName</td>
        <td>
            <asp:TextBox ID="txtEmployeeName" runat="server" ClientIDMode="Static"></asp:TextBox> </td>
    </tr>

    <tr>
        <td>Job</td>
        <td>
            <asp:TextBox ID="txtJob" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>

    <tr>
        <td>MGR</td>
        <td>
            <asp:TextBox ID="txtMGR" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>

    <tr>
        <td>HireDate</td>
        <td>
            <asp:TextBox ID="txtHireDate" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>

    <tr>
        <td>Salary</td>
        <td>
            <asp:TextBox ID="txtSalary" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>

    <tr>
        <td>Commission</td>
        <td>
            <asp:TextBox ID="txtCommission" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>

    <tr>
        <td>DepartmentNo</td>
        <td>
            <asp:TextBox ID="txtDepartmentNo" runat="server" ClientIDMode="Static"></asp:TextBox></td>
    </tr>

        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Update_Click" Width="102px" OnClientClick="return Add();" /></td>
   
        <td>
            <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" Width="124px" /> </td>
   </tr>

    </table>
</asp:Content>
