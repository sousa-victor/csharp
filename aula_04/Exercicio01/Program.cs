namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Digite o primeiro número do intervalo: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o último número do intervalo: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("Intervalo inválido!");
            }
            else
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i%3 == 0 && i%5 == 0 && i != 0)
                    {
                        Console.WriteLine(i + " é multiplo de 3 e 5.");
                    }
                }
            }
        }
    }
}