<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QSEx4.aspx.cs" Inherits="DemoWeb.QSEx5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <script lang="Javascript" type="text/javascript">
      function func()
      {
          window.open('QSEx5.aspx?A=10&B=20');
      }
        </script>
    <title>
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" Onclientclick="func();"/>
        </div>
    </form>
</body>
</html>
