using CodoPolygon.DAL.Context;
using CodoPolygon.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CodoPolygon.DAL.Repository
{
    public sealed class ChapterRepository : IDisposable
    {
        private readonly IApplicationContext _context;
        private readonly DbSet<Chapter> _set;


        public ChapterRepository()
        {
            _context = new ApplicationContext();
            _set = _context.Set<Chapter>();
        }


        /// <summary>Список всех частей (для чтения).</summary>
        public IReadOnlyList<Chapter> All => _set.ToList();


        public void Dispose() => _context.Dispose();


        /// <summary>
        /// Добавляет новую главу или обновляет существующую.
        /// </summary>
        /// <param name="chapter">Глава, которая будет добавлена или обновлена.</param>
        /// <returns>True — действие выполнено успешно. False — нет.</returns>
        public bool AddOrUpdate(Chapter chapter)
        {
            _set.AddOrUpdate(chapter);
            return _context.SaveChanges() == 1;
        }


        /// <summary>
        /// Безвозвратно удаляет существующую главу из базы данных.<br/>
        /// Во время удаления должен сработать триггер, который удалит весь контент этой главы.
        /// </summary>
        /// <param name="chapter">Глава, которая будет удалена.</param>
        /// <returns>True, если действие выполнено успешно. False — нет.</returns>
        public bool Remove(Chapter chapter)
        {
            var _chapter = _set.Find(chapter.Id);

            if (_chapter != null)
            {
                _set.Remove(_chapter);
            }

            return _context.SaveChanges() >= 1;
        }


        /// <summary>
        /// Возвращает главы, извелченные из базы данных, по идентификатору статьи.
        /// </summary>
        /// <param name="articleId">Идентификатор статьи.</param>
        /// <returns>Перечислитель глав.</returns>
        public IEnumerable<Chapter> GetByArticleId(int articleId)
        {
            return _set.Where(item => item.ArticleId == articleId);
        }
    }
}