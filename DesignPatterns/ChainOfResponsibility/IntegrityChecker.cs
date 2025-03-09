using System.Text;

namespace DesignPatterns.ChainOfResponsibility;

using System.Security.Cryptography;

/// <summary>
/// It verifies the message has not been changed.
/// </summary>
public class IntegrityChecker : IHandler
{
    private IHandler? _nextHandler = null;
    public void SetHandler(IHandler handler)
    {
        _nextHandler = handler;
    }

    public bool Handle(Message message)
    {
        var hash = _GetHash(message.Content);
        var hashesAreEqual = hash == message.Hash;

        if (!hashesAreEqual) return false;
        return _nextHandler == null || _nextHandler.Handle(message);
    }

    private static string _GetHash(string input)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
        return Convert.ToHexString(bytes).ToLower();
    }

}