namespace DesignPatterns.ChainOfResponsibility;

public interface IHandler
{
    
    public void SetHandler(IHandler handler);

    public bool Handle(Message message);

}