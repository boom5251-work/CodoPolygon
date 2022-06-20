<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CodeEditor.ascx.cs" Inherits="CodoPolygon.Controls.Editor.CodeEditor" %>

<div class="code-editor editor">
    <div class="code-editor-header">
        <asp:DropDownList ID="langSelect" CssClass="code-editor-header-select" runat="server">
            <asp:ListItem Value="_default" Text="Не выбрано" />
            <asp:ListItem Value="aspx-csharp" Text="ASP.NET (C#) (.aspx, .ascx)" />
            <asp:ListItem Value="css" Text="CSS таблица стилей (.css)" />
            <asp:ListItem Value="csharp" Text="C# &mdash; C Sharp (.cs)" />
            <asp:ListItem Value="fsharp" Text="F# &mdash; F Sharp (.fs)" />
            <asp:ListItem Value="html" Text="HTML разметка (.html)" />
            <asp:ListItem Value="javascript" Text="Javascript (.js)" />
            <asp:ListItem Value="cshtml" Text="Razor Pages (.cshtml)" />
            <asp:ListItem Value="scss" Text="SCSS таблица стилей (.scss)" />
            <asp:ListItem Value="syntaxsql" Text="Transact-SQL (.sql)" />
            <asp:ListItem Value="typescript" Text="TypeScript (.ts)" />
        </asp:DropDownList>
        <div class="remove-button-container">
            <img class="editor-remove-button" src="/root/icons/remove-grey.svg" alt="Удалить" />
        </div>
    </div>
    <div class="code-editor-content">
        <textarea id="code" class="code-editor-content-area" runat="server"><%= Code %></textarea>
    </div>
</div>