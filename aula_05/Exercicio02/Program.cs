namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Clear();
                Console.Write($"Informe o {i + 1}º número do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                soma += vetor[i];
            }

            Console.Clear();

            Console.WriteLine("Elementos nos índices ímpares:");
            for(int i = 0;i < vetor.Length; i++)
            {
                if (i%2 != 0)
                {
                    Console.Write(vetor[i] + " ");
                }
            }

            Console.WriteLine("\n\nElementos pares:");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
            Console.WriteLine("\n\nSoma: " + soma + "\n");
            Console.WriteLine("Média: " + (soma/(float)vetor.Length).ToString("F2"));
        }
    }
}