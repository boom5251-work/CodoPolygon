﻿using CodoPolygon.DAL.Context;
using CodoPolygon.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CodoPolygon.DAL.Repository
{
    public sealed class ContentRepository : IDisposable
    {
        private readonly IApplicationContext _context;
        private readonly DbSet<ContentItem> _set;


        public ContentRepository()
        {
            _context = new ApplicationContext();
            _set = _context.Set<ContentItem>();
        }


        /// <summary>Список всего контента (для чтения).</summary>
        public IReadOnlyList<ContentItem> All => _set.ToList();


        public void Dispose() => _context.Dispose();


        /// <summary>
        /// Добавляет новый элемент содержимого или обновляет существующий.
        /// </summary>
        /// <param name="contentItem">Элемент содержимого, который будет добавлен или обнавлен</param>
        /// <returns>True — действие выполнено успешно. False — нет.</returns>
        public bool AddOrUpdate(ContentItem contentItem)
        {
            _set.AddOrUpdate(contentItem);
            return _context.SaveChanges() == 1;
        }


        /// <summary>
        /// Безвозвратно удаляет существующий элемент содержимого из базы данных.
        /// </summary>
        /// <param name="contentItem">Элемент содержимого, который будет удален.</param>
        /// <returns>True — действие выполнено успешно. False — нет.</returns>
        public bool Remove(ContentItem contentItem)
        {
            var _contentItem = _set.Find(contentItem.Id);

            if (_contentItem != null)
            {
                _set.Remove(contentItem);
            }

            return _context.SaveChanges() == 1;
        }


        /// <summary>
        /// Возвращает элементы содержимого, извлеченные из базы данных, по идентификатору главы.
        /// </summary>
        /// <param name="chapterId">Идентификатор главы.</param>
        /// <returns>Перечислитель элементов содержимого.</returns>
        public IEnumerable<ContentItem> GetByChapterId(int chapterId)
        {
            return _set.Where(item => item.ChapterId == chapterId);
        }
    }
}