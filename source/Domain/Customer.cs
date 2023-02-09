namespace Architecture.Domain;

public sealed class Customer : Entity
{
    public Customer(long id, string name) : this(name) => Id = id;

    public Customer(string name) => Name = name;

    public string Name { get; }
}
