namespace HVexTransformer.Infra.Data.Settings;

public class HVexDatabaseSettings
{
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
    public string UserCollectionName { get; set; }
    public string TransformerCollectionName { get; set; }
    public string TestCollectionName { get; set; }
    public string ReportCollectionName { get; set; }
}