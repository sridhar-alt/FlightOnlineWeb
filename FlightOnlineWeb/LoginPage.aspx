<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="OnlineFlightBookingWeb.MainPage" MasterPageFile="~/MasterPage.Master"%>
<asp:Content ID="loginBody" ContentPlaceHolderID="masterBody" runat="server">
    <table>
    <tr>
        <td>Mobile Number</td>
        <td><asp:TextBox runat="server" type="text" id="txtMobile" placeholder="Enter Mobile Number"/></td>
        <%--<td>
             <asp:RequiredFieldValidator ID="validateLoginMobileNumber" runat="server" ControlToValidate="txtMobile" ErrorMessage="Mobile number required" Style="color: red"></asp:RequiredFieldValidator>
        </td>--%>                
    </tr>
    <tr>
        <td>Password</td>
        <td><asp:TextBox runat="server" type="text" id="txtPassword" placeholder="Enter Password"/></td>
        <%--<td>
            <asp:RequiredFieldValidator ID="validateLoginPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password required" style="color:red"></asp:RequiredFieldValidator>
        </td>--%>
    </tr>
    <tr>
        <td><asp:Button ID="login" runat="server" OnClick="Login" Text="login" margin="auto" Width="73px"/></td>
        <td><asp:Button ID="signup" runat="server" OnClick="adduser" text="Register" margin="auto" Width="73px"/></td>
    </tr>
</table>
</asp:Content>