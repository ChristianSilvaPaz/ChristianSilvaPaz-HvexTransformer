using HVexTransformer.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace HVexTransformer.Domain.Entities;

public class Test : Entity
{
    public TestStatus Status { get; private set; }

    [BsonElement("duration_in_seconds")]
    public int DurationInSeconds { get; private set; }

    public Test(string name, int durationInSeconds)
    {
        Status = TestStatus.Issued;
        Name = name;
        DurationInSeconds = durationInSeconds;
        Created_at = DateTime.UtcNow;
    }

    public void UpdateTest(string name, int durationInSeconds, TestStatus status)
    {
        Name = name;
        DurationInSeconds = durationInSeconds;
        Status = status;
        Updated_at = DateTime.UtcNow;
    }
}
