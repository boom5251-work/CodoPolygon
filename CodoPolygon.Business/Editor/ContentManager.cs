using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Map;
using CodoPolygon.DAL.Repository;
using CodoPolygon.DAL.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CodoPolygon.Business.Editor
{
    public sealed class ContentManager
    {
        /// <summary>
        /// Активирует процесс добовления или обновления элементов содержимого.
        /// </summary>
        /// <param name="articleLatName">Сокращенное латинское название.</param>
        /// <param name="chapterSeqNum">Порядковый номер главы.</param>
        /// <param name="items">Список элементов содержимого (моделей представления).</param>
        /// <returns>True, если действие выполнено успешно. False — нет.</returns>
        public static bool SaveContent(string articleLatName, int chapterSeqNum, List<ContentItemViewModel> items)
        {
            Article article;
            Chapter chapter;

            using (var repository = new ArticleRepository())
            {
                article = repository.GetByLatName(articleLatName);
            }

            using (var repository = new ChapterRepository())
            {
                var chapters = repository.GetByArticleId(article.Id);
                chapter = chapters.SingleOrDefault(itme => itme.SequenceNumber == chapterSeqNum);
            }

            var contentMap = new ContentMap();

            return contentMap.AddOrUpdate(chapter.Id, items.ToArray());
        }
    }
}
