<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Survay.aspx.cs" Inherits="TestSurvay.Survay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="QuestionText" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
