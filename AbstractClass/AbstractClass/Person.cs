namespace AbstractClass;

public class Person : Actions
{
    public override void Speak()
    {
        Console.WriteLine("Speaking...");
    }

    public override void Walk()
    {
        Console.WriteLine("Walking...");
    }
}