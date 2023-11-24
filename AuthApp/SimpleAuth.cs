namespace AuthApp;

public class SimpleAuth : IAuth
{
    private const string Login = "user";
    private const string Password = "12345";
    
    public bool IsAuth(User user)
    {
        return user is { Login: Login, Password: Password };
    }
}