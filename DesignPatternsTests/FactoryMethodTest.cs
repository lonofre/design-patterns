using DesignPatterns.FactoryMethod;

namespace DesignPatternsTests;

public class FactoryMethodTest
{
    private static object[] _taxpayers =
    [
        new object[] { new Atlantis(), 1000, 100},
        new object[] { new Atlantis(), 2000000, 400000},
        new object[] { new Wonderland(), 0, 50},
        new object[] { new Wonderland(), 1000, 500}
    ];

    [TestCaseSource(nameof(_taxpayers))]
    public void TaxpayerPayTaxes(ICountry country, int salary, double expectedTax)
    {
        // The magic here it that this method doesn't
        // know about the implementations of each interface.
        var taxpayer = country.CreateTaxpayer();
        taxpayer.Salary = salary;

        var toPay = taxpayer.CalculateTaxesToPay();
        
        Assert.That(toPay, Is.EqualTo(expectedTax));
    }
}
    