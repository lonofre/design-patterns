namespace DesignPatterns.FactoryMethod;

/// <summary>
/// The Wonderland world. It's the implementation
/// of a Factory.
/// </summary>
public class Wonderland : ICountry
{
    public ITaxpayer CreateTaxpayer()
    {
        return new Wonderlander();
    }
}