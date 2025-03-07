using DesignPatterns.Adapter;

namespace DesignPatternsTests;

[TestFixture]
public class AdapterTest
{

    [TestCase(19, 20)]
    [TestCase(20, 20)]
    public void RoundPegFits(double pegRadius, double holeRadius)
    {
        var peg = new RoundPeg(pegRadius);
        var hole = new RoundHole(holeRadius);

        var fits = hole.Fits(peg);
        
        Assert.That(fits, Is.True);
    }

    [TestCase(21, 20)]
    [TestCase(30, 20)]
    public void RoundPegDoesNotFit(double pegRadius, double holeRadius)
    {
        var peg = new RoundPeg(pegRadius);
        var hole = new RoundHole(holeRadius);

        var fits = hole.Fits(peg);
        
        Assert.That(fits, Is.False);
    }

    [Test]
    public void SquarePegFits()
    {
        var peg = new SquarePeg(19);
        var hole = new RoundHole(30);
        var adapter = new SquarePegAdapter(peg);
        
        // The adapter uses a common interface shared with
        // the hole object, so it's possible to do this.
        var fits = hole.Fits(adapter);
        
        Assert.That(fits, Is.True);
    }
    
    [Test]
    public void SquarePegDoesNotFit()
    {
        var peg = new SquarePeg(20);
        var hole = new RoundHole(10);
        var adapter = new SquarePegAdapter(peg);
        
        var fits = hole.Fits(adapter);
        
        Assert.That(fits, Is.False);
    }
    
}