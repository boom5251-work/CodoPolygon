<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="CodoPolygon.Pages.DevPanel.Editor" %>


<asp:Content ContentPlaceHolderID="head" runat="server">
    <script src="/root/libs/jquery.min.js"></script>
    <script src="/root/libs/jquery-ui.min.js"></script>

    <script src="/root/scripts/editor/editor.js"></script>
    <script src="/root/scripts/editor/content-manager.js"></script>
    
    <link href="/root/styles/editor/editor.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="body" runat="server">
    <section>
        <div>
            <input class="add-subtitle-editor-button" type="button" value="subtitle" />
            <input class="add-text-editor-button" type="button" value="text" />
            <input class="add-code-editor-button" type="button" value="code" />
            <input class="add-note-editor-button" type="button" value="note" />
        </div>
    </section>
    <section>
        <asp:Panel ID="contentContainer" CssClass="content-container" runat="server"></asp:Panel>
    </section>
    <footer>
        <input type="button" value="save" onclick="saveAll()" />
    </footer>
</asp:Content>