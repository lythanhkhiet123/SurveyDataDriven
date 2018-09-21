<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="TestSurvay.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <div style="margin-left: auto; margin-right: auto; text-align: center;background-color:orange;height:100px">
            <asp:Label ID="Label2" runat="server" Font-Size="Larger" style="justify-content: center;" Text="AIT Research Survey"></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="Menu Page"></asp:Label>
        <br />
        <br />
        <br />
    
        <asp:Button ID="Button1" runat="server" Text="Register" Font-Size="Larger" Height="79px" OnClick="Button1_Click" Width="180px" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Login" Font-Size="Larger" Height="127px" OnClick="Button2_Click" Width="170px" />
    
    </div>
    </form>
</body>
</html>
