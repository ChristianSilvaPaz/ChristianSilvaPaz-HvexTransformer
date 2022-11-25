using HVexTransformer.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace HVexTransformer.Domain.Entities;

public class Report : Entity
{
    [BsonElement("transformer_id")]
    public string TransformerId { get; private set; }

    [BsonElement("teste_id")]
    public string TestId { get; private set; }

    public ReportStatus Status { get; private set; }

    public Report(string name, TestStatus status, string transformerId, string testId)
    {
        Name = name;
        Status = Status;
        TransformerId = transformerId;
        TestId = testId;
        Created_at = DateTime.UtcNow;
    }

    public void UpdateReport(string name, ReportStatus status, string transformerId, string testId)
    {
        Name = name;
        Status = status;
        TransformerId = transformerId;
        TestId = testId;
        Updated_at = DateTime.UtcNow;
    }
}
