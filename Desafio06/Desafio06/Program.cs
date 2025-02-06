namespace Desafio06;

class Desafio06
{
    public static void Main()
    {
         DateTime dataAtual = DateTime.Now;
         Console.WriteLine("Escolha um formato para exibir a data atual: ");
         Console.WriteLine("1. Formato completo (Dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
         Console.WriteLine("2. Apenas a data (dd/MM/yyyy)");
         Console.WriteLine("3. Apenas a hora (HH:mm)");
         Console.WriteLine("4. Data com o mês por extenso (dd MMMM yyyy)");


        int data = int.Parse(Console.ReadLine());

        switch (data)
        {
            case 1:
                Console.WriteLine("Formato completo: " + dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss"));
                break;
            case 2:
                Console.WriteLine("Apenas a data: " + dataAtual.ToString("dd/MM/yyyy"));
                break;
            case 3:
                Console.WriteLine("Apenas a hora: " + dataAtual.ToString("HH:mm"));
                break;
            case 4:
                Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd MMMM yyyy"));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    }
