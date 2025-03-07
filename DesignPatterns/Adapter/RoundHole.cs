namespace DesignPatterns.Adapter;


/// <summary>
/// A round hole.
/// Example from: https://refactoring.guru/design-patterns/adapter
/// </summary>
public class RoundHole(double radius) : IRound
{
    public double Radius { get; } = radius;

    /// <summary>
    /// It indicates whether a peg fits in the hole.
    /// </summary>
    /// <param name="peg">A round shaped peg.</param>
    /// <returns></returns>
    public bool Fits(IRound peg)
    {
        return Radius >= peg.Radius;
    }
}