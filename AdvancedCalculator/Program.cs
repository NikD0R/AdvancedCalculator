using System;

public class MainClass
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Виберіть режим роботи калькулятора: '1' - стандартний, '2' - інженерний, або 'q' для виходу.");
            string mode = Console.ReadLine();

            if (mode.ToLower() == "q")
            {
                Console.WriteLine("Програма завершена.");
                break;
            }

            try
            {
                if (mode == "1")
                {
                    AbstractCalc calc = new OrdinaryCalc();
                    Console.WriteLine($"Використовується модель: {calc.GetModel()}");

                    Console.Write("Введіть перше число: ");
                    double operand1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введіть друге число: ");
                    double operand2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Оберіть операцію (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    double result;

                    if (operation == "+")
                    {
                        result = calc.Add(operand1, operand2);
                    }
                    else if (operation == "-")
                    {
                        result = calc.Subtract(operand1, operand2);
                    }
                    else if (operation == "*")
                    {
                        result = calc.Multiply(operand1, operand2);
                    }
                    else if (operation == "/")
                    {
                        result = calc.Divide(operand1, operand2);
                    }
                    else
                    {
                        throw new InvalidOperationException("Неприпустима операція.");
                    }

                    Console.WriteLine($"Результат: {result}");
                }
                else if (mode == "2")
                {
                    AbstractCalc calc = new AdvancedCalc();
                    IAdvanced advancedCalc = (IAdvanced)calc;
                    Console.WriteLine($"Використовується модель: {calc.GetModel()}");

                    Console.Write("Введіть перше число: ");
                    double operand1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введіть друге число: ");
                    double operand2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Оберіть операцію (+, -, *, /, 'deg2rad' для перетворення градусів у радіани): ");
                    string operation = Console.ReadLine();

                    double result;

                    if (operation == "+")
                    {
                        result = calc.Add(operand1, operand2);
                    }
                    else if (operation == "-")
                    {
                        result = calc.Subtract(operand1, operand2);
                    }
                    else if (operation == "*")
                    {
                        result = calc.Multiply(operand1, operand2);
                    }
                    else if (operation == "/")
                    {
                        result = calc.Divide(operand1, operand2);
                    }
                    else if (operation == "deg2rad")
                    {
                        Console.Write("Введіть значення в градусах (від 0 до 360): ");
                        double degrees = Convert.ToDouble(Console.ReadLine());
                        result = advancedCalc.ConvertDegreesToRadians(degrees);
                    }
                    else
                    {
                        throw new InvalidOperationException("Неприпустима операція.");
                    }

                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Неправильний вибір режиму.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine("Бажаєте повторити операцію? (y/n): ");
            string repeat = Console.ReadLine();
            if (repeat.ToLower() != "y") break;
        }
    }
}