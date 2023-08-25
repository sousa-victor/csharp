namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, soma = 0, qtde=0 ;
            do
            {
                Console.Write("Digite um número: ");
                entrada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (entrada%3 ==0 && entrada != 0)
                {
                    soma += entrada;
                    qtde++;
                }

            }
            while (entrada != 0);
            float media = soma / ((float)qtde);
            Console.Write("A média de todos os números múltiplos de 3 é: " + media.ToString("F2"));
        }
    }
}