namespace Polymorphism;

public class Animal
{
    // O 'virtual' é o que permite o método ser sobrescrito quando herdado por uma subclasse.
    public virtual void Sound()
    {
        Console.WriteLine("Unkown animal...");
    }
}