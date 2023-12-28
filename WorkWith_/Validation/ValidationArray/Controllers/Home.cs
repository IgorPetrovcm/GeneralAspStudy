namespace ValidationArray;
using Microsoft.AspNetCore.Mvc;
using ValidationArray.Models;


public class Home : Controller
{
    public IActionResult Index() => View();

    [HttpPost]
    public string Index(object val)
    {
        if (ModelState.IsValid)
        {
            string a = "";
            if (val is string[])
            {
                a = Convert.ToString(val);
            }
            return a;
        }
        else{
            return "error";
        }
    }
} 