using System;

namespace Maior2Numeros_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroA, numeroB;


            Console.WriteLine("--- Maior 2 numeors ---");

            Console.Write("Digite um numero..:");
            numeroA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um numero..:");
            numeroB = Convert.ToInt32(Console.ReadLine());
            if (numeroA > numeroB)
            {
                Console.WriteLine($" {numeroA} é maior que {numeroB}.");
            }

            if (numeroB > numeroA)
            {
                Console.WriteLine($"{numeroB} é maior que {numeroA}.");
            }

            if (numeroA == numeroB)
            {
                Console.WriteLine("Os numeros digitados são iguais.");
            }


        }
    }
}
