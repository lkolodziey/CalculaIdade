using CalculaIdadeBusiness;
using System;
namespace CalculaIdade
{
    class Program
    {
        static void Main()
        {
            ICalculaIdade calculaIdade = new CalculaIdadeBusiness.CalculaIdade();

            Console.Write("Informe sua data de nascimento [dd/mm/yyyy]: ");
            string bornResult = Console.ReadLine();
            var bornDate = Convert.ToDateTime(bornResult);
            var result = calculaIdade.CalculateFullAge(bornDate);

            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(result);
            Console.ForegroundColor = originalColor;
            Console.Write("Pressione qualquer tecla para encerrar o programa.");
            Console.ReadKey();
        }
    }
}
