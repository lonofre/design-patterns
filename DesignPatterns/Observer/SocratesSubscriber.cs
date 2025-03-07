namespace DesignPatterns.Observer;

/// <summary>
/// Socrates adds a ? mark to every message it receives.
/// </summary>
public class SocratesSubscriber : ISubscriber
{

    public string State { get; private set; } = "";

    /// <summary>
    /// It updates Socrates' state. It just appends a
    /// interrogation mark at the end. 
    /// </summary>
    /// <param name="message"></param>
    public void Update(string message)
    {
       State = $"{message}?"; 
    }
}