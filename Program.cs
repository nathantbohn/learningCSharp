

public class Program
{
    public static void Main()
    {
       Console.WriteLine("Hello. What is your name?");
       string name = Console.ReadLine();
       Console.WriteLine($"Nice to meet you {name}!", name);
    }
}

