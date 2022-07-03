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
        public static string GetLang(ContentItemType type)
        {
            string lang;

            switch (type)
            {
                case ContentItemType.CodeAspxCsharp:
                    lang = "aspx-csharp";
                    break;
                case ContentItemType.CodeCsharp:
                    lang = "csharp";
                    break;
                case ContentItemType.CodeCss:
                    lang = "css";
                    break;
                case ContentItemType.CodeFsharp:
                    lang = "fsharp";
                    break;
                case ContentItemType.CodeHtml:
                    lang = "xml";
                    break;
                case ContentItemType.CodeJavascript:
                    lang = "javascript";
                    break;
                case ContentItemType.CodeRazor:
                    lang = "cshtml-razor";
                    break;
                case ContentItemType.CodeScss:
                    lang = "scss";
                    break;
                case ContentItemType.CodeTransactSql:
                    lang = "sql";
                    break;
                case ContentItemType.CodeTypeScript:
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
        public static string GetTitle(ContentItemType type)
        {
            string title;

            switch (type)
            {
                case ContentItemType.CodeAspxCsharp:
                    title = "ASP.NET";
                    break;
                case ContentItemType.CodeCsharp:
                    title = "C#";
                    break;
                case ContentItemType.CodeCss:
                    title = "CSS";
                    break;
                case ContentItemType.CodeFsharp:
                    title = "F#";
                    break;
                case ContentItemType.CodeHtml:
                    title = "HTML";
                    break;
                case ContentItemType.CodeJavascript:
                    title = "JavaScript";
                    break;
                case ContentItemType.CodeRazor:
                    title = "Razor";
                    break;
                case ContentItemType.CodeScss:
                    title = "SCSS";
                    break;
                case ContentItemType.CodeTransactSql:
                    title = "T-SQL";
                    break;
                case ContentItemType.CodeTypeScript:
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
