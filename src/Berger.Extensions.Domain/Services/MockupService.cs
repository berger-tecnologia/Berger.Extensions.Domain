using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Domain
{
    public class MockupService<T> where T : BaseEntity
	{
		#region Methods
		public IQueryable<T> Get(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }
		public T Add(T source)
        {
            throw new NotImplementedException();
        }
        public void Add(IQueryable<T> source)
        {
            throw new NotImplementedException();
        }
        public Task<T> AddAsync(T source)
        {
            throw new NotImplementedException();
        }
        public T Update(T source)
        {
            throw new NotImplementedException();
        }
        public Task<T> UpdateAsync(T source)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAsync(Func<T, string> field, string value)
        {
            throw new NotImplementedException();
        }
        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }
        public void Delete(IQueryable<T> source)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}