namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, pares=0, impares=0;

            for (int contador = 1; contador <=10; contador++)
            {
                Console.Write($"Digite o {contador}º número: ");
                entrada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (entrada % 2 ==0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine("Total de números pares: " + pares);
            Console.Write("Total de números ímpares: " + impares);
        }
    }
}