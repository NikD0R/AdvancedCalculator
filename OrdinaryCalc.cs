// OrdinaryCalc.cs
using System;

public class OrdinaryCalc : AbstractCalc
{
    public override double Add(double a, double b) => a + b;

    public override double Subtract(double a, double b) => a - b;

    public override double Multiply(double a, double b) => a * b;

    public override double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Помилка: Ділення на нуль.");
        }
        return a / b;
    }
}
