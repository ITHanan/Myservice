namespace MyService.Api.Services
{
    public class GreetingService
    {
        public string GetGreeting(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Hello, guest!";
            return $"Hello, {name}!";
        }
    }
}
