<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CodePanel.ascx.cs" Inherits="CodoPolygon.Controls.View.CodePanel" %>

<div class="code-panel">
    <div class="code-panel-header">
        <span><%= Title %></span>
    </div>
    <div class="code-panel-content">
        <pre><code id="code" runat="server"><%= Code %></code></pre>
    </div>
</div>