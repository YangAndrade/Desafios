
namespace Desafio01;

internal class BemVindo
{
    public static void Mensagem()
    {
        Console.WriteLine("Digite seu nome: ");
        string usuario = Console.ReadLine();
        Console.WriteLine($"Bem-vindo, {usuario}!");
    }

}
