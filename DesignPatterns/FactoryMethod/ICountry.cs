namespace DesignPatterns.FactoryMethod;

/// <summary>
/// It represents a world country and our Factory
/// for this example.
/// </summary>
public interface ICountry
{
    
    /// <summary>
    /// It creates the taxpayer for a country.
    /// </summary>
    /// <returns></returns>
    public ITaxpayer CreateTaxpayer();
    
}