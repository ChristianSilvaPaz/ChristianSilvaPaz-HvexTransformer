using HVexTransformer.Domain.Entities;
using HVexTransformer.Infra.Data.Settings;
using MongoDB.Driver;

namespace HVexTransformer.Infra.Context;

public class HVexDbContext
{
    public readonly IMongoCollection<User> Users;

    public readonly IMongoCollection<Report> Reports;

    public readonly IMongoCollection<Transformer> Transformes;

    public readonly IMongoCollection<Test> Tests;

    public HVexDbContext(HVexDatabaseSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);

        Users = database.GetCollection<User>(settings.UserCollectionName);
        Reports = database.GetCollection<Report>(settings.ReportCollectionName);
        Transformes = database.GetCollection<Transformer>(settings.TransformerCollectionName);
        Tests = database.GetCollection<Test>(settings.TestCollectionName);
    }
}
