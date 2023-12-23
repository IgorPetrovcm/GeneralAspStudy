namespace Task1;

using Microsoft.AspNetCore.Mvc;


public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(IFormFile file)
    {
        if (!new[] {".txt",".csv"}.Any(c => file.FileName.Contains(c))) return BadRequest("File extension not correct");
        /*using (Stream stream = file.OpenReadStream()) 
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                string a = Path.GetExtension(reader)
            }
            
        }*/
        ViewData["Message"] = file.FileName;
        return View("~/Views/Home/File.cshtml");
    }
} 
