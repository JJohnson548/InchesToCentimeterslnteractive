using System;

class Program
{
    public static void Main(string[] args)
    {


        const double CENTIMETERS_IN_INCHES = 2.54;

        Console.Write("Enter number inches: ");
        string input = Console.ReadLine();

        double inches;
        if (double.TryParse(input, out inches))
        {
            double centimeters = inches * CENTIMETERS_IN_INCHES;

            Console.WriteLine($"{inches} inches is equal to {centimeters} centimeters.");

        }

        else
        {
            Console.WriteLine("WRONG input. Please enter a number.");

        }

    }
}