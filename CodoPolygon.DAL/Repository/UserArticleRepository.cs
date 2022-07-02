using CodoPolygon.DAL.Context;
using CodoPolygon.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;

namespace CodoPolygon.DAL.Repository
{
    public sealed class UserArticleRepository : IDisposable
    {
        private readonly IApplicationContext _context;
        private readonly DbSet<UserArticle> _set;


        public UserArticleRepository()
        {
            _context = new ApplicationContext();
            _set = _context.Set<UserArticle>();
        }


        /// <summary>Список всех пользователей-статей (для чтения).</summary>
        public IReadOnlyList<UserArticle> All => _set.ToList();


        public void Dispose() => _context.Dispose();


        /// <summary>
        /// Добавляет новый объект пользователя-статьи.
        /// </summary>
        /// <param name="userArticle">Объект пользователя-статьи, который будет добавлен или обновлен.</param>
        /// <returns>True — действие выполнено успешно. False — нет.</returns>
        public bool AddOrUpdate(UserArticle userArticle)
        {
            try
            {
                _set.AddOrUpdate(userArticle);
                return _context.SaveChanges() == 1;
            }
            catch (DbEntityValidationException)
            {
                // TODO: Добавить обработку исключения.
                return false;
            }
        }


        /// <summary>
        /// Возвращает объекты пользователей-статей, извлеченные из базы данных, по идетификатору пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Список пользователей-статей (для чтения).</returns>
        public IReadOnlyList<UserArticle> GetByUserId(int userId)
        {
            return _set.Where(item => item.UserId == userId).ToList();
        }
    }
}