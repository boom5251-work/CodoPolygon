<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SubtitleAnchor.ascx.cs" Inherits="CodoPolygon.Controls.View.SubtitleAnchor" %>

<asp:Panel ID="container" CssClass="subtitle-anchor" runat="server">
    <h2 id="<%= HeaderId %>" class="subtitle-anchor-header"><%= Text %></h2>
</asp:Panel>