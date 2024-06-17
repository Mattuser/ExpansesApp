using ExpansesApp.Core.Contexts.SharedContext.Entities;

namespace ExpansesApp.Core.Contexts.ExpanseContext.Entities;
public class Category : Entity
{
    public Category()
    {
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public Category(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("Nome não pode ser nulo ou vázio");

        if (name.Length < 3 && name.Length  >= 40)
            throw new Exception("Nome deve conter entre 3 e 40 caracteres");


        Name = name;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public string Name { get; set; } = string.Empty;
    public List<Expanse>? Expanses { get; set; } = new();
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; }

}
