using System.Collections.Immutable;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            Console.Write("Digite o número que você deseja encontrar: ");
            int entrada = Convert.ToInt32(Console.ReadLine());
            int posicao = -1;
            
            for (int i = 0; i< vetor.Length; i++)
            {
                if (entrada == vetor[i])
                {
                    posicao = i;
                    break;
                }
            }
            if (posicao != -1)
            {
                Console.WriteLine($"O número {entrada} está na posição: {posicao}");
            }
            else
            {
                Console.WriteLine($"O número {entrada} não foi encontrado!");
            }

        }
    }
}