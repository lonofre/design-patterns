namespace DesignPatterns.Adapter;

/// <summary>
/// A square peg.
/// Example from: https://refactoring.guru/design-patterns/adapter
/// </summary>
/// <param name="width"></param>
public class SquarePeg(double width)
{
    public double Width { get; private set; } = width;
}