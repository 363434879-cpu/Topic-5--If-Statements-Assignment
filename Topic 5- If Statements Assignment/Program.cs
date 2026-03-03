namespace Topic_5__If_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naika

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

        }

    }

}   

