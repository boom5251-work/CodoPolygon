using System;

namespace CodoPolygon.DAL.DomainModels.Base
{
    /// <summary>
    /// Перечисление типов элементов содержимого.
    /// </summary>
    [Flags]
    public enum ContentItemType : short
    {
        /// <summary>Тип не установлен.</summary>
        NotSet = 0,
        /// <summary>Форматированный текст.</summary>
        FormattedText = 1,
        /// <summary>Форматированное примечание.</summary>
        FormattedNote = 2,
        /// <summary>Подзаголовок, якорь.</summary>
        SubtitleAnchor = 4,
        /// <summary>Разметка ASPX C#.</summary>
        CodeAspxCsharp = 8,
        /// <summary>Стили CSS.</summary>
        CodeCss = 16,
        /// <summary>Код на языке C#.</summary>
        CodeCsharp = 32,
        /// <summary>Код на языке F#.</summary>
        CodeFsharp = 64,
        /// <summary>Разметка HTML.</summary>
        CodeHtml = 128,
        /// <summary>Код на языке JavaScript.</summary>
        CodeJavascript = 258,
        /// <summary>Шаблон Razor C#.</summary>
        CodeRazor = 512,
        /// <summary>Стили SCSS.</summary>
        CodeScss = 1024,
        /// <summary>Скрипт T-SQL.</summary>
        CodeTransactSql = 2048,
        /// <summary>Код на языке TypeScript.</summary>
        CodeTypeScript = 4096,

        /// <summary>
        /// Флаг, указывающий на все типы языков.
        /// 16368 = 0b11111111110000.
        /// </summary>
        AnyCode = 16368
    }
}