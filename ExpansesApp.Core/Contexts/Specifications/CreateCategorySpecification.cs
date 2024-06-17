using ExpansesApp.Core.Contexts.ExpanseContext.UseCases.Create;
using Flunt.Notifications;
using Flunt.Validations;

namespace ExpansesApp.Core.Contexts.Specification;
public static class CreateCategorySpecification
{
    public static Contract<Notification> Ensure(CreateCategoryRequest request)
        => new Contract<Notification>()
            .Requires()
                .IsGreaterThan(request.Name.Length, 3, "Name", "Nome deve conter menos que 40 caracteres")
                .IsLowerThan(request.Name.Length, 40, "Name", "Nome deve conter mais de 3 caracteres");
}
