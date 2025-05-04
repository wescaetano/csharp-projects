namespace ObjectOrientedPrograming;

// No C#, o "extends" do Java é representado por ':'
public class Colaborador : Pessoa
{
    private string? _cargo;
    private double _salario;

    public Colaborador()
    {
    }

    // Para passarmos os valores para a classe pai no c# usamos o 'base' depois do construtor
    // Seria como o 'super()' no Java
    public Colaborador(string nome, int idade, string cargo, double salario) : base(nome, idade)
    {
        _cargo = cargo;
        _salario = salario;
    }

    public string Cargo
    {
        get { return _cargo;}
        set { _cargo = value;}
    }

    public double Salario
    {
        get { return _salario;}
        set { _salario = value;}
    }

    public override string ToString()
    {
        return "Nome: " + Nome + ", idade: " + Idade.ToString() + ", cargo: " + _cargo + ", salário: " + _salario.ToString("F2");
    }
}