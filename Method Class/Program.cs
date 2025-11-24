using System; // 🚪 Gateway to core .NET functionality (Console, Math, etc.)

// 🏗️ Blueprint class where we define our custom logic
class MathHandler
{
    // 🎯 A method that accepts two integers
    // It performs a math operation on the first integer
    // and then displays the second integer to the console
    public void ProcessNumbers(int firstNumber, int secondNumber)
    {
        // ⚙️ Perform a simple math operation on the first number (e.g., multiply by 2)
        int result = firstNumber * 2;

        // 📢 Display the result of the math operation
        Console.WriteLine($"The result of the math operation on the first number ({firstNumber}) is: {result}");

        // 👀 Display the second number directly, as per requirements
        Console.WriteLine($"The second number provided is: {secondNumber}");
    }
}

// 🚀 Entry point of the console application
class Program
{
    static void Main(string[] args)
    {
        // 🧑‍🔧 Instantiate (create) an object of our MathHandler class
        MathHandler handler = new MathHandler();

        // 🔨 Call the method with two integers (positional arguments)
        handler.ProcessNumbers(5, 10);

        // 🎩 Call the method again, but this time specify parameters by name
        handler.ProcessNumbers(firstNumber: 7, secondNumber: 20);

        // 🏁 Keep console open until user presses a key (so results don’t vanish instantly)
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
