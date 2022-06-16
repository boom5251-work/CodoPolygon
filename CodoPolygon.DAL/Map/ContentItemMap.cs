using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Repository;
using CodoPolygon.DAL.ViewModels;
using System.Collections.Generic;

namespace CodoPolygon.DAL.Map
{
    public sealed class ContentMap
    {
        /// <summary>
        /// Добавляет новый элемент содержимого или обновляет существующий.
        /// </summary>
        /// <param name="chapterId">Уникальный идентификатор главы.</param>
        /// <param name="items">Набор моделей представления элементов содержимого.</param>
        /// <returns>True — действие выполнено успешно. False — нет.</returns>
        public bool AddOrUpdate(int chapterId, params ContentItemViewModel[] items)
        {
            var domains = new List<ContentItem>();

            foreach (var item in items)
            {
                var domain = new ContentItem
                {
                    //Id = !item.Id.HasValue ? item.Id.Value : id,
                    ChapterId = chapterId,
                    TypeId = (int)GetType(item.TypeCode),
                    Content = item.Content,
                    SequenceNumber = item.SeqNum
                };

                domains.Add(domain);
            }

            bool result = true;

            using (var repository = new ContentRepository())
            {
                foreach (var domain in domains)
                {
                    var isSaved = repository.AddOrUpdate(domain);

                    if (isSaved == false)
                        result = false;
                }
            }

            return result;
        }



        /// <summary>
        /// Возвращает тип элемента содержимого на основе строкового кода типа.
        /// </summary>
        /// <param name="typeCode">Строковый код типа.</param>
        /// <returns>Тип элемента содержимого.</returns>
        internal DomainModels.Base.ContentType GetType(string typeCode)
        {
            DomainModels.Base.ContentType contentType;

            switch (typeCode)
            {
                case "formattedText":
                    contentType = DomainModels.Base.ContentType.FormattedText;
                    break;
                case "aspx-csharp":
                    contentType = DomainModels.Base.ContentType.CodeAspxCsharp;
                    break;
                case "css":
                    contentType = DomainModels.Base.ContentType.CodeCss;
                    break;
                case "csharp":
                    contentType = DomainModels.Base.ContentType.CodeCsharp;
                    break;
                case "fsharp":
                    contentType = DomainModels.Base.ContentType.CodeFsharp;
                    break;
                case "html":
                    contentType = DomainModels.Base.ContentType.CodeHtml;
                    break;
                case "javascript":
                    contentType = DomainModels.Base.ContentType.CodeJavascript;
                    break;
                case "cshtml":
                    contentType = DomainModels.Base.ContentType.CodeRazor;
                    break;
                case "scss":
                    contentType = DomainModels.Base.ContentType.CodeScss;
                    break;
                case "syntaxsql":
                    contentType = DomainModels.Base.ContentType.CodeSyntaxSql;
                    break;
                case "typescript":
                    contentType = DomainModels.Base.ContentType.CodeTypeScript;
                    break;
                default:
                    contentType = DomainModels.Base.ContentType.NotSet;
                    break;
            }

            return contentType;
        }
    }
}