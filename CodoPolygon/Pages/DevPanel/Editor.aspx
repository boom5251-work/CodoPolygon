<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="CodoPolygon.Pages.DevPanel.Editor" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <script src="/root/libs/jquery.min.js"></script>
    <script src="/root/libs/jquery-ui.min.js"></script>

    <script src="/root/scripts/editor/editor.js"></script>
</asp:Content>

<asp:Content ContentPlaceHolderID="body" runat="server">
    <div class="main-container">
        <div class="editor-panel-container">

        </div>
        <div id="content-container" class="content-container"></div>
        <asp:Panel runat="server">
            <asp:Button Enabled="false" Text="Сохранить" runat="server" />
        </asp:Panel>
    </div>
</asp:Content>