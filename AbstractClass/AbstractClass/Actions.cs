namespace AbstractClass;

public abstract class Actions
{
    // Métodos obrigatórios
    public abstract void Speak();
    public abstract void Walk();
    
    // Métodos opcionais
    public void Jump()
    {
        Console.WriteLine("Jumping...");
    }
    

}