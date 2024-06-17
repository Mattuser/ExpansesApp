using ExpansesApp.Core.Contexts.SharedContext.Entities;

namespace ExpansesApp.Core.Contexts.ExpanseContext.Entities;
public class Expanse : Entity
{
    protected Expanse() 
    {
    }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public Category? Category { get; set; }
    public bool IsPaid { get; set; }
}
