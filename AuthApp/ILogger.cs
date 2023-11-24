namespace AuthApp;

public interface ILogger
{
    public void Info(string message);
    public void Success(string message);
    
    public void Error(string message);
}