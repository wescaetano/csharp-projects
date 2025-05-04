namespace ObjectOrientedPrograming;

public class Pessoa
{
    private string? _nome;
    private int _idade;
    
    public Pessoa()
    {
    }
    
    public Pessoa(string _nome, int _idade)
    {
        Nome = _nome;
        Idade = _idade;
    }
    
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    
    public int Idade    
    {
        get { return _idade; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Idade não pode ser negativa.");
            }
            _idade = value;
        }
    }

    public override string ToString()
    {
        return "Nome: " + _nome + ", idade: " + _idade.ToString();
    }
}