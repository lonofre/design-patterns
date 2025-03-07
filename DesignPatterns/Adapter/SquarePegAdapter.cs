namespace DesignPatterns.Adapter;

/// <summary>
/// It adapts a square peg (that is not rounded), so RoundHole
/// can use it to check if the peg fits.
/// Example from: https://refactoring.guru/design-patterns/adapter
/// </summary>
/// <param name="peg"></param>
public class SquarePegAdapter(SquarePeg peg) : IRound
{
    private readonly SquarePeg _peg = peg;

    public double Radius => _peg.Width * Math.Sqrt(2) / 2;
}