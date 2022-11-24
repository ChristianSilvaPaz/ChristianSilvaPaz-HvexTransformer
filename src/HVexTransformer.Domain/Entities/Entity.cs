using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HVexTransformer.Domain.Entities;

public abstract class Entity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; protected set; }

    public string Name { get; protected set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}
