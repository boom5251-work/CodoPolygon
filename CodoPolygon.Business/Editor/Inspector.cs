using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Repository;

namespace CodoPolygon.Business.Editor
{
    public sealed class Inspector
    {
        /// <summary>
        /// Проверяет, существует ли статься с указанным сокращенным латинским названием.
        /// </summary>
        /// <param name="articleQueryValue">Сокращенное латинское название.</param>
        /// <returns>True, если вхождение найдено. False — нет.</returns>
        public static bool HasArticle(string articleQueryValue)
        {
            if (string.IsNullOrEmpty(articleQueryValue))
            {
                using (var repository = new ArticleRepository())
                {
                    return repository.HasArticle(articleQueryValue);
                }
            }
            else return false;
        }


        /// <summary>
        /// Проверяет, существует ли глава в статье с указанным порядковым номером.
        /// </summary>
        /// <param name="articleQueryValue">Сокращенное латинское название.</param>
        /// <param name="chapterQueryValue">Порядковый номер главы (строка).</param>
        /// <returns>True, если вхождение найдено. False — нет.</returns>
        public static bool HasChapter(string articleQueryValue, string chapterQueryValue)
        {
            bool notNullOrEmptyStrings = !string.IsNullOrEmpty(articleQueryValue) && !string.IsNullOrEmpty(chapterQueryValue);

            if (notNullOrEmptyStrings && int.TryParse(chapterQueryValue, out int chapterSeqNum))
            {
                Article article;

                using (var repository = new ArticleRepository())
                {
                    article = repository.GetByLatName(articleQueryValue);
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
    }
}