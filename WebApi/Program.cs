var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/check", () => {
/* Code zur Prüfung der DB ...*/
return "Zugriff auf MongDB ok.";
});

app.Run();
