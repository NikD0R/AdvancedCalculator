// AbstractCalc.cs
public abstract class AbstractCalc
{
    public string Model { get; set; } = "Standard Calculator";

    public string GetModel() => Model;

    public abstract double Add(double a, double b);
    public abstract double Subtract(double a, double b);
    public abstract double Multiply(double a, double b);
    public abstract double Divide(double a, double b);
}