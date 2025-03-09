namespace DesignPatterns.ChainOfResponsibility;

public class LengthChecker(int maxLength) : IHandler
{
    
    private IHandler? _nextHandler = null;
    private readonly int _maxLength = maxLength;
    
    public void SetHandler(IHandler handler)
    {
       _nextHandler = handler; 
    }

    public bool Handle(Message message)
    {
        if (message.Content.Length > _maxLength) return false;
        return _nextHandler == null || _nextHandler.Handle(message);
    }
}