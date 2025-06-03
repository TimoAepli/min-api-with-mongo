using Microsoft.Extensions.Options;
using MongoDB.Driver;
public class MongoMovieService : IMovieService
{
    private readonly string _connectionString;
    // Constructor.
    // Settings werden per dependency injection übergeben.
    public MongoMovieService(IOptions<DatabaseSettings> options)
    {
        _connectionString = options.Value.ConnectionString;
    }
    public string Check()
    {
        try
        {
            var mongoClient = new MongoClient(_connectionString);
            var databaseNames = mongoClient.ListDatabaseNames().ToList();

            return "Zugriff auf MongoDB ok. Vorhandene DBs: " + string.Join(",", databaseNames);
        }
        catch (System.Exception e)
        {
            return "Zugriff auf MongoDB funktioniert nicht: " + e.Message;
        }
    }
}
