﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resultPage.aspx.cs" Inherits="TestSurvay.resultPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div align="center">
            <div style="margin-left: auto; margin-right: auto; text-align: center;background-color:green;height:100px">
                <asp:Label ID="Label2" runat="server" Font-Size="Larger" style="justify-content: center;" Text="AIT Research Survey"></asp:Label>
            </div>
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Result"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText ="ID" />
                    <asp:BoundField DataField="q_id" HeaderText ="q_id" />
                    <asp:BoundField DataField="anwer" HeaderText ="anwer" />
                    <asp:BoundField DataField="person_answer" HeaderText ="person_answer" />
                    <asp:BoundField DataField="respondent_ip" HeaderText ="respondent_ip" />
                    <asp:BoundField DataField="respondent_date" HeaderText ="respondent_date" />



                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>
    </div>
    </form>
</body>
</html>
