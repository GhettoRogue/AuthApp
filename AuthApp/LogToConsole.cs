namespace AuthApp;

public class LogToConsole : ILogger
{
    private void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    public void Info(string message)
    {
        Print($"{DateTime.Now:g}, [{nameof(Info).ToUpper()}], ", ConsoleColor.Blue);
    }

    public void Success(string message)
    {
        Print($"{DateTime.Now:g}, [{nameof(Success).ToUpper()}], ", ConsoleColor.Green);
    }

    public void Error(string message)
    {
        Print($"{DateTime.Now:g}, [{nameof(Error).ToUpper()}], ", ConsoleColor.Red);
    }
}