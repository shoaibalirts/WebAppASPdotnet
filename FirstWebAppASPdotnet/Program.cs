var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//app.MapGet("/", () => "Hello World123!");
app.Run(async (HttpContext context) =>
{
    context.Response.StatusCode = 200;
    context.Response.Headers["MyName"] = "Shoaib Ali";
    context.Response.Headers["Date"] = "23-05-2026";

    await context.Response.WriteAsync("Hello");
    await context.Response.WriteAsync("World");

});

app.Run();
