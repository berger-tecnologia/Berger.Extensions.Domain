using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Domain
{
    public interface IBaseService<T> : IRepository<T>
    {
    }
}