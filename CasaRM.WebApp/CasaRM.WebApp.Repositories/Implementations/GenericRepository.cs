using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        /// <summary>
        /// Contructor of GenericRepository
        /// </summary>
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method is to add a record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// This method is to add a range of records.
        /// </summary>
        /// <param name="entities"></param>
        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        /// <summary>
        /// Validates if there's any element with a given Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>bool</returns>
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> expression) => await _context.Set<T>().AnyAsync(expression);

        /// <summary>
        /// This method is to get the records using an expression.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }

        /// <summary>
        /// This method is to get all the records.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        /// <summary>
        /// This method is to get a single record using ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// Modify a record
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Modify a collection of records
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        /// <summary>
        /// This method is to remove a record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Remove a collection of records
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> RemoveRangeAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
            return entities;
        }
    }
}