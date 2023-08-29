namespace Exercicio04_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> dados = new HashSet<int>(){
                2, 5, 1, 3, 4, 9, 7, 8, 10, 6,
            };
            Console.WriteLine("Digite o número que você deseja encontrar");
            int entrada = Convert.ToInt32(Console.ReadLine());


            if (dados.Contains(entrada))
            {
                Console.WriteLine($"O número {entrada} foi encontrado!");
            }
            else
            {
                Console.WriteLine($"O número {entrada} não foi encontrado!");
            }

        }
    }
}