using System; // 📦 Importing System namespace so we can use Console and other core features

// 🎭 Define an interface called IQuittable
// Interfaces are like contracts: they say "any class that signs this contract must implement these methods."
public interface IQuittable
{
    // 📝 The Quit method signature — no body here, just a promise that any implementing class will define it
    void Quit();
}

// 🧑‍💼 Employee class: represents a worker with Id, FirstName, and LastName
// 🚀 Notice: Employee inherits from IQuittable, meaning it must implement Quit()
public class Employee : IQuittable
{
    // 🔑 Unique identifier for each employee
    public int Id { get; set; }

    // 📝 Employee's first name
    public string FirstName { get; set; }

    // 📝 Employee's last name
    public string LastName { get; set; }

    // 🎬 Implementation of the Quit method from IQuittable
    // Here we can define any behavior we want when an employee "quits"
    public void Quit()
    {
        // 📢 Display a dramatic resignation message to the console
        Console.WriteLine($"Employee {FirstName} {LastName} (Id: {Id}) has quit the job. Goodbye!");
    }
}

// 🎬 Program entry point
class Program
{
    static void Main(string[] args)
    {
        // 🏗️ Create an Employee object and assign values
        Employee emp = new Employee { Id = 202, FirstName = "Zainab", LastName = "Dubai" };

        // 🎭 Polymorphism in action:
        // Even though 'emp' is an Employee, we can treat it as an IQuittable because Employee implements IQuittable
        IQuittable quittableEmp = emp;

        // 🔨 Call the Quit method using the interface reference
        quittableEmp.Quit();

        // 🏁 Keep console open until user presses a key
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
