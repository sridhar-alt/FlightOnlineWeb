<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewFlight.aspx.cs" Inherits="FlightOnlineWeb.ViewFlight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="idFlightView" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="flightId" HeaderText="Flight Id" />
            <asp:BoundField DataField="flightName" HeaderText="Flight Name" />
            <asp:BoundField DataField="flightNumber" HeaderText="Flight Number" />
        </Columns>
    </asp:GridView>
</asp:Content>
