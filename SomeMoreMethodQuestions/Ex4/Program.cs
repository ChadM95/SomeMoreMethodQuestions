namespace Ex4;

class Program
{
    static void Main(string[] args)
    {
        int volume;

        volume = GetVolume(10,5,3);

        Console.WriteLine(volume);

        Console.ReadKey();
    }

    static int GetVolume(int length, int width, int height)
    {
        return length * width * height;
    }
}

