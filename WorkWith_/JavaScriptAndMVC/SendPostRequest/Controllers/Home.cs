namespace SendPostRequest;
using Microsoft.AspNetCore.Mvc;
using SendPostRequest.Models;

[Route("api/Home")]
[ApiController]
public class Home : Controller
{
    [HttpGet]
    public IActionResult Index() => View();
    [HttpPost]
    public IActionResult Index([FromBody]Test value) {
        return Ok(value);
    }
}