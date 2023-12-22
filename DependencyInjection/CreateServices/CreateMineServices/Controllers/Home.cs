namespace CreateMineServices.Controllers;
using Microsoft.AspNetCore.Mvc;
using CreateMineServices.Services;

public class HomeController : Controller
{
    private ITimeService timeService;

    public HomeController(ITimeService service)
    {
        timeService = service;
    }

    public string Index() => timeService.GetTime();
}