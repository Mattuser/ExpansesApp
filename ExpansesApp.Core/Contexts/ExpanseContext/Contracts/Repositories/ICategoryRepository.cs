using ExpansesApp.Core.Contexts.ExpanseContext.Entities;

namespace ExpansesApp.Core.Contexts.ExpanseContext.Contracts.Repositories;
public interface ICategoryRepository
{
    public Task<bool> AnyAsync(string name, CancellationToken cancellation);
    public Task<bool> AnyAsync(Guid Id, CancellationToken cancellationToken);
    public Task SaveAsync(Category category, CancellationToken cancellationToken);
}
