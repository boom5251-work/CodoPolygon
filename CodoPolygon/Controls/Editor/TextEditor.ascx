<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextEditor.ascx.cs" Inherits="CodoPolygon.Controls.Editor.TextEditor" %>

<div class="text-editor editor">
    <div class="text-editor-header">
        <div class="buttons-container">
            <img class="editor-button bold-button" src="/root/icons/bold-black.svg" alt="Жирный" />
            <img class="editor-button underline-button" src="/root/icons/underline-black.svg" alt="Подчеркнутый" />
            <img class="editor-button strikethrough-button" src="/root/icons/strikethrough-black.svg" alt="Зачеркнутый" />
            <img class="editor-button code-style-button" src="/root/icons/code-black.svg" alt="Выделение" />
        </div>
        <div class="remove-button-container">
            <img class="editor-remove-button" src="/root/icons/remove-black.svg" alt="Удалить" />
        </div>
    </div>
    <div class="text-editor-content">
        <div contenteditable="true" id="contentArea" class="content-editable" runat="server"></div>
    </div>
</div>