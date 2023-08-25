namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma=0, entrada;
            do
            {
                Console.Write("Digite um número: ");
                entrada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (entrada >= 0)
                {
                    soma += entrada;
                }

            }
            while (entrada != 0);
            Console.Write("A soma dos números positivos é: " + soma);
        }
    }
}