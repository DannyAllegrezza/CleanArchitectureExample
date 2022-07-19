using Ardalis.Specification;

namespace CleanArchitectureExample.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
