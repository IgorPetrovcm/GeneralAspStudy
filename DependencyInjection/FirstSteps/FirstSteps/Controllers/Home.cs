using System.Collections.Specialized;

namespace MvcApp;
using Microsoft.AspNetCore.Mvc;
using System.Text;


public class HomeController : Controller
{
    public IActionResult Index()
    {
        IServiceCollection services = WebApplication.CreateBuilder().Services;

        StringCollection strCollection = new StringCollection();
        
        foreach (ServiceDescriptor serviceDescript in services)
        {
            strCollection.Add(
                $"{serviceDescript.ServiceType}\t{serviceDescript.ImplementationType}\t{serviceDescript.Lifetime}");
        }

        ViewBag.Message = strCollection;
        return View();
    }
}