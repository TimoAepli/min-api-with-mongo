using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/check", () =>
{
    try
    {
        // Verbindung zur MongoDB aufbauen (Connection String direkt im Code)
        var connectionString = "mongodb://localhost:27017"; // Achtung: später konfigurierbar machen
        var client = new MongoClient(connectionString);

        // Alle Datenbanken abrufen
        var dbList = client.ListDatabaseNames().ToList();

        // Ergebnis-Text vorbereiten
        var result = "Zugriff auf MongoDB ok.\nGefundene Datenbanken:\n";
        result += string.Join("\n", dbList);
        return Results.Ok(result);
    }
    catch (Exception ex)
    {
        // Fehlerbehandlung: Fehlermeldung zurückgeben
        return Results.Problem("Fehler beim Zugriff auf MongoDB: " + ex.Message);
    }
});

app.Run();
