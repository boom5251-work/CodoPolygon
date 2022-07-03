using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Repository;

namespace CodoPolygon.Business.ArticleContent
{
    public sealed class Inspector
    {
        /// <summary>
        /// Проверяет, существует ли статься с указанным сокращенным латинским названием.
        /// </summary>
        /// <param name="articleLatName">Сокращенное латинское название.</param>
        /// <returns>True, если вхождение найдено. False — нет.</returns>
        public static bool HasArticle(string articleLatName)
        {
            if (!string.IsNullOrEmpty(articleLatName))
            {
                using (var repository = new ArticleRepository())
                {
                    return repository.HasArticle(articleLatName);
                }
            }
            else return false;
        }



        /// <summary>
        /// Проверяет, существует ли глава в статье с указанным порядковым номером.
        /// </summary>
        /// <param name="articleLatName">Сокращенное латинское название.</param>
        /// <param name="chapterSeqNum">Порядковый номер главы.</param>
        /// <returns>True, если вхождение найдено. False — нет.</returns>
        public static bool HasChapter(string articleLatName, int chapterSeqNum)
        {
            if (!string.IsNullOrEmpty(articleLatName))
            {
                Article article;

                using (var repository = new ArticleRepository())
                {
                    article = repository.GetByLatName(articleLatName);
                }

                if (article != null)
                {
                    using (var repository = new ChapterRepository())
                    {
                        return repository.HasChapter(article.Id, chapterSeqNum);
                    }
                }
                else return false;
            }
            else return false;
        }



        /// <summary>
        /// Проверяет, существует ли статья с таким сокращенным латинским названием и опубликована ли она.
        /// </summary>
        /// <param name="articleLatName">Сокращенное латинское название.</param>
        /// <returns>True, если статья существует и опублиоквана, False - нет.</returns>
        public static bool IsPublished(string articleLatName)
        {
            if (!string.IsNullOrEmpty(articleLatName))
            {
                using (var repository = new ArticleRepository())
                {
                    var article = repository.GetByLatName(articleLatName);
                    return (bool)article?.IsPublished;
                }
            }
            else return false;
        }
    }
}