<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Survay.aspx.cs" Inherits="TestSurvay.Survay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <div style="margin-left: auto; margin-right: auto; text-align: center;background-color:orange;height:100px">
            <asp:Label ID="Label2" runat="server" style="justify-content: center;" Text="AIT Research Survey" Font-Size="Larger"></asp:Label>
        </div>
        <div align="center">
        <br />
        <br />
        <asp:Label ID="QuestionText" runat="server" Font-Size="Larger"></asp:Label>
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
        <br />
        <br />
        <br />
        <div align="right">
        <asp:ImageButton ID="ImageButton1" runat="server" Height="94px" ImageUrl="~/Image/Untitled-1.png" OnClick="ImageButton1_Click" Width="167px" />
        </div>
            <br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
