using ExpansesApp.Core.Contexts.ExpanseContext.Entities;

namespace ExpansesApp.Core.Contexts.ExpanseContext.Contracts.Repositories;
public interface IExpanseRepository
{
    public Task CreateAsync(Expanse expanse);
}
