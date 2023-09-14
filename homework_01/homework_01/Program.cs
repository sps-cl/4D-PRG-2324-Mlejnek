using System;

public interface IOperation
{
    int Execute(int a, int b);
}

public class OpAdd : IOperation
{
    public int Execute(int a, int b)
    {
        return a + b;
    }
}

public class OpSub : IOperation
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}

public class OpMagic : IOperation
{
    public int Execute(int a, int b)
    {
        return (a + b) * (a + b);
    }
}

public class CalculatorContext
{
    private IOperation _operation;

    public CalculatorContext(IOperation operation)
    {
        _operation = operation;
    }

    public int ExecuteOperation(int a, int b)
    {
        return _operation.Execute(a, b);
    }
}

class CalculatorApp
{
    static void Main()
    {
        Console.Write("Zadej první číslo: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Zadej druhé číslo: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Zadej požadovanou operaci (+ / - / ?): ");
        string selectedOp = Console.ReadLine();

        IOperation op;

        if (selectedOp == "+")
        {
            op = new OpAdd();
        }
        else if (selectedOp == "-")
        {
            op = new OpSub();
        }
        else if (selectedOp == "?")
        {
            op = new OpMagic();
        }
        else
        {
            Console.WriteLine("Neplatná operace");
            return;
        }

        CalculatorContext calculator = new CalculatorContext(op);
        Console.Write($"Výsledek příkladu je {calculator.ExecuteOperation(a, b)}");
        Console.ReadLine();
    }
}