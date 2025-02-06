
namespace Desafio03;

public class Matematica
{
    private static int Soma(int valor1, int valor2)
    {
        return valor1 + valor2; 
    }
    private static int  Subtração(int valor1, int valor2)
    {
        return valor1 - valor2;
    }
    private static int Multiplicação(int valor1, int valor2)
    {
        return valor1 * valor2;
    }
    private static float Divisao(int valor1, int valor2)
    {
        if (valor2 == 0)
        {
            return 0;
        }else
        {
            return (float)valor1 / valor2;
        }
    }
    private static int Media(int valor1, int valor2)
    {
        return ((valor1 + valor2) / 2);
    }

    public static void Operacoes()
    {
        Console.WriteLine("Bem vindo ao MateCode, insira 2 números a sua escolha e veja os resultados!");
        Console.WriteLine("Número 1: ");

        string? valor1 = Console.ReadLine();
        int numero1 = int.Parse(valor1);

        Console.WriteLine("Número 2: ");
        string? valor2 = Console.ReadLine();
        int numero2 = int.Parse(valor2);

        Console.WriteLine($"Adição: {Soma(numero1, numero2)}");
        Console.WriteLine($"Subtração: {Subtração(numero1, numero2)}");
        Console.WriteLine($"Divisão: {Divisao(numero1, numero2)}");
        Console.WriteLine($"Multiplicação: {Multiplicação(numero1, numero2)}");
        Console.WriteLine($"Media: {Media(numero1, numero2)}");
    }

}
