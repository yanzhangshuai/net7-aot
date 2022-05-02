using Microsoft.AspNetCore.Mvc;

namespace net7_aot.Controllers;

[ApiController]
[Route("[controller]")]
public class AppController : ControllerBase
{
    [HttpGet("Hello")]
    public string Get()
    {
        return "Hello ASP .NET";
    }
}