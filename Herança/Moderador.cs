using System.Globalization;

public class Moderador : User
{
    public Moderador(string type, string name, int age) : base(type, name, age)
    {
        this.type = type;
        this.name = name;
        this.age = age;
    }

    public override string GetUserName()
    {
        return this.name;
    }

    public override string GetUserType()
    {
        return this.type;
    }

    public override int GetAge()
    {
        return this.age;
    } 
}
