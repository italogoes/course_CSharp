using System.Globalization;

namespace Course;

class EntradaDeDados
{
    static void Main(string[] args)
    {
        string[] v = Console.ReadLine().Split(' ');

        string a = v[0];
        string b = v[1];
        string c = v[2];

        Console.WriteLine($"{a} {b} {c}");
    }
}

