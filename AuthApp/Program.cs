using AuthApp;

var userOk = new User()
{
    Login = "user",
    Password = "12345",
};

var userBad = new User()
{
    Login = "admin",
    Password = "123",
};

var auth = new LoggerAuth(new SimpleAuth(), new LogToConsole());

Console.WriteLine(auth.IsAuth(userOk) ? "OK" : "ERROR");
Console.WriteLine(auth.IsAuth(userBad) ? "OK" : "ERROR");