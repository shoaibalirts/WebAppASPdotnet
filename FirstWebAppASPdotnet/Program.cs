var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//app.MapGet("/", () => "Hello World123!");
app.Run(async (HttpContext context) =>
{
    /*
    context.Response.StatusCode = 200;
    context.Response.Headers["MyName"] = "Shoaib Ali";
    context.Response.Headers["Date"] = "23-05-2026";
    */
    /*
    string path = context.Request.Path;
    string method = context.Request.Method;
    context.Response.Headers["Content-Type"] = "text/html";
    if (path == "/")
    {
        await context.Response.WriteAsync($"<p>Root</p>");
    }
    else if (path == "/home")
    {
        await context.Response.WriteAsync($"<p>Root</p>");
        await context.Response.WriteAsync($"<p>{method}</p>");

    }
    else if (path == "/about")
    {
        await context.Response.WriteAsync($"<li>About me</li>");
    }
    else
    {
        await context.Response.WriteAsync($"<p>{path}</p>");

    }
    */
    context.Response.Headers["Content-type"] = "text/html";
    if (context.Request.Method == "GET")
    {
        if (context.Request.Query.ContainsKey("id"))// Query is a dictionary
        {
            string id = context.Request.Query["id"];
            await context.Response.WriteAsync($"<p>{id}</p>");
        }

    }
});

app.Run();
