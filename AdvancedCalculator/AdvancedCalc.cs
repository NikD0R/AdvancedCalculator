using System;
// Advanced calculator

public class AdvancedCalc : OrdinaryCalc, IAdvanced
{
    public double ConvertDegreesToRadians(double degrees)
    {
        if (degrees < 0 || degrees >= 360)
        {
            throw new ArgumentOutOfRangeException("Значення градусів повинне бути в межах від 0 до 360.");
        }
        return degrees * (Math.PI / 180);
    }
}