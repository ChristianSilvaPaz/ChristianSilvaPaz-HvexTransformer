using MongoDB.Bson.Serialization.Attributes;

namespace HVexTransformer.Domain.Entities;

public class Transformer : Entity
{
    [BsonElement("id_user")]
    public string IdUser { get; private set; }

    [BsonElement("internal_number")]
    public int InternalNumber { get; private set; }

    [BsonElement("tension_class")]
    public int TensionClass { get; private set; }

    public int Potency { get; private set; }
    public int Current { get; private set; }

    public List<Test> Tests { get; private set; }

    public Transformer(string idUser, string name, int internalNumber, int tensionClass, int potency, int current)
    {
        IdUser = idUser;
        Name = name;
        InternalNumber = internalNumber;
        TensionClass = tensionClass;
        Potency = potency;
        Current = current;
        Created_at = DateTime.UtcNow;
    }

    public void UpdateTransformer(string idUser, string name, int internalNumber, int tensionClass, int potency, int current)
    {
        IdUser = idUser;
        Name = name;
        InternalNumber = internalNumber;
        TensionClass = tensionClass;
        Potency = potency;
        Current = current;
        Updated_at = DateTime.UtcNow;
    }

    public void AddTest(Test test)
    {
        Tests.Add(test);
    }
}
