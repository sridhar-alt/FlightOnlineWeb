<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="OnlineFlightBookingWeb.Register" MasterPageFile="~/MasterPage.Master"%>
<asp:Content ID="content1" ContentPlaceHolderID="masterBody" runat="server">
        <table>
             <tr>
                <td>Name</td>
                <td><asp:TextBox runat="server" type="text" required="required" id="txtName" placeholder="Enter Name"/></td>
                <td>
                <asp:RequiredFieldValidator ID="validateName" runat="server" ControlToValidate="txtName" ErrorMessage="Name required" Style="color: red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="regularValidateName" runat="server" ControlToValidate="txtName" ErrorMessage="Enter valid name" Style="color: red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                </td>
             </tr>
            <tr>
                <td>Mobile Number</td>
                <td><asp:TextBox runat="server" required="required" id="txtNumber" placeholder="Enter Mobile Number"/> </td>
                <td>
                        <asp:RequiredFieldValidator ID="validateMobileNumber" runat="server" ControlToValidate="txtNumber" ErrorMessage="Mobile number required" Style="color: red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regularValidateMobileNumber" runat="server" ControlToValidate="txtNumber" ErrorMessage="Enter valid mobile number" Style="color: red" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Date Of Birth</td>
                <td><asp:TextBox runat="server" type="date" required="required" id="txtDob" placeholder="Enter Date Of Birth"/></td>
                <td>
                    <asp:RequiredFieldValidator ID="validateDob" runat="server" ControlToValidate="txtDob" ErrorMessage="Date OF Birth required" Style="color: red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>mail</td>
                <td><asp:TextBox runat="server" type="text" required="required" id="txtMail" placeholder="Enter Mail"/></td>
                <td>
                    <asp:RequiredFieldValidator ID="validateMail" runat="server" ControlToValidate="txtMail" ErrorMessage="Mail id required" Style="color: red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regularValidateMailId" runat="server" ControlToValidate="txtMail" ErrorMessage="Enter valid mail id" Style="color: red" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"></asp:RegularExpressionValidator>
                </td>
              </tr>
            <tr>
                <td>Address</td>
                <td><asp:TextBox runat="server" type="text" required="required" id="txtAddress" placeholder="Enter Address"/></td>
                <td>
                    <asp:RequiredFieldValidator ID="validateAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address is required" Style="color: red"></asp:RequiredFieldValidator>
                </td>
              </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButton runat="server" Text="Male" required="required" id="txtMale" GroupName="Gender"/>
                    <asp:RadioButton runat="server" Text="Female" required="required" id="txtFemale" GroupName="Gender"/>
                </td>
              </tr>
            <tr>
                <td>password</td>
                <td><asp:TextBox runat="server" TextMode="Password" required="required" id="txtPassword" placeholder="Enter Password"/></td>
                <td>
                    <asp:RequiredFieldValidator ID="validatePassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password required" style="color:red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" placeholder="Re-enter Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="regiularConfirmPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Confirm password required" style="color:red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ID="validateConfirmPassword" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ErrorMessage="Password and Confirm password must be same"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Button ID="Reg" runat="server" OnClick="adduser" align="center" text="Register" /></td>
            </tr>
         </table>
</asp:Content>