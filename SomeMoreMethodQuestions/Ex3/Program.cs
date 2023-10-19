namespace Ex3;

class Program
{
    static void Main(string[] args)
    {
        int number1, number2, number3, number4, number5, number6;

        number1 = GetNumber();
        number2 = GetNumber();
        number3 = GetNumber();
        number4 = GetNumber();
        number5 = GetNumber();
        number6 = GetNumber();

        Display(number1,number2,number3,number4,number5,number6);

        Console.ReadKey();
    }

    static int GetNumber()
    {
        Console.Write("Enter Number> ");
        return int.Parse(Console.ReadLine());
    }

    static void Display(int number1, int number2, int number3, int number4, int number5, int number6)
    {
        Console.WriteLine("Lottery Number: "+number1+number2+number3+number4+number5+number6);
    }
}

