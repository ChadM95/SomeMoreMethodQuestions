namespace Ex2;

class Program
{
    static void Main(string[] args)
    {
        SayHi("Mary");
        SayHi("John");
        SayHi("Sally");
        Console.ReadKey();
    }

    static void SayHi(string name)
    {
        Console.WriteLine($"Hi, {name}. I hope you are well today.");
    }
}
