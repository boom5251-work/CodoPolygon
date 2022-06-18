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
            <svg class="editor-remove-button" viewBox="0 0 64 64" fill="#979797" xmlns="http://www.w3.org/2000/svg">
                <path d="M20.5417 29.75H43.4583C44.0661 29.75 44.649 29.9871 45.0788 30.409C45.5086 30.831 45.75 31.4033 45.75 32C45.75 32.5967 45.5086 33.169 45.0788 33.591C44.649 34.0129 44.0661 34.25 43.4583 34.25H20.5417C19.9339 34.25 19.351 34.0129 18.9212 33.591C18.4914 33.169 18.25 32.5967 18.25 32C18.25 31.4033 18.4914 30.831 18.9212 30.409C19.351 29.9871 19.9339 29.75 20.5417 29.75V29.75Z" />
                <path d="M32 59.4286C35.602 59.4286 39.1687 58.7191 42.4965 57.3407C45.8242 55.9623 48.848 53.9419 51.3949 51.3949C53.9419 48.848 55.9623 45.8242 57.3407 42.4965C58.7191 39.1687 59.4286 35.602 59.4286 32C59.4286 28.398 58.7191 24.8313 57.3407 21.5035C55.9623 18.1758 53.9419 15.152 51.3949 12.6051C48.848 10.0581 45.8242 8.03772 42.4965 6.6593C39.1687 5.28089 35.602 4.57143 32 4.57143C24.7255 4.57143 17.7489 7.46122 12.6051 12.6051C7.46122 17.7489 4.57143 24.7255 4.57143 32C4.57143 39.2745 7.46122 46.2511 12.6051 51.3949C17.7489 56.5388 24.7255 59.4286 32 59.4286V59.4286ZM32 64C23.5131 64 15.3737 60.6286 9.37258 54.6274C3.37142 48.6263 0 40.4869 0 32C0 23.5131 3.37142 15.3737 9.37258 9.37258C15.3737 3.37142 23.5131 0 32 0C40.4869 0 48.6263 3.37142 54.6274 9.37258C60.6286 15.3737 64 23.5131 64 32C64 40.4869 60.6286 48.6263 54.6274 54.6274C48.6263 60.6286 40.4869 64 32 64Z" />
            </svg>
        </div>
    </div>
    <div class="code-editor-content">
        <textarea id="code" class="code-editor-content-area" runat="server"><%= Code %></textarea>
    </div>
</div>