namespace Lab6;

public class OrganicProduct : Product
{
    public OrganicProduct(string name, double price, string description) : base(name, price, description)
    {
        
    }

    public override double GetPrice()
    {
        return Price;
    }

    public override string GetDescription()
    {
        return Description;
    }
}
