using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreRESTAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    public DemoController()
    {
        
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("GET- DemoController");
    }

    [HttpPost]
    public IActionResult Post()
    {
        return Ok("POST - DemoController");
    }

    [HttpPut]
    public IActionResult Put()
    {
        return Ok("PUT - DemoController");
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok("DELETE - DemoController");
    }
}
