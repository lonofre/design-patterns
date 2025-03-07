namespace DesignPatterns.Adapter;

/// <summary>
/// Round peg.
/// Example from: https://refactoring.guru/design-patterns/adapter
/// </summary>
public class RoundPeg(double radius) : IRound
{
    public double Radius { get; } = radius;
}