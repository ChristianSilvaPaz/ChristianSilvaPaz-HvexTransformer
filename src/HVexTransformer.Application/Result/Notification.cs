namespace HVexTransformer.Application.Result;

public class Notification
{
    public string Field { get; protected set; }
    public string Message { get; protected set; }

    public Notification(string field, string message)
    {
        Field = field;
        Message = message;  
    }
}
