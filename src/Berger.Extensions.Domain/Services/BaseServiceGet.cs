using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Domain
{
    public class BaseServiceGet<T> : IBaseServiceGet<T>
    {
        #region Properties
        public readonly IRepository<T> _repository;
        public readonly IServiceProvider _services;
        #endregion

        #region Constructors
        public BaseServiceGet(IServiceProvider services)
        {
            _services = services;

            _repository = (IRepository<T>)_services.GetService(typeof(IRepository<T>));
        }
        #endregion

        #region Methods
        public IQueryable<T> Get()
        {
            return _repository.Get();
        }
        public T GetById(Guid id)
        {
            return _repository.GetById(id);
        }
        #endregion
    }
}