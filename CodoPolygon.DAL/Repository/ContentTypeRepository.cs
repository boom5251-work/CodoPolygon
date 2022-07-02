using CodoPolygon.DAL.Context;
using CodoPolygon.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CodoPolygon.DAL.Repository
{
    internal class ContentTypeRepository : IDisposable
    {
        private readonly IApplicationContext _context;
        private readonly DbSet<ContentType> _set;


        public ContentTypeRepository()
        {
            _context = new ApplicationContext();
            _set = _context.Set<ContentType>();
        }


        /// <summary>Список всех типов (для чтения).</summary>
        public IReadOnlyList<ContentType> All => _set.ToList();


        public void Dispose() => _context.Dispose();


        /// <summary>
        /// Возвращает тип содержимого по уникальному коду.
        /// </summary>
        /// <param name="uniqueCode">Уникальный код.</param>
        /// <returns>Тип элемента содержимого.</returns>
        public ContentType GetByUniqueCode(int uniqueCode)
        {
            return _set.SingleOrDefault(item => item.UniqueCode == uniqueCode);
        }
    }
}