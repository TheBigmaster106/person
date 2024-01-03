using obiektowanie;

class Program
{
    static void Main()
    {
        // Przykład użycia
        person person1 = new person("Michal", "WielkiK", "Mężczyzna", new DateTime(1990, 1, 14));
        Console.WriteLine(person1);
    }
}