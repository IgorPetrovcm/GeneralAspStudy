namespace ReturnAlert;
using Microsoft.AspNetCore.Mvc;


public class Home : Controller
{
    [HttpGet]
    public async Task Index() {
        await Response.WriteAsync(@"<!doctype html>
        <head> <meta charset=""utf-8""/>
                <title>Hello</title>
        </head>
        <body>
                <script> alert('Okay') </script>
        </body>
        ");
    }

}