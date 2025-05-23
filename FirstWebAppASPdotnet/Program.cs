var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

<<<<<<< HEAD
app.MapGet("/", () => "Hello Worldxxcdxc123!");
=======
app.MapGet("/", () => "Hello World123!");
>>>>>>> 147de4bb9fc7cb5e58184770a7df600c312ca313

app.Run();
