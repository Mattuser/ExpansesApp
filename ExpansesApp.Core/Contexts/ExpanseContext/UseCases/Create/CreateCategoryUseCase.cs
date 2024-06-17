using ExpansesApp.Core.Contexts.ExpanseContext.Contracts.Repositories;
using ExpansesApp.Core.Contexts.ExpanseContext.Contracts.UseCases;
using ExpansesApp.Core.Contexts.ExpanseContext.Entities;
using ExpansesApp.Core.Contexts.ExpanseContext.ValueObjects;
using static ExpansesApp.Core.Contexts.ExpanseContext.UseCases.Create.Response;

namespace ExpansesApp.Core.Contexts.ExpanseContext.UseCases.Create;
public class CreateCategoryUseCase : ICreateCategoryUseCase
{
    private readonly ICategoryRepository _categoryRepository;
    public CreateCategoryUseCase(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public async Task<Response> Execute(CreateCategoryRequest request, CancellationToken cancellationToken)
    {
        Name Name;
        Category Category;

        try
        {
            Name = new Name(request.Name);
            Category = new Category(request.Name);
        }
        catch(Exception ex)
        {
            return new Response(ex.Message, 400);
        }

        try
        {
            var exists = _categoryRepository.AnyAsync(request.Name, cancellationToken);
        }
        catch 
        {
            return new Response("Falha ao verificar Categoria cadastrada", 500);
        }

        try
        {
            await _categoryRepository.SaveAsync(Category, cancellationToken);
        }

        catch
        {
            return new Response("Falha ao persistir os dados", 500);
        }

        return new Response("Categoria Criada", new ResponseData(Category.Id, Category.Name));
    }
}
