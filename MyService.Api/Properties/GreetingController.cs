using Microsoft.AspNetCore.Mvc;
using MyService.Api.Services;

namespace MyService.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    private readonly GreetingService _greeting;

    public GreetingController(GreetingService greeting)
    {
        _greeting = greeting;
    }

    [HttpGet("{name?}")]
    public ActionResult<string> Get(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return BadRequest("Name cannot be null or empty");

        return _greeting.GetGreeting(name);
    }
}
