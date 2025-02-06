using System;

namespace Desafio05;

class Desafio05
{
    public static void Main()
    {
        Console.WriteLine("Bem vindo ao Verifica Placa!");
        Console.WriteLine("Padão -> (xxx-xxxx)!!!!!!");
        Console.WriteLine("Digite uma placa :");
        string placa = Console.ReadLine();

        if (ValidaPlaca(placa))
        {
            Console.WriteLine("Placa válida");
        }else
        {
            Console.WriteLine("Placa Inválida");
        }
    }

    static bool ValidaPlaca(string placa)
    {
        if (placa.Length != 8 || placa[3] != '-')
        {
            return false;
        }
        int i = 0;
        foreach (char c in placa)
        {
            if ( i < 3)
            {
                if (!char.IsLetter(c)) return false;
            }
            else if (i == 3)
            {
                if (c != '-') return false;
            }
            else
            {
                if (!char.IsDigit(c)) return false;
            }
            i++;
        }
        return true;
    }
}