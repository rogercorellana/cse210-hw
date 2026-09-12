using System;

class Program
{
    static void Main(string[] args)
    {
        //necessary instance 
        Program program = new Program();

        program.DisplayWelcome();

        string userName = program.PromptUserName();
        int userNumber = program.PromptUserNumber();
        int squaredNumber = program.SquareNumber(userNumber);

        program.DisplayResult(userName, squaredNumber);
    }

    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    public string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    public int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    public int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    public void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}
