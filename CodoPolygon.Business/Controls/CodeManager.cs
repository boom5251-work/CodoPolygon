using CodoPolygon.DAL.DomainModels.Base;

namespace CodoPolygon.Business.Controls
{
    public sealed class CodeManager
    {
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
        public static string GetTitle(ContentType type)
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
