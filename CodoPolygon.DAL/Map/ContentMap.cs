using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.DomainModels.Base;
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
                    ChapterId = chapterId,
                    TypeId = GetTypeId(item.TypeCode),
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
        /// Возвращает модели хранилища элементов содержимого по идентификатору главы.
        /// </summary>
        /// <param name="chapterId">Идентификатор главы.</param>
        /// <returns>Перечислитель моделей хранилища элементов содержимого.</returns>
        public IEnumerable<ContentItem> GetDomainsByChapterId(int chapterId)
        {
            using (var repository = new ContentRepository())
            {
                return repository.GetByChapterId(chapterId);
            }
        } 



        /// <summary>
        /// Возвращает идентификатор типа элемента содержимого.
        /// </summary>
        /// <param name="typeCode">Строковый код типа.</param>
        /// <returns>Идентификатор типа элемента содержимого.</returns>
        internal int GetTypeId(string typeCode)
        {
            var type = GetType(typeCode);

            using (var repository = new ContentTypeRepository())
            {
                return repository.GetByUniqueCode((int)type).Id;
            }
        }



        /// <summary>
        /// Возвращает тип элемента содержимого на основе строкового кода типа.
        /// </summary>
        /// <param name="typeCode">Строковый код типа.</param>
        /// <returns>Тип элемента содержимого (перечисление).</returns>
        internal ContentItemType GetType(string typeCode)
        {
            ContentItemType type;

            switch (typeCode)
            {
                case "formattedText":
                    type = ContentItemType.FormattedText;
                    break;
                case "aspx-csharp":
                    type = ContentItemType.CodeAspxCsharp;
                    break;
                case "css":
                    type = ContentItemType.CodeCss;
                    break;
                case "csharp":
                    type = ContentItemType.CodeCsharp;
                    break;
                case "fsharp":
                    type = ContentItemType.CodeFsharp;
                    break;
                case "html":
                    type = ContentItemType.CodeHtml;
                    break;
                case "javascript":
                    type = ContentItemType.CodeJavascript;
                    break;
                case "cshtml":
                    type = ContentItemType.CodeRazor;
                    break;
                case "scss":
                    type = ContentItemType.CodeScss;
                    break;
                case "syntaxsql":
                    type = ContentItemType.CodeTransactSql;
                    break;
                case "typescript":
                    type = ContentItemType.CodeTypeScript;
                    break;
                case "subtitleAnchor":
                    type = ContentItemType.SubtitleAnchor;
                    break;
                case "formattedNote":
                    type = ContentItemType.FormattedNote;
                    break;
                default:
                    type = ContentItemType.NotSet;
                    break;
            }

            return type;
        }
    }
}