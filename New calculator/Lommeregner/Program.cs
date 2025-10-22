using System.Security.Cryptography.X509Certificates;

namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool VALIDINPUT;
            int number1, number2; 
            double result;
            string userInput;

            do
            {
                Calculator calculator = new Calculator();

                Console.WriteLine("Welcome to the calculator!");
                Console.Write("Enter first number: ");

                VALIDINPUT = int.TryParse(Console.ReadLine(), out number1);

                while (VALIDINPUT != true)
                {
                    Console.Clear();
                    Console.Write("Invalid input please enter a valid number: ");
                    VALIDINPUT = int.TryParse(Console.ReadLine(), out number1);
                }
                
                Console.Clear();
                
                Console.WriteLine("First number: " + number1);
                Console.Write("Choose an operation (+, -, *, /): ");
                
                userInput = Console.ReadLine();

                while (userInput != "+" && userInput != "-" && userInput != "*" && userInput != "/")
                {
                    Console.Clear();
                    Console.WriteLine("First number: " + number1);
                    Console.Write("Invalid operation please use one of the following operators (+, -, *, /): ");
                    userInput = Console.ReadLine();
                }
                
                Console.Clear();
                Console.WriteLine($"{number1} {userInput}");


                Console.Write("Enter second number: ");
                VALIDINPUT = int.TryParse(Console.ReadLine(), out number2);

                if (userInput == "/")
                {
                    while (number2 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"{number1} / {number2}");
                        Console.WriteLine("Error cant divide by 0");
                        Console.Write("Please enter a new number: ");
                        VALIDINPUT = int.TryParse(Console.ReadLine(), out number2);
                    }

                }

                while (VALIDINPUT != true)
                {
                    Console.Clear();
                    Console.WriteLine($"{number1} {userInput}");
                    Console.Write("Invalid input please enter a valid number: ");
                    VALIDINPUT = int.TryParse(Console.ReadLine(), out number2);
                }

                switch (userInput)
                {
                    case "+":
                        result = calculator.Add(number1, number2);
                        break;

                    case "-":
                        result = calculator.Subtract(number1, number2);
                        break;
                    case "*":
                        result = calculator.Multiply(number1, number2);
                        break;
                    case "/":
                        result = calculator.Divide(number1, number2);
                        break;
                    default:
                        Console.WriteLine("Unknown error ocured");
                        return;
                }
                Console.Clear();
                Console.WriteLine($"{number1} {userInput} {number2} = {result}");
                Console.WriteLine("Press enter to continue or type \"exit\" to quit");
                userInput = Console.ReadLine().ToLower();
                Console.Clear();

            } while (userInput != "exit");

            Console.WriteLine("Thank you for using the calculator, goodbye!");
        }
    }
}
