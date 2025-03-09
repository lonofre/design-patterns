namespace DesignPatterns.FactoryMethod;

/// <summary>
/// Atlantis citizen.
/// </summary>
public class Atlantean : ITaxpayer
{
    public int Salary { get; set; }
    
    public double CalculateTaxesToPay()
    {
        return Salary switch
        {
            <= 0 => 0,
            < 100000 => Salary * 0.1,
            _ => Salary * 0.2
        };
    }
}