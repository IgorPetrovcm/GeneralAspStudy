using System.Text;
using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) => {
    IQueryCollection query = context.Request.Query;
    StringBuilder strQueryCollection = new StringBuilder();
    foreach (KeyValuePair<string, StringValues> queryPair in query)
    {
        strQueryCollection.Append($"<p>{queryPair.Key}: {queryPair.Value}");
    }

    StringValues userContentLanguage = context.Request.Headers.AcceptLanguage;

    string path = context.Request.Path;

    long? userContentLength = context.Request.ContentLength;

    HttpResponse response = context.Response;

    response.Headers.ContentLanguage = userContentLanguage; 
    response.Headers.ContentType = @"text/html; charset=""utf-8"" ";

    response.Headers.Append("Creator-of-the-Site", "IgorDeveloper");

    response.StatusCode = 200;

    await response.WriteAsync(@$"<h1>Hello</h1> <p>Path: {path} </p> {strQueryCollection.ToString()}");
});

app.Run();
