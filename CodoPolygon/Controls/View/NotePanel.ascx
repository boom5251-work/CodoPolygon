<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NotePanel.ascx.cs" Inherits="CodoPolygon.Controls.View.NotePanel" %>

<div class="note-panel">
    <div class="note-panel-header">
        <img src="/root/icons/note.svg" alt="" />
        <p class="note-panel-title">Примечание</p>
    </div>
    <p id="htmlContent" class="note-panel-content" runat="server"><%= Content %></p>
</div>