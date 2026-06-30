using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepositUnitWorkApp.Data.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);

        /* This method is used to retrieve a single record. It leverages eager loading to execute the necessary SQL queries directly. The includeProperties parameter allows you to load data from related tables if it exists; if not, it remains null. A common use case is fetching a specific record, such as the one with ID 1. */
        T GetFirstOrDefault(Expression<Func<T, bool>>filter, string? includeProperties = null);

        /* This method is used to retrieve a list of records. We use Expression<Func> to ensure the SQL queries are executed efficiently and fetch all requested data. If specified, related tables are eager-loaded in the background; otherwise, they remain null. An example use case is pulling the entire "Customers" table. */
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

        void RemoveRange(IEnumerable<T> entities);
        /* The primary reason for implementing this method is to easily delete multiple entities at once, seamlessly handling the removal of associated records in related tables. */
    }
}
