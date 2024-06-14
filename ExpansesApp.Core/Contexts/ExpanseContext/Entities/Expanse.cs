using ExpansesApp.Core.Contexts.SharedContext.Entities;

namespace ExpansesApp.Core.Contexts.ExpanseContext.Entities;
public class Expanse : Entity
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; } = string.Empty;
    public Installment? Installment { get; set; }
    public bool IsPaid => RemainingInstallments == TotalInstallments;
    public bool IsInstallment { get; set; } = false;
    public int TotalInstallments { get; set; }
    public int RemainingInstallments { get; set; }
}
