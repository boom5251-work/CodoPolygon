<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleView.aspx.cs" Inherits="CodoPolygon.Pages.View.ArticleView" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <script src="/root/libs/highlight.js"></script>
    <script src="/root/libs/highlight/csharp.min.js"></script>
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
