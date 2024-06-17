using ExpansesApp.Core.Contexts.ExpanseContext.Contracts.Repositories;
using ExpansesApp.Core.Contexts.ExpanseContext.Entities;

namespace ExpansesApp.Infra.Contexts.ExpanseContext.UseCases;
public class CategoryRepository : ICategoryRepository
{
    public Task<bool> AnyAsync(string name, CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Guid Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync(Category category, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
