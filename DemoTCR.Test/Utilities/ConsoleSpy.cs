namespace DemoTCR.Test.Utilities;

internal class ConsoleSpy : IConsole
{
    public string Contenu { get; private set; }

    public void Write(string message)
    {
        Contenu = message;
    }
}