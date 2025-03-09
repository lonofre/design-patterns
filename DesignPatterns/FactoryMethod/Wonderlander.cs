namespace DesignPatterns.FactoryMethod;


/// <summary>
/// Wonderland citizen.
/// </summary>
public class Wonderlander : ITaxpayer
{
    public int Salary { get; set; }
    public double CalculateTaxesToPay()
    {
        return Salary switch
        {
            <= 0 => 50,
            < 10000 => Salary * 0.5,
            _ => Salary * 0.2,
        };
    }
}