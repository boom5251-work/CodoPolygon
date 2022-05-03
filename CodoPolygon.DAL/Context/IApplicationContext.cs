using System.Data.Entity;

namespace CodoPolygon.DAL.Context
{
    public interface IApplicationContext
    {
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        void Dispose();
    }
}