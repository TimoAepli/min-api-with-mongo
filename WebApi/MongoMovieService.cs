using Microsoft.Extensions.Options;
using MongoDB.Driver;
public class MongoMovieService : IMovieService
{
    // Constructor.
    // Settings werden per dependency injection übergeben.
    public MongoMovieService(IOptions<DatabaseSettings> options)
    { }
    public string Check()
    {
        return "test";
        /*try
        {
            var mongoDbConnectionString = options.Value.ConnectionString;
            var mongoClient = new MongoClient(mongoDbConnectionString);
            var databaseNames = mongoClient.ListDatabaseNames().ToList();

            return "Zugriff auf MongoDB ok. Vorhandene DBs: " + string.Join(",", databaseNames);
        }
        catch (System.Exception e)
        {
            return "Zugriff auf MongoDB funktioniert nicht: " + e.Message;
        }*/

    }
}
