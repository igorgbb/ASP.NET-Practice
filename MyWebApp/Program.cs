var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
 git config --global user.email "bernardon.college@gmail.com"
 git config --global user.name "igorgbb"