using ExpansesApp.Core.Contexts.ExpanseContext.Contracts.Repositories;
using ExpansesApp.Core.Contexts.ExpanseContext.Contracts.UseCases;
using ExpansesApp.Core.Contexts.ExpanseContext.UseCases.Create;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICategoryRepository>();
builder.Services.AddScoped<ICreateCategoryUseCase, CreateCategoryUseCase>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
