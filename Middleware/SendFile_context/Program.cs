var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) => {
    string path = context.Request.Path;

    HttpResponse response = context.Response;

    response.Headers.ContentLanguage = context.Request.Headers.AcceptLanguage;

    if (File.Exists($"src{path}.txt"))
    {
        response.Headers.ContentDisposition = $"attachment; filename=server_text.txt";

        await response.SendFileAsync($"src{path}.txt");

        return;
    }

    if (File.Exists($"html{path}.html")){
        response.StatusCode = 200;
        response.ContentType = "text/html; charset=utf-8";

        await context.Response.SendFileAsync($"html{path}.html");
    }
    else{
        response.StatusCode = 404;

        await response.WriteAsync("<h1>Not Found</h1>"); 
    }
});

app.Run();
