namespace HVexTransformer.Domain.Entities;

public class User : Entity
{
    public string Email { get; private set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
        Created_at = DateTime.UtcNow;
    }

    public void UpdateUser(string name, string email)
    {
        Name = name;
        Email = email;
        Updated_at = DateTime.UtcNow;
    }
}
