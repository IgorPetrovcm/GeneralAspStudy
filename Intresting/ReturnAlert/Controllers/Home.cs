namespace ReturnAlert;
using Microsoft.AspNetCore.Mvc;


public class Home : Controller
{
    public IActionResult Index() 
    {
        ViewBag.Message = "<script> alert('Okay') </script>";

        return View();
    }

}