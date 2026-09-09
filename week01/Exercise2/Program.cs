using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("What is your grade percentage? ");
            int percentage = int.Parse(Console.ReadLine());

            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("invalid input. enter between 0 and 100.");
                return;
            }

            string letter;

            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }


            int lastDigit = percentage % 10;
            string sign;

            if (letter == "A" && lastDigit < 3)
            {
                sign = "-";
            }
            else if (letter != "A" && letter != "F" && lastDigit >= 7)
            {
                sign = "+";
            }
            else if (letter != "A" && letter != "F" && lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        

        Console.WriteLine($"your grade is: {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("good, you passed the course.");
        }
        else
        {
            Console.WriteLine("next time.");
        }
    }
    catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the grade percentage.");
        }
    }
}