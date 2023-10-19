namespace Ex1;

class Program
{
    static void Main(string[] args)
    {
        Menu();
        Console.ReadKey();
    }

    static void Menu()
    {
        Console.WriteLine("Press 1 for Sales");
        Console.WriteLine("Press 2 for Service");
        Console.WriteLine("Press 3 to hold for an operator");
    }
}

