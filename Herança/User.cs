public abstract class  User 
{
    protected string type { get; set; }
    protected string name { get; set; }
    protected int age { get; set; }

    public User(string type, string name, int age)
    {
        this.age = age;
        this.type = type;
        this.name = name;
    }

    public User() { }

    public abstract string GetUserName();
    public abstract string GetUserType();
    public abstract int GetAge();
}