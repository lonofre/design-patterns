namespace DesignPatterns.Observer;


/// <summary>
/// It sends messages to its subscribers.
/// </summary>
public class Publisher
{
    private readonly List<ISubscriber> _subscribers = [];

    /// <summary>
    /// It adds a new subscriber.
    /// </summary>
    /// <param name="subscriber">The new subscriber to add.</param>
    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    /// <summary>
    /// It removes a subscriber from the list and will no longer receive
    /// messages.
    /// </summary>
    /// <param name="subscriber">The subscriber to remove.</param>
    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    /// <summary>
    /// It sends a message to all its subscribers.
    /// </summary>
    /// <param name="message">The message to send.</param>
    public void Notify(string message)
    {
        foreach (var subscriber in _subscribers)
        {
           subscriber.Update(message); 
        }
    }
}