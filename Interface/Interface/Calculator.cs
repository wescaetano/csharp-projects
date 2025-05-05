namespace Interface;

public class Calculator : ICalculatorBase, IAdvancedCalculator
{
    public double Sum(double a, double b)
    {
        return a + b;
    }

    public double Subtraction(double a, double b)
    {
        return a - b;
    }

    public double Multiplication(double a, double b)
    {
        return a * b;
    }

    public double Division(double a, double b)
    {
        return a / b;
    }

    public double Tangent(double degrees)
    {
        double radians = degrees * (Math.PI / 180);
        double tangent = Math.Tan(radians);
        return tangent;
    }

    public double Sine(double degrees)
    {
        double radians = degrees * (Math.PI / 180);
        double sine = Math.Sin(radians);
        return sine;
    }

    public double Cosine(double degrees)
    {
        double radians = degrees * (Math.PI / 180);
        double cosine = Math.Cos(radians);
        return cosine;
    }
}