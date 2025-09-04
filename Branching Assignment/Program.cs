using System;

class Program
{
    static void Main()
    {
        // Display the welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight
        Console.Write("Please enter the package weight: ");
        string weightInput = Console.ReadLine(); // Read user input as string
        float packageWeight;

        // Try to parse the weight input to a float, and handle invalid inputs
        if (!float.TryParse(weightInput, out packageWeight))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for weight.");
            return; // Exit the program
        }

        // Check if the package is too heavy
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program if the weight is too much
        }

        // Prompt the user for the package width
        Console.Write("Please enter the package width: ");
        string widthInput = Console.ReadLine();
        float packageWidth;

        if (!float.TryParse(widthInput, out packageWidth))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for width.");
            return;
        }

        // Prompt the user for the package height
        Console.Write("Please enter the package height: ");
        string heightInput = Console.ReadLine();
        float packageHeight;

        if (!float.TryParse(heightInput, out packageHeight))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for height.");
            return;
        }

        // Prompt the user for the package length
        Console.Write("Please enter the package length: ");
        string lengthInput = Console.ReadLine();
        float packageLength;

        if (!float.TryParse(lengthInput, out packageLength))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for length.");
            return;
        }

        // Calculate the total size by summing dimensions
        float totalDimensions = packageWidth + packageHeight + packageLength;

        // Check if the dimensions exceed the limit
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the quote: (width * height * length) * weight / 100
        float quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

        // Display the quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}
