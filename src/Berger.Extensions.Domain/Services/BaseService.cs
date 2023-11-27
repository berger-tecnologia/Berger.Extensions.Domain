using System.Linq.Expressions;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Domain
{
    public class BaseService<T> : BaseServiceGet<T>, IBaseService<T> where T : class
    {
        #region Constructors
        public BaseService(IServiceProvider services) : base(services)
        {
        }
        #endregion

        #region Methods
        public T Add(T source)
        {
            return _repository.Add(source);
        }
        public void Add(IQueryable<T> sources, bool detach = false)
        {
            _repository.Add(sources, detach);
        }
        public void Add(IQueryable<T> source)
        {
            _repository.Add(source);
        }
        public async Task<T> AddAsync(T source)
        {
            return await _repository.AddAsync(source);
        }
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
        public void Delete(IQueryable<T> sources)
        {
            _repository.Delete(sources);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
        public T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return _repository.FirstOrDefault(expression);
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return _repository.Get(expression);
        }
        public IQueryable<T> GetIgnoreFilters()
        {
            return _repository.GetIgnoreFilters();
        }
        public T Update(T source)
        {
            return _repository.Update(source);
        }
        public async Task<T> UpdateAsync(T source)
        {
            return await _repository.UpdateAsync(source);
        }
        public async Task UpdateAsync(Func<T, string> field, string value)
        {
            await _repository.UpdateAsync(field, value);
        }
        #endregion
    }
}