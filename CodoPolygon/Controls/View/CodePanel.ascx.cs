using CodoPolygon.DAL.DomainModels.Base;
using System;
using System.Web.UI;

namespace CodoPolygon.Controls.View
{
    public partial class CodePanel : UserControl
    {
        /// <summary>Название языка (кодовое название).</summary>
        public string Lang { get; private set; } = string.Empty;
        /// <summary>Заголовок панели (название языка).</summary>
        public string Title { get; private set; } = string.Empty;
        /// <summary>Содержимое контрола (код).</summary>
        public string Code { get; private set; } = string.Empty;



        protected void Page_Load(object sender, EventArgs e)
        {
            title.InnerText = Title;
            code.InnerText = Code;

            if (!string.IsNullOrEmpty(Lang))
                code.Attributes["class"] = $"language-{Lang.ToLower()}";
        }


        /// <summary>
        /// Инициализация контрола.
        /// </summary>
        /// <param name="code">Содержимое контрола (код).</param>
        /// <param name="type">Тип содержимого.</param>
        public void Initialize(string code, ContentType type)
        {
            Lang = GetLang(type);
            Title = GetTitle(type);
            Code = code;
        }


        /// <summary>
        /// Получает кодовое название языка на основе типа содержимого.
        /// </summary>
        /// <param name="type">Тип содержимого.</param>
        /// <returns>Название языка (кодовое название).</returns>
        public static string GetLang(ContentType type)
        {
            string lang;

            switch (type)
            {
                case ContentType.CodeAspxCsharp:
                    lang = "aspx-csharp";
                    break;
                case ContentType.CodeCsharp:
                    lang = "csharp";
                    break;
                case ContentType.CodeCss:
                    lang = "css";
                    break;
                case ContentType.CodeFsharp:
                    lang = "fsharp";
                    break;
                case ContentType.CodeHtml:
                    lang = "html";
                    break;
                case ContentType.CodeJavascript:
                    lang = "javascript";
                    break;
                case ContentType.CodeRazor:
                    lang = "cshtml";
                    break;
                case ContentType.CodeScss:
                    lang = "scss";
                    break;
                case ContentType.CodeSyntaxSql:
                    lang = "syntaxsql";
                    break;
                case ContentType.CodeTypeScript:
                    lang = "typescript";
                    break;
                default:
                    lang = string.Empty;
                    break;
            }

            return lang;
        }


        /// <summary>
        /// Получает название языка (заголовок панели) на основе типа содержимого.
        /// </summary>
        /// <param name="type">Тип содержимого.</param>
        /// <returns>Заголовок панели (название языка).</returns>
        protected static string GetTitle(ContentType type)
        {
            string title;

            switch (type)
            {
                case ContentType.CodeAspxCsharp:
                    title = "ASP.NET";
                    break;
                case ContentType.CodeCsharp:
                    title = "C#";
                    break;
                case ContentType.CodeCss:
                    title = "CSS";
                    break;
                case ContentType.CodeFsharp:
                    title = "F#";
                    break;
                case ContentType.CodeHtml:
                    title = "HTML";
                    break;
                case ContentType.CodeJavascript:
                    title = "JavaScript";
                    break;
                case ContentType.CodeRazor:
                    title = "Razor";
                    break;
                case ContentType.CodeScss:
                    title = "SCSS";
                    break;
                case ContentType.CodeSyntaxSql:
                    title = "syntaxsql";
                    break;
                case ContentType.CodeTypeScript:
                    title = "TypeScript";
                    break;
                default:
                    title = string.Empty;
                    break;
            }

            return title;
        }
    }
}