using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Map;
using CodoPolygon.DAL.Repository;
using CodoPolygon.DAL.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CodoPolygon.Business.ArticleContent
{
    public sealed class ContentManager
    {
        /// <summary>
        /// Возвращает список элементов управления на оснвое сокращенного латинского имени статьи и порядкового номера главы.
        /// </summary>
        /// <param name="articleLatName">Сокращенное латинское название.</param>
        /// <param name="chapterSeqNum">Порядковый номер главы.</param>
        /// <returns>Список элементов содержимого.</returns>
        public static List<ContentItem> GetContent(string articleLatName, int chapterSeqNum)
        {
            var chapter = GetChapter(articleLatName, chapterSeqNum);

            var contentMap = new ContentMap();

            return contentMap.GetDomainsByChapterId(chapter.Id)
                .OrderBy(item => item.SequenceNumber)
                .ToList();
        }



        /// <summary>
        /// Активирует процесс добовления или обновления элементов содержимого.
        /// </summary>
        /// <param name="articleLatName">Сокращенное латинское название.</param>
        /// <param name="chapterSeqNum">Порядковый номер главы.</param>
        /// <param name="items">Список элементов содержимого (моделей представления).</param>
        /// <returns>True, если действие выполнено успешно. False — нет.</returns>
        public static bool SaveContent(string articleLatName, int chapterSeqNum, List<ContentItemViewModel> items)
        {
            var chapter = GetChapter(articleLatName, chapterSeqNum);

            var contentMap = new ContentMap();

            return contentMap.AddOrUpdate(chapter.Id, items.ToArray());
        }



        /// <summary>
        /// Возвращает главу на основе сокращенного латинского имени статьм и порядкового номера главы.
        /// </summary>
        /// <param name="articleLatName">Сокращенное латинское название.</param>
        /// <param name="chapterSeqNum">Порядковый номер главы.</param>
        /// <returns>Глава.</returns>
        private static Chapter GetChapter(string articleLatName, int chapterSeqNum)
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

            return chapter;
        }
    }
}