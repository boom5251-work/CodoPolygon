using CodoPolygon.DAL.DomainModels;
using System.Data.Entity;

namespace CodoPolygon.DAL.Context
{
    public sealed class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext() : base("CodoPolygonDb") { }


        internal DbSet<Article> Articles { get; set; }
        internal DbSet<Chapter> Chapters { get; set; }
        internal DbSet<ContentItem> ContentItems { get; set; }
        internal DbSet<ContentType> ContentTypes { get; set; }
        internal DbSet<User> Users { get; set; }
        internal DbSet<UserArticle> UsersArticles { get; set; }
        internal DbSet<UserRole> UserRoles { get; set; }
    }
}