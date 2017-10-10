using System;

class Homework_02
{
    static void Main()
    {
        Console.WriteLine("Please enter number 1 : ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number 2 : ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please select an operation : ");
        Console.WriteLine("1 for (+)");
        Console.WriteLine("2 for (-)");
        Console.WriteLine("3 for (*)");
        Console.WriteLine("4 for (/)");

        Console.WriteLine("Your choice : ");
        string operation = Console.ReadLine();

        int result = 0;
        string operationAsString = "";

        if (operation == "1")
        {
            result = number1 + number2;
            operationAsString = " + ";
        }
        if (operation == "2")
        {
            result = number1 - number2;
            operationAsString = " - ";
        }
        if (operation == "3")
        {
            result = number1 * number2;
            operationAsString = " * ";
        }
        if (operation == "4")
        {
            result = number1 / number2;
            operationAsString = " / ";
        }

        Console.WriteLine("Result is {0} {1} {2} = {3}",
        number1,
        operationAsString,
        number2,
        result);

        Console.ReadLine();
    }

}