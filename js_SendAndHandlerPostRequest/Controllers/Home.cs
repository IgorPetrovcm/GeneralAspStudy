namespace App;
using Microsoft.AspNetCore.Mvc;


public class Home : Controller
{
    public IActionResult Index()
    {
        ViewBag.Message = "test";
        return View();
    }
    [HttpPost]
    public IActionResult Index(string value)
    {
        ViewBag.Message = value;
        return View("~/Views/Home/test.cshtml");
    }
}