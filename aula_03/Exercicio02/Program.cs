namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int num = Convert.ToInt32(Console.ReadLine());
            string parOuImpar, positivoNegativo;

            if (num >= 0)
            {
                positivoNegativo = "positivo!";
            }
            else
            {
                {
                    positivoNegativo = "negativo!";
                }
            }

            if (num%2 == 0)
            {
                parOuImpar = "par";
            }
            else
            {
                parOuImpar = "ímpar";
            }

            Console.WriteLine($"O número {num} é {parOuImpar} e {positivoNegativo}");
        }
    }
}