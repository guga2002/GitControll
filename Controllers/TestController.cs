using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitControll.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{

    [HttpGet("TestIt")]
    public IActionResult Test()
    {
        return Ok("Wrong Result!");
    }

    ///<summary>
    [HttpGet("TestIt2")]
    public IActionResult Test2()
    {
        return Ok("Right Result!");
    }

    /// <summary>
    /// 
    ///New New
}
