namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int somaPrincipal = 0, somaSecundaria = 0;

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Informe o item da {j+1}ª linha e {i+1}ª coluna:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }   
            }
            
            Console.WriteLine("Elementos da Diagonal Principal:");

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j] + " ");
                        somaPrincipal += matriz[i, j];
                    }
                }
            }

            Console.WriteLine("\n\nElementos da Diagonal Secundária");

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i+j ==2)
                    {
                        Console.Write(matriz[i, j] + " ");
                        somaSecundaria += matriz[i, j];
                    }
                }
            }
            Console.WriteLine("\n\nSoma dos Elementos da Diagonal Principal:");
            Console.WriteLine(somaPrincipal);
            Console.WriteLine("\nSoma dos Elementos da Diagonal Secundária:");
            Console.WriteLine(somaSecundaria);

        }
    }
}