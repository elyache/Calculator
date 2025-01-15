using System.ComponentModel;
using System.Xml.Linq;
using static Calculator.Program;

namespace Calculator
{
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter operation: '+', '-', '*', '/'");
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case '+':
                Console.WriteLine(Addition.Execute(num1, num2));
                break;
            case '-':
                Console.WriteLine(Subtraction.Execute(num1, num2));
                break;
            case '*':
                Console.WriteLine(Multiplication.Execute(num1, num2));
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine(Division.Execute(num1, num2));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}

public abstract class Operation
{
    public abstract static int Execute(int num1, int num2);
}

public class Addition : Operation
{
    public static int Execute(int num1, int num2)
    {
        return num1 + num2;
    }
}

public class Subtraction : Operation
{
    public static int Execute(int num1, int num2)
    {
        return num1 - num2;
    }
}

public class Multiplication : Operation
{
    public static int Execute(int num1, int num2)
    {
        return num1 * num2;
    }
}

public class Division : Operation
{
    public static int Execute(int num1, int num2)
    {
        return num1 / num2;
    }
}
}

