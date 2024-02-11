namespace Domain.Model;

public class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }
    public User(int id,string name)
    {
        UserId=id;
        Name=name;
    }

}
