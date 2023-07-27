using Berger.Extensions.Repository;

namespace Berger.Extensions.Domain
{
    public interface IBaseService<T> : IRepository<T>
    {
    }
}