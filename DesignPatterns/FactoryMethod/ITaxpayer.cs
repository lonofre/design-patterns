namespace DesignPatterns.FactoryMethod;


/// <summary>
/// A person who pay taxes
/// </summary>
public interface ITaxpayer
{
    
    /// <summary>
    /// Person's current salary.
    /// </summary>
    public int Salary { get; set; }

    
    /// <summary>
    /// It returns the taxes the person should pay.
    /// </summary>
    /// <returns>The quantity to pay</returns>
    public double CalculateTaxesToPay();

}