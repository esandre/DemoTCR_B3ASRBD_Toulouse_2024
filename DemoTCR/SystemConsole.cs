namespace DemoTCR;

internal class SystemConsole : IConsole
{
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}