using ExpansesApp.Core.Contexts.ExpanseContext.Contracts.UseCases;
using ExpansesApp.Core.Contexts.ExpanseContext.UseCases.Create;
using Microsoft.AspNetCore.Mvc;

namespace ExpansesApp.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICreateCategoryUseCase _createCategoryUseCase;
    public CategoryController(ICreateCategoryUseCase createCategoryUseCase)
    {
        _createCategoryUseCase = createCategoryUseCase;
    }
    [HttpPost]
    public async Task<IResult> Create(CreateCategoryRequest request)
    {
        var result = await _createCategoryUseCase.Execute(request, new CancellationToken());
        return result.IsSuccess
            ? Results.Created("/category", result)
            : Results.Json(result, statusCode: result.Status);
    }
}
