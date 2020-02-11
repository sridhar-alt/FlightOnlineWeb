<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewFlight.aspx.cs" Inherits="OnlineFlightBookingWeb.ViewFlight" %>
<asp:Content ID="flightBody" ContentPlaceHolderID="masterBody" runat="server">
    <asp:GridView ID="idFlightView" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="flightId" HeaderText="Flight Id" />
            <asp:BoundField DataField="flightName" HeaderText="Flight Name" />
            <asp:BoundField DataField="flightNumber" HeaderText="Flight Number" />
        </Columns>
    </asp:GridView>
</asp:Content>
