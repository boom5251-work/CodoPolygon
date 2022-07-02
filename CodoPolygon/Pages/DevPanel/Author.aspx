А<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="CodoPolygon.Pages.DevPanel.Author" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <script src="/root/libs/jquery.min.js"></script>

    <script src="/root/scripts/author/article-manager.js"></script>

    <link rel="stylesheet" href="/root/styles/author/author.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="body" runat="server">
    <section>
        <asp:Panel CssClass="articles-container" ID="articlesContainer" runat="server"></asp:Panel>
    </section>
</asp:Content>
