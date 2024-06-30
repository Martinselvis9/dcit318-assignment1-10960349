using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
       Console.WriteLine("WELCOME TO TICKET PRICE CALCULATOR");
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        double price = CalculateTicketPrice(age);

        Console.WriteLine($"Ticket Price: GHC{price}");
    }

    static double CalculateTicketPrice(int age)
    {
        if (age <= 12 || age >= 65)
        {
            return 7.00;
        }
        return 10.00;
    }
}
