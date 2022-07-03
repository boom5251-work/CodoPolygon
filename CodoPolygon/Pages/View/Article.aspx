<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="CodoPolygon.Pages.View.Article" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <script src="/root/libs/highlight.js"></script>
    <asp:Panel ID="hljsLangsContainer" runat="server"></asp:Panel>
    <script>hljs.highlightAll();</script>

    <link href="/root/styles/code.css" rel="stylesheet" />
    <link href="/root/styles/article/article.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="body" runat="server">
    <header>
        <asp:Panel ID="headerContainer" runat="server"></asp:Panel>
    </header>

    <section>
        <asp:Panel ID="contentContainer" runat="server"></asp:Panel>
    </section>
</asp:Content>
