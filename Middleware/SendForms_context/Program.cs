using System.Text;
using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) => {
    if (File.Exists($"html{context.Request.Path}.html"))
    {
        /*StringBuilder str = new StringBuilder();


        foreach (KeyValuePair<string, StringValues> element in form)
        {
            str.Append(element.Key + " " + element.Value);
        }*/

        IFormCollection form = context.Request.Form;

        StringValues name = form["name"];
        StringValues age = form["age"];

        await context.Response.WriteAsync(name + " " + age);
    }
    else {
        await context.Response.SendFileAsync("html/Index.html");
    }
});

app.Run();
