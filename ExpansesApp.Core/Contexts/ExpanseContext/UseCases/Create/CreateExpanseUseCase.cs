using ExpansesApp.Core.Contexts.ExpanseContext.Contracts.Repositories;
using ExpansesApp.Core.Contexts.ExpanseContext.Contracts.UseCases;
using ExpansesApp.Core.Contexts.ExpanseContext.Entities;

namespace ExpansesApp.Core.Contexts.ExpanseContext.UseCases.Create;
public class CreateExpanseUseCase : ICreateExpanseUseCase
{
    private readonly IExpanseRepository _expanseRepository;
    public CreateExpanseUseCase(IExpanseRepository expanseRepository)
    {
        _expanseRepository = expanseRepository;
    }
    public async Task Create(Expanse expanse)
    {
        await _expanseRepository.CreateAsync(expanse);
    }
}
