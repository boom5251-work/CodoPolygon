using CodoPolygon.DAL.Context;
using CodoPolygon.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CodoPolygon.DAL.Repository
{
    public sealed class ArticleRepository : IDisposable
    {
        private readonly IApplicationContext _context;
        private readonly DbSet<Article> _set;


        public ArticleRepository()
        {
            _context = new ApplicationContext();
            _set = _context.Set<Article>();
        }


        /// <summary>Список всех статей (для чтения).</summary>
        public IReadOnlyList<Article> All => _set.ToList();


        public void Dispose() => _context.Dispose();


        /// <summary>
        /// Добавляет новую статью или обновляет существующую.
        /// </summary>
        /// <param name="article">Статья, которая будет добавлена или обновлена.</param>
        /// <returns>True — действие выполнено успешно. False — нет.</returns>
        public bool AddOrUpdate(Article article)
        {
            _set.AddOrUpdate(article);
            return _context.SaveChanges() == 1;
        }


        /// <summary>
        /// Безвозвратно удаляет существующую статью из базы данных.<br/>
        /// Во время удаления должен сработать триггер, который удалит все главы этой статьи.
        /// </summary>
        /// <param name="article">Статья, которая будет удалена.</param>
        /// <returns>True, если действие выполнено успешно. False — нет.</returns>
        public bool Remove(Article article)
        {
            var _article = _set.Find(article.Id);

            if (_article != null)
            {
                _set.Remove(_article);
            }

            return _context.SaveChanges() >= 1;
        }
    }
}