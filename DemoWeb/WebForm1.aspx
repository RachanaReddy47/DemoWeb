<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="Javascript" type="text/Javascript">
        function Validate()
        {
            var Empno = document.getElementById("txtEmpno").value;
            var Ename = document.getElementById("txtEname").value;
            var Job = document.getElementById("txtJob").value;
            var Manager = document.getElementById("txtManager").value;
            var Hiredate= document.getElementById("txtHiredate").value;
            var Sal= document.getElementById("txtSal").value;
            var Commision = document.getElementById("txtCommision").value;
            var Deptno= document.getElementById("txtDeptno").value;
            if (Empno.length != 0 && Ename.length != 0 && Job.length != 0 && Manager.length != 0 && Hiredate.length != 0 && Sal.length != 0 && Commision.length != 0 && Deptno.length != 0)
                return true;
            else
                alert("Enter all details");
            return false;
        }

    </script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 298px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 592px" >
                <tr>
                    <td class="auto-style1">Employee No</td>
                    <td>
                        <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Employee Name</td>
                    <td>
                        <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Job</td>
                    <td>
                        <asp:TextBox ID="txtJob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Manager Id</td>
                    <td>
                        <asp:TextBox ID="txtManager" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Hiredate</td>
                    <td>
                        <asp:TextBox ID="txtHiredate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Sal</td>
                    <td>
                        <asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Commision</td>
                    <td>
                        <asp:TextBox ID="txtCommision" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Deptno</td>
                    <td>
                        <asp:TextBox ID="txtDeptno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnSubmit" runat="server" Text="Button" OnClientClick="return Validate();" OnClick="btnSubmit_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
