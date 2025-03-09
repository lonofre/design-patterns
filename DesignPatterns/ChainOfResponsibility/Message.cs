namespace DesignPatterns.ChainOfResponsibility;

/// <summary>
/// A message with its hash.
/// </summary>
/// <param name="content">The message's content.</param>
/// <param name="hash">The message's content hash</param>
public class Message(string content, string hash)
{
    public string Content { get; } = content;
    public string Hash { get; } = hash;
}