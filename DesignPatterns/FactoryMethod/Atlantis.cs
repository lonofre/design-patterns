namespace DesignPatterns.FactoryMethod;

/// <summary>
/// This represents Atlantis country. Also, it's the
/// implementation of a Factory o Creator.
/// </summary>
public class Atlantis : ICountry
{
    public ITaxpayer CreateTaxpayer()
    {
        return new Atlantean();
    }
    
}