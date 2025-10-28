using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display greeting message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.Write("Please enter the package weight: ");
            // Read input and convert to decimal
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End program if condition is met
                return;
            }

            // Prompt user for package width
            Console.Write("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package height
            Console.Write("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package length
            Console.Write("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if total dimensions exceed 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End program if condition is met
                return;
            }

            // Calculate the quote:
            // Multiply dimensions together, multiply by weight, then divide by 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the result formatted as a dollar amount with 2 decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
