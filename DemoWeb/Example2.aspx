<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Example2.aspx.cs" Inherits="DemoWeb.Example2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="y" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
    <tr>
        <td>
        <asp:RadioButton runat="server" GroupName="G1" Text="Joining Date" ID="rdbHiredate" OnCheckedChanged="rdbHiredate_CheckedChanged" AutoPostBack="True" />
        </td>
        <td>
            <asp:TextBox ID="txtStart" runat="server" TextMode="Date"></asp:TextBox>
            and
            <asp:TextBox ID="txtEnd" runat="server" TextMode="Date"></asp:TextBox>
        </td></tr>
    <tr><td>
        <asp:RadioButton ID="rdbDeptno" runat="server" GroupName="G1" Text="Deptno" AutoPostBack="True" OnCheckedChanged="rdbDeptno_CheckedChanged" />
        </td><td>
            <asp:DropDownList ID="ddlDeptNo" runat="server" AppendDataBoundItems="True">
                <asp:ListItem Value="-1">Select</asp:ListItem>
            </asp:DropDownList>
        </td></tr>

         <tr>
             <td>
                 <asp:Button ID="btnExtract" runat="server" Text="Extract" Width="128px" OnClick="btnExtract_Click" />
             </td>
             
         </tr>
         
         <asp:GridView ID="gvData" runat="server"></asp:GridView>

</table>
</asp:Content>
