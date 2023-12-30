namespace Alternative;
using Microsoft.AspNetCore.Mvc;
using Alternative.Models;


public class Home : Controller
{
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(string[] values)
    {
        if (Check.IsValid(values))
        {
            ViewBag.Message = 0;
            return View();
        }
        else {
            ViewBag.Message = 1;
            return View();
        }
    }
}