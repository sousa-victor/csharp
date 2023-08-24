namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Informe o número A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o número B");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o número C");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a + b) > c)
            {
                Console.WriteLine("A soma de A + B é maior que C");
            }
            else if ((a + b) < c)
            {
                Console.WriteLine("a soma de A + b é menor que C");
            }
            else
            {
                {
                    Console.WriteLine("A soma de A + B é igual a C");
                }
            }
        }
    }
}