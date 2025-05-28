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
        return "Zugriff auf MongoDB ...";
    }
}
