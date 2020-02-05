<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FlightOnlineWeb.MainPage" MasterPageFile="~/MasterPage.Master"%>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
    <tr>
        <td>Mobile Number</td>
        <td><asp:TextBox runat="server" type="text" id="txtmobile"/></td>
    </tr>
    <tr>
        <td>password</td>
        <td><asp:TextBox runat="server" type="text" id="txtpassword"/></td>
    </tr>
        <tr>
            <td><asp:Button ID="login" runat="server" OnClick="Login" Text="login" align="center"/></td>
            <td><asp:Button ID="signup" runat="server" OnClick="adduser" text="Register" align="center"/></td>
        </tr>
</table>
</asp:Content>