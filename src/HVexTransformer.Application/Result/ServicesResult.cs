namespace HVexTransformer.Application.Result;

public class ServicesResult
{
    public List<Notification> Errors { get; set; }

    public ServicesResult()
    {
        Errors = new List<Notification>();
    }

    public void AddErrors(string field, string message)
    {
        Errors.Add(new Notification(field, message));
    }
}

public class ServicesResult<T> : ServicesResult
{
    public T Data { get; set; }

    public ServicesResult() : base()
    {
    }

    public ServicesResult(T data) : base()
    {
        Data = data;
    }

    public ServicesResult<T> WithData(T data)
    {
        Data = data;
        return this;
    }
}

