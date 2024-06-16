// ASSIGNMENT 7 : "SIMPLE CALCULATOR USING METHOD"

// Write a C# program that does the following
// - Display the operations ADD, SUBTRACT, MULTIPLY, DIVIDE
// - Ask the user to select operation
// - Ask the user to input 2 numbers
// - Program will perform the selected operation on the 2 numbers and display the result

//      EXAMPLE OUTPUT:
//      Select 1 to ADD, 2 to SUBTRACT, 3 to MULTIPLY, 4 to DIVIDE
//      User input: 1
//      Input first number: 20
//      Input first number: 30

//      ADD 20 and 30 the result is 50

// Apply the following rules:
// if the user selected SUBTRACT or DIVIDE the first number should be greater than the second number
// if the user DIVIDE and the second number is 0 the program should display invalid input 

namespace OOP_Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select 1 to ADD, 2 to SUBTRACT, 3 to MULTIPLY, 4 to DIVIDE");
            Console.Write("\nUser Input: ");
            int operation = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input first number: ");
            int firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.Write("Input second number: ");
            int secondNumber = Convert.ToInt16(Console.ReadLine());

            Calculation(operation, firstNumber, secondNumber);
        }
        public static void Calculation(int operation, int num1, int num2)
        {
            switch (operation)
            {
                case 1:
                    Console.WriteLine($"ADD {num1} and {num2} the result is {Add(num1, num2)}");
                    break;
                case 2:
                    int difference = Subtract(num1, num2);
                    if (difference >= 0) 
                    {
                        Console.WriteLine($"SUBTRATCT {num1} and {num2} the result is {difference}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.First first number should be greater than second number!");
                    }
                    break;
                case 3:
                    Console.WriteLine($"MULTIPLY {num1} and {num2} the result is {Multiply(num1, num2)}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Second number cannot be 0");
                        break;
                    }
                    else if (num1 > num2)
                    {
                        Console.WriteLine($"DIVIDE {num1} and {num2} the result is {Division(num1, num2)}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. First first number should be greater than second number!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please refer to the operation above");
                    break;
            }
        }
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public static int Subtract(int num1, int num2)
        {
            int difference = num1 - num2;
            return difference;
        }
        public static int Multiply(int num1, int num2)
        {
            int product = num1 * num2;
            return product; 
        }
        public static int Division(int num1, int num2)
        {
            int quotient = num1 / num2;
            return quotient;
        }

    }
}
