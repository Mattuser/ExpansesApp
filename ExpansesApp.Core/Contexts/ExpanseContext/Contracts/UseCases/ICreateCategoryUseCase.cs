using ExpansesApp.Core.Contexts.ExpanseContext.UseCases.Create;

namespace ExpansesApp.Core.Contexts.ExpanseContext.Contracts.UseCases;

public interface ICreateCategoryUseCase
{
    public Task<Response> Execute(CreateCategoryRequest createCategoryRequest, CancellationToken cancellation);
}
