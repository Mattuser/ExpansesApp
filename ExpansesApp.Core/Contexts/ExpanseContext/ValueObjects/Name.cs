using ExpansesApp.Core.Contexts.SharedContext.ValueObjects;
using System.Xml.Linq;

namespace ExpansesApp.Core.Contexts.ExpanseContext.ValueObjects;
public class Name : ValueObject
{
    public Name(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new Exception("Nome não pode ser nulo ou vázio");

        Value = value.Trim().ToLower();

        if (value.Length < 3 && value.Length >= 40)
            throw new Exception("Nome deve conter entre 3 e 40 caracteres");
    }

    public string Value { get; } = string.Empty;

    public override string ToString()
        => Value;
}
