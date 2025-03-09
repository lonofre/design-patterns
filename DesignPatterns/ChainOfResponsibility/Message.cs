namespace DesignPatterns.ChainOfResponsibility;

public class Message(string content, string hash)
{
    public string Content { get; } = content;
    public string Hash { get; } = hash;
}