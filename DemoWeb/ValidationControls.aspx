<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="ValidationControls.aspx.cs" Inherits="DemoWeb.ValidationControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 393px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Empno
            </td>
            <td>
                <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox> 
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="CannotBeBlank" ControlToValidate="txtEmpno" ForeColor="Red" ValidateRequestMode="Disabled" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>Ename</td>
            <td>
                <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>

            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="CannotBeBlank" ControlToValidate="txtEname" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="CannotBeBlank" ControlToValidate="txtPassword" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>ConfirmPassword</td>
            <td><asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox></td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="CannotBeBlank" ControlToValidate="txtConfirm" Display="None"></asp:RequiredFieldValidator>
             <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Doesnot Match" ControlToCompare="txtPassword" ControlToValidate="txtConfirm" Display="None"></asp:CompareValidator>
            </td>
           
        </tr>

        <tr>
            <td>Salry</td>
            <td> <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td>
            <td class="auto-style6"><asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Salary between 10000and20000" ControlToValidate="txtSalary" MaximumValue="20000" MinimumValue="10000" Type="Double" Display="None"></asp:RangeValidator></td>
        </tr>

        <tr>
            <td>Pancard</td>
            <td>  <asp:TextBox ID="txtPancard" runat="server"></asp:TextBox></td>
            <td class="auto-style6"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid PancardNo" ControlToValidate="txtPancard" ValidationExpression="^[A-Z]{5}[0-9]{4}[A-Z]$" Display="None"></asp:RegularExpressionValidator></td>
        </tr>

        <tr>
            <td>DateOfBirth</td>
            <td><asp:TextBox ID="txtDOB" TextMode="Date" runat="server"></asp:TextBox></td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="CannotBeBlank" ControlToValidate="txtDOB" Display="None"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Age must be between 21-58" ControlToValidate="txtDOB" OnServerValidate="CustomValidator1_ServerValidate" Display="None"></asp:CustomValidator></td>
        </tr>

        <tr><td><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td></tr>
        
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
          
</asp:Content>
