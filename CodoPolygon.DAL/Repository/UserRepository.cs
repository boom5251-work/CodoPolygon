using CodoPolygon.DAL.Context;
using CodoPolygon.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CodoPolygon.DAL.Repository
{
    public sealed class UserRepository : IDisposable
    {
        private readonly IApplicationContext _context;
        private readonly DbSet<User> _set;


        public UserRepository()
        {
            _context = new ApplicationContext();
            _set = _context.Set<User>();
        }


        /// <summary>Список всех пользователей (для чтения).</summary>
        public IReadOnlyList<User> All => _set.ToList();


        public void Dispose() => _context.Dispose();


        /// <summary>
        /// Добавляет нового пользователя или обновляет существующего.
        /// </summary>
        /// <param name="user">>Пользователь, который будет добавлен или обновлен.</param>
        /// <returns>True — действие выполнено успешно. False — нет.</returns>
        public bool AddOrUpdate(User user)
        {
            _set.AddOrUpdate(user);
            return _context.SaveChanges() == 1;
        }


        /// <summary>
        /// Возвращает пользователя по адресу электронной почты (логину).
        /// </summary>
        /// <param name="email">Адрес электронной почты.</param>
        /// <returns>Объект, если пользователь найден. В противном случае возвращает null.</returns>
        public User GetByEmail(string email)
        {
            return _set.SingleOrDefault(item => item.Email == email);
        } 
    }
}