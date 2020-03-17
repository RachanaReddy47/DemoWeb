<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session Variable.aspx.cs" Inherits="DemoWeb.Session_Variable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table>
        <tr>
            <td>Session variable</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Application Variable</td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
    
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Width="130px" />
                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
