namespace Lab6;

public abstract class Product : IProduct
{
    public readonly string name;
    public double Price { get; protected set; }
    public string Description { get; protected set; }

    protected Product(string name, double price, string description)
    {
        this.name = name;
        this.Price = price;
        this.Description = description;
    }

    public abstract double GetPrice();
    public abstract string GetDescription();

    public override string ToString()
    {
        return $"{name}: {Description}, цена {Price}";
    }
    public override bool Equals(object obj)
    {
        var other = obj as Product;

        if (other == null)
            return false;

        return this.name == other.name && this.Price == other.Price && this.Description == other.Description;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(name, Price, Description);
    }

}

