namespace DesignPatterns.Observer;

/// <summary>
/// This is a dummy subscriber. The only thing that does is to replace
/// "a" for "o" in its state.
/// </summary>
public class DummySubscriber : ISubscriber
{
    
    /// <summary>
    /// A string that keeps the last saved message.
    /// </summary>
    public string State { get; private set; } = "";

    /// <summary>
    /// It updates Dummy state. Replaces each "a" for "o" in the message.
    /// </summary>
    /// <param name="message">Just a regular message.</param>
    public void Update(string message)
    {
        State = message.Replace(oldValue: "a", newValue: "o");
    }
}