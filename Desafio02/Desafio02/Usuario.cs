
namespace Desafio02;

public class Usuario
{
    public static void NomeCompleto ()
    {
        Console.WriteLine("Digite seu primerio nome: ");
        var primerioNome = Console.ReadLine();
        Console.WriteLine("Digite o seu sobrenome: ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine($"Então seu nome completo é {primerioNome + " "+ sobrenome}, muito prazer! (= ");

           
    }
}
