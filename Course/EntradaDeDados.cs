using System.Globalization;

namespace Course;

class EntradaDeDados
{
    static void Main(string[] args)
    {
        Console.Write($"Entre com seu nome completo: ");
        string nome = Console.ReadLine();

        Console.Write($"Quantos quartos tem na sua casa? ");
        int qtdQuartos = int.Parse(Console.ReadLine());

        Console.Write($"Entre com o preço do produto: ");
        double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite sua, rua, numero e cidade");
        string[] adreess = Console.ReadLine().Split(' ');

        Console.WriteLine($"Cliente: {nome}, Quantidade de quartos: {qtdQuartos}, total: {precoProduto.ToString("2F", CultureInfo.InvariantCulture)} e endereço: {adreess[0]}, {adreess[1]}, {adreess[2]}");
    }
}