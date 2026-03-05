using System;

namespace Topic_5__If_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Naika

            Console.Title = "Topic 5 - If Statements Assignment";

            Console.WriteLine("Welcome to the If Statements Assignment!");
            Console.WriteLine();

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello " + name + "! Press ENTER to continue.");
            Console.ResetColor();

            Console.ReadLine();
            Console.Clear();

            // MENU
            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. Space Boxing");
            Console.WriteLine("2. Simple Calculator");
            Console.WriteLine();

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (choice == 1)
            {
                SpaceBoxing();
            }
            else if (choice == 2)
            {
                SimpleCalculator();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.ReadLine();
        }

        // PART 1 - SPACE BOXING
        static void SpaceBoxing()
        {
            Console.Write("Please enter your current earth weight: ");
            double earthWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus   2. Mars   3. Jupiter");
            Console.WriteLine("4. Saturn  5. Uranus 6. Neptune");

            Console.Write("Which planet are you visiting? ");
            int planet = Convert.ToInt32(Console.ReadLine());

            double newWeight = 0;

            if (planet == 1)
                newWeight = earthWeight * 0.78;
            else if (planet == 2)
                newWeight = earthWeight * 0.39;
            else if (planet == 3)
                newWeight = earthWeight * 2.65;
            else if (planet == 4)
                newWeight = earthWeight * 1.17;
            else if (planet == 5)
                newWeight = earthWeight * 1.05;
            else if (planet == 6)
                newWeight = earthWeight * 1.23;
            else
            {
                Console.WriteLine("Invalid planet number.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Your weight would be " + newWeight.ToString("F2") + " pounds on that planet.");
        }

        // PART 2 - SIMPLE CALCULATOR
        static void SimpleCalculator()
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Operators: +  -  x  /  ^2 (square)  sqrt (square root)");
            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            if (op == "^2")
            {
                Console.Write("Enter a number: ");
                double num = Convert.ToDouble(Console.ReadLine());

                double result = num * num;

                Console.WriteLine(num + "^2 = " + result);
            }
            else if (op == "sqrt")
            {
                Console.Write("Enter a number: ");
                double num = Convert.ToDouble(Console.ReadLine());

                // What happens if you try to take the square root of a negative number?
                // In C#, Math.Sqrt(-9) returns NaN ("Not a Number") because the square root
                // of a negative number is not a real number.

                if (num < 0)
                {
                    Console.WriteLine("You cannot take the square root of a negative number.");
                    return;
                }

                double result = Math.Sqrt(num);

                Console.WriteLine("√" + num + " = " + result);
            }
            else
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                if (op == "+")
                    result = num1 + num2;
                else if (op == "-")
                    result = num1 - num2;
                else if (op == "x")
                    result = num1 * num2;
                else if (op == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("You cannot divide by zero.");
                        return;
                    }

                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Invalid operator.");
                    return;
                }

                Console.WriteLine(num1 + " " + op + " " + num2 + " = " + result);
            }
        }
    }
}