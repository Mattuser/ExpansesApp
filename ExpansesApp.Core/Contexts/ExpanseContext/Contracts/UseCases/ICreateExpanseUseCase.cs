using ExpansesApp.Core.Contexts.ExpanseContext.Entities;

namespace ExpansesApp.Core.Contexts.ExpanseContext.Contracts.UseCases;
public interface ICreateExpanseUseCase
{
    public Task Create(Expanse expanse);
}
