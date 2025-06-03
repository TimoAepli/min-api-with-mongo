using Microsoft.Extensions.Options;
using MongoDB.Driver;

public class MongoMovieService : IMovieService
{
    private readonly IMongoCollection<Movie> _movieCollection;
    private const string mongoDbDatabaseName = "gbs";
    private const string mongoDbCollectionName = "movies";

    public MongoMovieService(IOptions<DatabaseSettings> options)
    {
        var mongoDbConnectionString = options.Value.ConnectionString;

        var mongoClient = new MongoClient(mongoDbConnectionString);
        var database = mongoClient.GetDatabase(mongoDbDatabaseName);
        _movieCollection = database.GetCollection<Movie>(mongoDbCollectionName);
    }

    public string Check()
    {
        try
        {

            return "Zugriff auf MongoDB ok. Vorhandene DBs: " + string.Join(",", _movieCollection);
        }
        catch (System.Exception e)
        {
            return "Zugriff auf MongoDB funktioniert nicht: " + e.Message;
        }
    }



    public void Create(Movie movie)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Movie> Get()
    {
        throw new NotImplementedException();
    }
    public Movie Get(string id)
    {
        throw new NotImplementedException();
    }
    public void Update(string id, Movie movie)
    {
        throw new NotImplementedException();
    }
    public void Remove(string id)
    {
        throw new NotImplementedException();
    }
}