﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchPage.aspx.cs" Inherits="TestSurvay.searchPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div style="margin-left: auto; margin-right: auto; text-align: center;background-color:green;height:100px">
            <asp:Label ID="Label2" runat="server" Font-Size="Larger" style="justify-content: center;" Text="AIT Research Survey"></asp:Label>
        </div>
        <div align="center">
        <asp:Label ID="Label3" runat="server" Text="Search" Font-Size="Larger"></asp:Label>
        <br />
        
        First name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Last name<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="250px"></asp:TextBox>
            <br />
        <br />
            Age range&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Gender<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
                <asp:ListItem>&lt;18</asp:ListItem>
                <asp:ListItem>18-25</asp:ListItem>
                <asp:ListItem>26-32</asp:ListItem>
                <asp:ListItem>32&gt;</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" Width="250px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
            <br />
        <br />
        Address<br />
        <asp:TextBox ID="TextBox5" runat="server" Width="632px"></asp:TextBox>
&nbsp;<br />
            <br />
        Suburb&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; State<br />
        <asp:TextBox ID="TextBox7" runat="server" Width="250px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList3" runat="server" Width="250px">
                <asp:ListItem>VIC</asp:ListItem>
                <asp:ListItem>NSW</asp:ListItem>
                <asp:ListItem>Queensland</asp:ListItem>
                <asp:ListItem>NT</asp:ListItem>
                <asp:ListItem>SA</asp:ListItem>
                <asp:ListItem>Western Australia</asp:ListItem>
                <asp:ListItem>TAS</asp:ListItem>
                <asp:ListItem>ACT</asp:ListItem>
            </asp:DropDownList>
            <br />
        <br />
            Postcode&nbsp;<br />
        <asp:TextBox ID="TextBox9" runat="server" Width="632px"></asp:TextBox>
&nbsp;<br />
            <br />
        Email<br />
        <asp:TextBox ID="TextBox11" runat="server" Width="632px"></asp:TextBox>
&nbsp;<br />
            <br />
            Phone<br />
        <asp:TextBox ID="TextBox13" runat="server" Width="632px"></asp:TextBox>
&nbsp;<br />
            <br />
        Banks used<br />
        <asp:TextBox ID="TextBox15" runat="server" Width="632px"></asp:TextBox>
&nbsp;<br />
            <br />
        Banks services<br />
        <asp:TextBox ID="TextBox16" runat="server" Width="632px"></asp:TextBox>
&nbsp;<br />
            <br />
        Newspaper read<br />
        <asp:TextBox ID="TextBox17" runat="server" Width="632px"></asp:TextBox>
            <br />
            </div>
&nbsp;<br />
        <br />
&nbsp;<br />
           <div align="right">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="94px" ImageUrl="~/Image/Untitled-1.png" OnClick="ImageButton1_Click" Width="167px" />
        </div>
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>