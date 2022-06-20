<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NoteEditor.ascx.cs" Inherits="CodoPolygon.Controls.Editor.NoteEditor" %>

<div class="note-editor editor">
    <div class="note-editor-header">
        <div class="buttons-container">
            <img class="editor-button add-link-button" src="/root/icons/link-purple.svg" alt="Вставить ссылку" />
            <div class="link-item-container">
                <input class="href-input" type="text" placeholder="https://mysite.ru" />
                <img class="editor-button save-link-button" src="/root/icons/ok-purple.svg" alt="Добавить" />
                <img class="editor-button cancel-link-button" src="/root/icons/cancel-purple.svg" alt="Отменить" />
            </div>
        </div>
        <div class="remove-button-container">
            <img class="editor-remove-button" src="/root/icons/remove-purple.svg" alt="Удалить" />
        </div>
    </div>

    <div class="content-editable" id="contentArea" contenteditable="true" runat="server"></div>
</div>