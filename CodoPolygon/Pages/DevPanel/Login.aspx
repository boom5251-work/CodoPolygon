<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CodoPolygon.Pages.DevPanel.Login" %>

<asp:Content ID="content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="content2" ContentPlaceHolderID="body" runat="server">
    <asp:TextBox ID="emailInput" type="email" runat="server"></asp:TextBox>
    <asp:TextBox ID="passwordInput" type="password" runat="server"></asp:TextBox>
    <asp:Button ID="LoginButton" OnClick="LoginButton_Click" runat="server" />
</asp:Content>
