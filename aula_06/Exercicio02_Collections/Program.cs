namespace Exercicio02_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                2, 5, 1, 3, 4, 9, 7, 8, 10, 6
            };

            Console.Write("Digite o número que você deseja encontrar: ");
            int entrada = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
             //FORMA UTILIZANDO MÉTODO
            /*
            if (numeros.IndexOf(entrada) != -1)
            {
                Console.Write($"O número {entrada} está localizado na posição: " + numeros.IndexOf(entrada));
            }
            else
            {
                Console.WriteLine($"O número {entrada} não foi encontrado!");
            }
            */

            //FORMA UTILIZANDO LAÇO DE REPETIÇÃO
            
            for (int i = 0; i < numeros.Count; i++)
            {
                if(entrada == numeros[i])
                {
                    Console.Write($"O número {entrada} está localizado na posição: {i}");
                    break;
                }
                if (i == numeros.Count-1 && entrada != numeros[i])
                {
                    Console.Write($"O número {entrada} não foi encontrado!");
                }
            }
            
        }
    }
}