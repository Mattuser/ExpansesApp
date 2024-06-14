using ExpansesApp.Core.Contexts.SharedContext.Entities;

namespace ExpansesApp.Core.Contexts.ExpanseContext.Entities;
public class Expanse : Entity
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; } = string.Empty;
    public Installment? Installment { get; set; }
    public bool IsPaid { get; set; } //Campo processado
    public bool isInstallment { get; set; } = false;
    public int TotalInstallments { get; set; }
    public int RemainingInstallments { get; set; }


}
