<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Orderinfo.aspx.cs" Inherits="DemoWeb.Orderinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 71px;
        }
        .auto-style8 {
            width: 56px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FormView" runat="server" OnPageIndexChanging="FView_PageIndexChanging" AllowPaging="true">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td>OrderId</td>
                    <td class="auto-style8">OrderDesc</td>
                    <td class="auto-style7">TotalCost</td>
                    <td>DiscountAmt</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("OrderId") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("OrderDesc") %>'></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("TotalCost") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("TotalDiscount") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
    <asp:GridView ID="GridView" runat="server" AllowPaging="True"  PageSize="6" OnPageIndexChanging="GridView_PageIndexChanging">
    </asp:GridView>
    <asp:DetailsView ID="DetailsView" runat="server" AllowPaging="True" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging" Width="125px">
    </asp:DetailsView>
</asp:Content>
