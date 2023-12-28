namespace OneAction_MoreRequest;
using Microsoft.AspNetCore.Mvc;


public class Home : Controller
{
    public IActionResult Index() => View();

    public IActionResult Index(int age)
    {
        ViewData["One"] = age;
        return View();
    }

    public IActionResult Index(int ag, string name)
    {
        ViewData["Two"] = ag + " " + name;
        return View();
    }
} 