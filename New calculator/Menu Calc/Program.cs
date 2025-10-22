namespace Menu_Calc
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

                Start:
                Console.WriteLine("Welcome to the calculator!");
                Console.WriteLine("\nPlease choose an operation: ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.Write("\nType 'exit' to quit the program: ");
                
                userInput = Console.ReadLine().ToLower();

                // Validate user input else go back to start
                while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "exit")
                {
                    Console.Clear();
                    goto Start;
                }
                
                if (userInput == "exit")
                {
                    break;
                }
                Console.Clear();
                Console.Write("Enter first number: ");

                VALIDINPUT = int.TryParse(Console.ReadLine(), out number1);

                while (VALIDINPUT != true)
                {
                    Console.Clear();
                    Console.Write("Invalid input please enter a valid number: ");
                    VALIDINPUT = int.TryParse(Console.ReadLine(), out number1);
                }

                Console.Clear();
                Console.WriteLine($"First number: {number1}");


                Console.Write("Enter second number: ");
                VALIDINPUT = int.TryParse(Console.ReadLine(), out number2);

                if (userInput == "4")
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
                    Console.WriteLine($"First number: {number1}");
                    Console.Write("Invalid input please enter a valid number: ");
                    VALIDINPUT = int.TryParse(Console.ReadLine(), out number2);
                }

                switch (userInput)
                {
                    case "1":
                        result = calculator.Add(number1, number2);
                        userInput = "+";
                        break;
                    case "2":
                        result = calculator.Subtract(number1, number2);
                        userInput = "-";
                        break;
                    case "3":
                        result = calculator.Multiply(number1, number2);
                        userInput = "*";
                        break;
                    case "4":
                        result = calculator.Divide(number1, number2);
                        userInput = "/";
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
            
            Console.Clear();
            Console.WriteLine("Thank you for using the calculator, goodbye!");
        }
    }
}
