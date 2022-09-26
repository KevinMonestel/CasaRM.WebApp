using System.Linq.Expressions;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// This method is to get a single record using ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(int id);

        /// <summary>
        /// This method is to get all the records.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// This method is to get the records using an expression.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);

        /// <summary>
        /// This method is to add a record.
        /// </summary>
        /// <param name="entity"></param>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// This method is to add a range of records.
        /// </summary>
        /// <param name="entities"></param>
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// Modify a record
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity);

        /// <summary>
        /// Validates if there's any element with a given Id
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>bool</returns>
        Task<bool> ExistsAsync(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Modify a collection of records
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities);
    }
}
