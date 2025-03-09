namespace DesignPatterns.ChainOfResponsibility;

/// <summary>
/// Just checks
/// </summary>
public class GreetingChecker : IHandler
{
    
    private IHandler? _nextHandler = null;
    
    public void SetHandler(IHandler? handler)
    {
       _nextHandler = handler; 
    }

    public bool Handle(Message message)
    {
        var messageContent = message.Content.ToLower();
        if (!messageContent.Contains("hello")) return false;
        return _nextHandler == null || _nextHandler.Handle(message);
    }
}