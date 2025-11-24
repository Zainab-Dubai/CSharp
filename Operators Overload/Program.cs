using System; // 📦 Importing the System namespace so we can use Console and other core features

// 🧑‍💼 Employee class definition: represents a worker with an Id, FirstName, and LastName
public class Employee
{
    // 🔑 Unique identifier for each employee
    public int Id { get; set; }

    // 📝 Employee's first name
    public string FirstName { get; set; }

    // 📝 Employee's last name
    public string LastName { get; set; }

    // ⚖️ Overloading the "==" operator to compare Employees by their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // 🛡️ Handle null checks to avoid runtime explosions
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // 🎯 Compare based on Id property only
        return emp1.Id == emp2.Id;
    }

    // ⚖️ Overloading the "!=" operator (must be paired with "==")
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2); // 🚀 Reuse the == logic and invert it
    }

    // 🛠️ Override Equals to keep consistency with operator overloading
    public override bool Equals(object obj)
    {
        var other = obj as Employee;
        if (other == null) return false;
        return this.Id == other.Id;
    }

    // 🛠️ Override GetHashCode to align with Equals (important for collections)
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}

// 🎬 Program entry point
class Program
{
    static void Main(string[] args)
    {
        // 🏗️ Create first Employee object and assign values
        Employee emp1 = new Employee { Id = 101, FirstName = "Alice", LastName = "Johnson" };

        // 🏗️ Create second Employee object and assign values
        Employee emp2 = new Employee { Id = 101, FirstName = "Zainab", LastName = "Dubai" };

        // 🔍 Compare the two employees using overloaded "=="
        bool areEqual = emp1 == emp2;

        // 📢 Display the comparison result
        Console.WriteLine($"Are emp1 and emp2 equal (by Id)? {areEqual}");

        // 🔍 Compare the two employees using overloaded "!="
        bool areNotEqual = emp1 != emp2;

        // 📢 Display the comparison result
        Console.WriteLine($"Are emp1 and emp2 not equal (by Id)? {areNotEqual}");

        // 🏁 Keep console open until user presses a key
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
