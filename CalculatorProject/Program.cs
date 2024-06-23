namespace CalculatorProject;

class Program
{
    static void Main(string[] args)
    {
        // --------------------- version 1 ---------------------------------
        // int number1;
        // int number2;
        // int result;
        // Console.Write("Number 1 : ");
        // int.TryParse(Console.ReadLine(), out number1);
        // Console.Write("Number 2 : ");
        // int.TryParse(Console.ReadLine(), out number2);
        // Console.Write("Choose  : ");
        // string typeOfCalculation = Console.ReadLine();
        //
        // if (typeOfCalculation == "a")
        // {
        //     result = number1 + number2;
        //     Console.WriteLine("{0} + {1} = {2}",number1, number2, result);
        // }else if (typeOfCalculation == "s")
        // {
        //     result = number1 - number2;
        //     Console.WriteLine("{0} - {1} = {2}",number1, number2, result);
        // }else if (typeOfCalculation == "m")
        // {
        //     result = number1 * number2;
        //     Console.WriteLine("{0} * {1} = {2}",number1, number2, result);
        // }else if (typeOfCalculation == "d")
        // {
        //     result = number1 / number2;
        //     Console.WriteLine("{0} / {1} = {2}",number1, number2, result);
        // }else
        // {
        //     Console.WriteLine("Error");
        //     return;
        // }

        int number1 = GetNumber("Number 1 : ");
        int number2 = GetNumber("Number 2 : ");
        Console.Write("Choose (a for addition, s for subtraction, m for multiplication, d for division): ");
        string typeOfCalculation = Console.ReadLine();
        switch (typeOfCalculation)
        {
            case "a":
                PerformCalculation(number1, number2, number1 + number2, "+");
                break;
            case "s":
                PerformCalculation(number1, number2, number1 - number2, "-");
                break;
            case "m":
                PerformCalculation(number1, number2, number1 * number2, "*");
                break;
            case "d":
                if (number2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    PerformCalculation(number1, number2, number1 / number2, "/");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid calculation type.");
                break;
        }
    }

    static int GetNumber(string prompt)
    {
        int number;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write(prompt);
        }
        return number;
    }
    
    static void PerformCalculation(int number1, int number2, int result, string operation)
    {
        Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, result);
    }
}