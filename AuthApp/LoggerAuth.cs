namespace AuthApp;

public class LoggerAuth : IAuth
{
    private readonly IAuth _auth;

    private readonly ILogger _logger;

    public LoggerAuth(IAuth auth, ILogger logger)
    {
        _auth = auth;
        _logger = logger;
    }

    public bool IsAuth(User user)
    {
        var result = _auth.IsAuth(user);
        if (result)
        {
            _logger.Success($"{user.Login} is now authenticated.");
        }
        else
        {
            _logger.Error($"{user.Login} is now not authenticated.");
        }

        return result;
    }
}